namespace Gen;

using RelaxNg.Schema;

internal static class ElementExtension
{
    internal static bool TryAddProperty(
        this Element self,
        CodeContext context,
        CodeTypeDeclaration type,
        PropertyState status)
    {
        context.EnterProperty(self);
        try
        {
            // TODO: check interleave
            self.TryParseType(context, out var typeSpec);

            Code.ConvertForElement(
                status.ToType(typeSpec!),
                self.Name.GetName(),
                self.Namespace,
                out var field,
                out var prop);

            if (!Code.HasProperty(context, type, prop))
            {
                type.Members.Add(field);
                type.Members.Add(prop);

                if (status.NeedSpecifiedFlag(typeSpec!))
                {
                    Code.ConvertForSpecified(self.Name.GetName(), out var sfield, out var sprop);

                    type.Members.Add(sfield);
                    type.Members.Add(sprop);
                }
            }

            return true;
        }
        finally
        {
            context.ExitProperty();
        }
    }

    internal static bool TryParseType(this Element self, CodeContext context, out TypeSpec? type)
    {
        if (((IHasChildren)self).TryParseSimpleType(context, false, out type))
        {
            return true;
        }

        var className = Utility.ToClassName(context.GetClassName(self, out var xmlModifier));
        type = new TypeSpec(new CodeTypeReference(className), false);

        if (!context.IsParsed(className))
        {
            if (((IHasChildren)self).TryParseSimpleType(context, true, out var _))
            {
                context.AddExtensionType(className, self, xmlModifier);
            }
            else
            {
                context.AddType(className, self, xmlModifier, null, null);
            }
        }

        return true;
    }
}
