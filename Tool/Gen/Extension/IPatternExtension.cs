namespace Gen;

using RelaxNg.Schema;

internal static class IPatternExtension
{
    internal static IEnumerable<Element> RetrieveElement(this IPattern self, CodeContext context)
    {
        return self.RetrievePattern(context, true).OfType<Element>();
    }

    internal static IEnumerable<IPattern> RetrievePattern(this IPattern self, CodeContext context, bool flattenChoice)
    {
        switch (self)
        {
            case Attribute:
            case Choice when !flattenChoice:
            case Data:
            case Element:
            case Empty:
            case NotAllowed:
            case Text:
            case Value:
                yield return self;
                break;

            case ExternalRef:
            case Grammar:
            case List:
            case Mixed:
            case ParentRef:
                throw new NotSupportedException($"Not supported tag `{self.GetType().Name}`.");

            case Choice choice when flattenChoice:
                foreach (var item in choice.Children.SelectMany(c => c.RetrievePattern(context, flattenChoice)))
                {
                    yield return item;
                }

                break;

            case Ref r:
                foreach (var item in r.RetrievePattern(context, flattenChoice))
                {
                    yield return item;
                }

                break;

            case IHasChildren hasChildren:
                // Group, Interleave, OneOrMore, Optional, ZeroOrMore
                foreach (var item in hasChildren.Children.SelectMany(c => c.RetrievePattern(context, flattenChoice)))
                {
                    yield return item;
                }

                break;
        }
    }

    internal static bool TryParseSimpleType(this IPattern self, CodeContext context, bool ignoreAttribute, out TypeSpec? type)
    {
        if (self is null)
        {
            type = new TypeSpec(typeof(string));
            return true;
        }

        switch (self)
        {
            case Choice choice:
                return choice.TryParseSimpleType(context, ignoreAttribute, out type);
            case Data data:
                type = new TypeSpec(DataType.Get(data.Type)!);
                return true;
            case Ref r:
                return r.TryParseSimpleType(context, ignoreAttribute, out type);
            case Text:
                type = new TypeSpec(typeof(string));
                return true;
            case Value:
                type = new TypeSpec(typeof(string));
                return true;
            case IHasChildren hasChildren:
                return hasChildren.TryParseSimpleType(context, ignoreAttribute, out type);
            default:
                type = null;
                return false;
        }
    }
}
