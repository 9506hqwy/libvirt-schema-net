namespace Gen;

using RelaxNg.Schema;

internal class Repository
{
    private readonly ExcludeDefine[] excludedDefines;

    private readonly Schema schema;

    private readonly Dictionary<RngPosition, ParsedNode> types;

    internal Repository(RngFile[] files, ExcludeDefine[] excludedDefines)
    {
        this.schema = new Schema();
        this.types = new Dictionary<RngPosition, ParsedNode>();

        this.Files = files;
        this.excludedDefines = excludedDefines;

        this.Init();
    }

    internal RngFile[] Files { get; }

    internal ParsedNode[] Types => this.types.Values.Where(v => v.ChildParsed).ToArray();

    private void Init()
    {
        foreach (var file in this.Files)
        {
            file.Parse(this.schema);
        }

        foreach (var file in this.Files)
        {
            this.InitParsedNode(file);
        }

        foreach (var file in this.Files)
        {
            this.ParseStart(file);
        }
    }

    private void InitParsedNode(IPattern pattern)
    {
        switch (pattern)
        {
            case IHasName hasName:
                this.types.Add(hasName.Position, new ParsedNode(hasName));
                break;
            default:
                break;
        }
    }

    private void InitParsedNode(RngFile file)
    {
        foreach (var root in file.Enumerate(this.schema)!)
        {
            foreach (var child in root.DescendantNodesAndSelf.OfType<IPattern>())
            {
                this.InitParsedNode(child);
            }
        }
    }

    private void ParseStart(RngFile file)
    {
        foreach (var root in file.Enumerate(this.schema)!)
        {
            foreach (var start in root.DescendantNodes.OfType<Start>())
            {
                this.ParseStart(null, start, new ParsedStack());
            }
        }
    }

    private void ParseStart(ParsedNode? parent, INode node, ParsedStack stack)
    {
        stack.Add(node);

        switch (node)
        {
            case Data data:
                parent!.AddValue(data, stack.Copy());

                break;

            case Empty:
                parent!.SetEmpty();

                break;

            case Grammar grammar:
                foreach (var content in grammar.Contents)
                {
                    var childStack = stack.Copy();
                    childStack.Add(content);

                    if (content.Inner is Include incl)
                    {
                        var file = this.Files.First(f => f.Info.Name == incl.Href);
                        foreach (var root in file.Enumerate(this.schema)!)
                        {
                            foreach (var start in root.DescendantNodes.OfType<Start>())
                            {
                                this.ParseStart(parent, start, stack.Copy());
                            }
                        }
                    }
                    else
                    {
                        throw new Exception($"Not supported. Unknown grammar syntax in `{content.Position}`.");
                    }
                }

                break;

            case Ref r:
                var childDefine = r.Resolve(stack.Position.File);

                if (!this.Skip(childDefine))
                {
                    if (!stack.HasNode(childDefine))
                    {
                        this.ParseStart(parent, childDefine, stack);
                    }
                }

                break;

            case Start start:
                this.ParseStart(parent, start.Child, stack);

                break;

            case Text text:
                parent!.AddValue(text, stack.Copy());

                break;

            case Value value:
                parent!.AddValue(value, stack.Copy());

                break;

            case ExceptName:
            case ExceptPattern:
            case Include:
            case NameBase:
            case NotAllowed:
            case Param:
            case Unknown:
                break;

            case IHasName hasName:
                var parsedNode = this.types[hasName.Position];

                if (!parsedNode.ChildParsed)
                {
                    parsedNode.Stack = stack.Copy();

                    foreach (var child in hasName.ChildNodes)
                    {
                        this.ParseStart(parsedNode, child, stack.Copy());
                    }

                    parsedNode.ChildParsed = true;
                }
                else
                {
                    var nodeDepth = parsedNode.Stack!.Count<INode>();

                    parsedNode = parsedNode.Copy();

                    parsedNode.Restack(stack);

                    if (parsedNode.Stack!.Count<INode>() < nodeDepth)
                    {
                        this.types[hasName.Position] = parsedNode;
                    }
                }

                parent?.AddChild(parsedNode);

                break;

            case IHasChildren hasChildren:
                // Choice, Define, Div, Group, Interleave, List, Mixed, OneOrMore, Optional, ZeroOrMore
                foreach (var child in hasChildren.Children)
                {
                    this.ParseStart(parent, child, stack.Copy());
                }

                break;

            default:
                throw new InvalidProgramException($"Unexpected syntax at `{node.Position}`.");
        }
    }

    private bool Skip(Define define)
    {
        return this.excludedDefines.Any(d => d.EqualDefine(define));
    }
}
