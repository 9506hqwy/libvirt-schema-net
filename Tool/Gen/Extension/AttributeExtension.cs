namespace Gen;

using RelaxNg.Schema;

internal static class AttributeExtension
{
    internal static bool TryAddProperty(
        this Attribute self,
        CodeContext context,
        GenTypeDeclaration type,
        PropertyState status)
    {
        context.EnterProperty(self);
        try
        {
            if (self.Child!.TryParseSimpleType(context, false, out var typeSpec))
            {
                var member = new GenTypeMember(context, typeSpec!, self.Name.GetName(), status);
                type.Add(member);
                return true;
            }

            return false;
        }
        finally
        {
            context.ExitProperty();
        }
    }
}
