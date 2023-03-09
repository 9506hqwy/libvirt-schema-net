namespace Gen;

using RelaxNg.Schema;

internal static class INodeExtension
{
    internal static void AddProperty(
        this INode self,
        CodeContext context,
        GenTypeDeclaration cls,
        Func<IPattern, bool> filter,
        PropertyState status)
    {
        if (self is Attribute attr && attr.TryAddProperty(context, cls, status))
        {
            // None
        }
        else if (self is Data data)
        {
            context.AddWarning($"Not supported. Could not add text value in `{cls.Name}`.");
        }
        else if (self is Element element && element.TryAddProperty(context, cls, status))
        {
            // None
        }
        else if (self is Ref r)
        {
            var define = context.Resolve(r);

            if (!context.Skip(define))
            {
                try
                {
                    context.EnterNode(define);
                    try
                    {
                        define.AddProperty(context, cls, filter, (PropertyState)status.Clone());
                    }
                    finally
                    {
                        context.ExitNode();
                    }
                }
                catch (RecursiveDefineException e)
                {
                    context.AddWarning($"Not supported. {e.Message}");
                }
            }
        }
        else if (self is IHasChildren hasChildren)
        {
            status.Set(hasChildren);

            foreach (var child in hasChildren.Children.Where(filter))
            {
                child.AddProperty(context, cls, filter, (PropertyState)status.Clone());
            }
        }
        else if (self is Grammar grammar)
        {
            if (grammar.Contents[0].Inner is Include incl)
            {
                var start = context.GetStart(incl.Href);
                context.EnterNode(start);
                try
                {
                    foreach (var child in start.Child.RetrieveElement(context))
                    {
                        child.AddProperty(context, cls, filter, (PropertyState)status.Clone());
                    }
                }
                finally
                {
                    context.ExitNode();
                }
            }
            else
            {
                context.AddWarning($"Not supported. Skip grammer in `{self.File.Info.Name}`.");
            }
        }
        else
        {
            throw new InvalidProgramException($"Unexpected `{self.GetType().Name}` format at `{context.CurrentProperty.Name.GetName()}` in {self.File.Info.Name}.");
        }
    }

    internal static IEnumerable<Define> RetrieveDefine(this INode self, CodeContext context)
    {
        return self.RetrieveNode(context).OfType<Define>();
    }

    private static IEnumerable<INode> RetrieveNode(this INode self, CodeContext context)
    {
        switch (self)
        {
            // INode
            case Define:
            case GrammarContent:
            case Include:
            case IncludeContent:
            case Start:
                yield return self;
                break;

            // INameBase
            case Name:
                yield return self;
                break;

            // IPattern
            case Attribute:
            case Data:
            case Element:
            case Empty:
            case NotAllowed:
            case Text:
            case Value:
                yield return self;
                break;

            case Ref r:
                foreach (var item in r.RetrieveNode(context))
                {
                    yield return item;
                }

                break;

            // Not Supported
            case Div<GrammarContent>:
            case Div<IncludeContent>:
            case ExceptName:
            case ExceptPattern:
            case Param:
            case INameBase:
                throw new NotSupportedException($"Not supported tag `{self.GetType().Name}`.");

            case IHasChildren hasChildren:
                // Choice, Group, Interleave, OneOrMore, Optional, ZeroOrMore
                foreach (var item in hasChildren.Children.SelectMany(c => c.RetrieveNode(context)))
                {
                    yield return item;
                }

                break;

            case IPattern:
                throw new NotSupportedException($"Not supported tag `{self.GetType().Name}`.");
        }
    }
}
