namespace Gen;

using RelaxNg.Schema;
using System.Reflection;

internal static class IHasChildrenExtension
{
    internal static CodeTypeDeclaration AddBaseType(this IHasChildren self, CodeContext context, out Element element)
    {
        element = self.RetrieveElement(context).SingleOrDefault()!;
        if (element is null)
        {
            throw new NotSupportedException();
        }

        var cls = new CodeTypeDeclaration(Utility.ToClassName(context.GetClassName(null, out var _)))
        {
            IsPartial = true,
            TypeAttributes = TypeAttributes.Public | TypeAttributes.Abstract,
        };

        if (!context.IsParsed(cls.Name))
        {
            context.Add(cls);
        }

        return cls;
    }

    internal static IEnumerable<Element> RetrieveElement(this IHasChildren self, CodeContext context)
    {
        return self.Children.SelectMany(c => c.RetrievePattern(context, true)).OfType<Element>();
    }

    internal static bool TryParseSimpleType(this IHasChildren self, CodeContext context, bool ignoreAttribute, out TypeSpec? type)
    {
        type = null;

        var children = self.Children
            .SelectMany(c => c.RetrievePattern(context, false))
            .ToArray();

        if (!ignoreAttribute)
        {
            if (children.OfType<Attribute>().Any())
            {
                return false;
            }
        }

        var choices = children.OfType<Choice>().ToArray();
        if (choices.Length == 1)
        {
            return choices[0].TryParseSimpleType(context, ignoreAttribute, out type);
        }

        var datum = children.OfType<Data>().ToArray();
        if (datum.Length == 1)
        {
            return datum[0].TryParseSimpleType(context, ignoreAttribute, out type);
        }

        var texts = children.OfType<Text>().ToArray();
        if (texts.Length == 1)
        {
            return texts[0].TryParseSimpleType(context, ignoreAttribute, out type);
        }

        var values = children.OfType<Value>().ToArray();
        if (values.Length == 1)
        {
            return values[0].TryParseSimpleType(context, ignoreAttribute, out type);
        }

        return false;
    }
}
