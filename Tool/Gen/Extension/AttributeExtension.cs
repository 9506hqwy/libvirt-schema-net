namespace Gen;

using RelaxNg.Schema;

internal static class AttributeExtension
{
    internal static bool TryAddProperty(
        this Attribute self,
        CodeContext context,
        CodeTypeDeclaration type,
        PropertyState status)
    {
        context.EnterProperty(self);
        try
        {
            if (self.Child!.TryParseSimpleType(context, false, out var typeSpec))
            {
                Code.ConvertForAttribute(
                    typeSpec!.Type,
                    self.Name.GetName(),
                    out var field,
                    out var prop);

                if (!Code.HasProperty(context, type, prop))
                {
                    type.Members.Add(field);
                    type.Members.Add(prop);

                    if (status.NeedSpecifiedFlag(typeSpec))
                    {
                        Code.ConvertForSpecified(self.Name.GetName(), out var sfield, out var sprop);

                        type.Members.Add(sfield);
                        type.Members.Add(sprop);
                    }
                }

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
