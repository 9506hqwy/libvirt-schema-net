namespace Gen;

using RelaxNg.Schema;

internal static class ChoiceExtension
{
    internal static bool TryParseSimpleType(this Choice self, CodeContext context, bool ignoreAttribute, out TypeSpec? type)
    {
        type = null;

        var children = self.RetrievePattern(context, true).Where(p => p is not Empty).ToArray();
        if (ignoreAttribute)
        {
            children = children.Where(c => c is not Attribute).ToArray();
        }

        if (children.Any(c => !c.TryParseSimpleType(context, ignoreAttribute, out var _)))
        {
            return false;
        }

        if (children.OfType<Text>().Any())
        {
            type = new TypeSpec(typeof(string));
            return true;
        }

        var types = children.OfType<Data>().Select(d => DataType.Get(d.Type)).ToArray();
        if (types.Length != 0)
        {
            if (types.Contains(typeof(string)))
            {
                type = new TypeSpec(typeof(string));
            }
            else if (types.Contains(typeof(double)))
            {
                type = new TypeSpec(typeof(double));
            }
            else if (types.Contains(typeof(float)))
            {
                type = new TypeSpec(typeof(float));
            }
            else if (types.Contains(typeof(ulong)))
            {
                type = new TypeSpec(typeof(ulong));
            }
            else if (types.Contains(typeof(uint)))
            {
                type = new TypeSpec(typeof(uint));
            }
            else if (types.Contains(typeof(long)))
            {
                type = new TypeSpec(typeof(long));
            }
            else if (types.Contains(typeof(int)))
            {
                type = new TypeSpec(typeof(int));
            }

            var values = children.OfType<Value>();

            if (types.Contains(typeof(uint)) && values.Any(v => !uint.TryParse(v.Val, out var _)))
            {
                // uint --> long
                type = new TypeSpec(typeof(long));
            }

            if (types.Contains(typeof(ulong)) && values.Any(v => !ulong.TryParse(v.Val, out var _)))
            {
                // ulong --> long
                type = new TypeSpec(typeof(long));
            }

            return true;
        }

        if (children.Any() && children.All(c => c is Value))
        {
            var prop = context.CurrentProperty;
            var className = Utility.ToClassName(context.GetClassName(prop, out var _));

            if (!context.IsParsed(className))
            {
                var cls = new CodeTypeDeclaration(className)
                {
                    IsEnum = true,
                };

                foreach (var value in children.Cast<Value>())
                {
                    Code.ConvertForEnum(value.Val, out var field);
                    if (!cls.Members.OfType<CodeMemberField>().Any(f => f.Name == field.Name))
                    {
                        cls.Members.Add(field);
                    }
                }

                if (!context.IsParsed(cls.Name))
                {
                    context.Add(cls);
                }
            }

            type = new TypeSpec(new CodeTypeReference(className), true);
            return true;
        }

        return false;
    }
}
