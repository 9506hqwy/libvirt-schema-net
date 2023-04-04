namespace Gen;

using RelaxNg.Schema;

internal class ParsedNode
{
    private readonly List<ParsedNode> childList;

    private readonly List<ParsedValue> valueList;

    internal ParsedNode(IHasName node)
    {
        this.childList = new List<ParsedNode>();
        this.valueList = new List<ParsedValue>();

        this.Node = node;
    }

    internal bool ChildParsed { get; set; }

    internal ParsedNode[] Children => this.childList.ToArray();

    internal bool IsAttribute => this.Node is Attribute;

    internal bool IsEmpty { get; private set; }

    internal string Name => this.Node.Name.GetName();

    internal IHasName Node { get; }

    internal ParsedStack? Stack { get; set; }

    internal ParsedValue[] Values => this.valueList.ToArray();

    internal void AddChild(ParsedNode child)
    {
        this.childList.Add(child);
    }

    internal void AddValue(IPattern value, ParsedStack stack)
    {
        this.valueList.Add(new ParsedValue(value, stack));
    }

    internal ParsedNode Copy()
    {
        var node = new ParsedNode(this.Node);
        this.childList.ForEach(c => node.childList.Add(c.Copy()));
        node.ChildParsed = this.ChildParsed;
        node.IsEmpty = this.IsEmpty;
        node.Stack = this.Stack?.Copy();
        this.valueList.ForEach(v => node.valueList.Add(v.Copy()));
        return node;
    }

    internal void Restack(ParsedStack stack)
    {
        this.Stack?.Restack(stack);

        foreach (var child in this.Children)
        {
            child.Restack(stack);
        }

        foreach (var value in this.Values)
        {
            value.Restack(stack);
        }
    }

    internal void SetEmpty()
    {
        this.IsEmpty = true;
    }
}
