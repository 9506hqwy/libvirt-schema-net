namespace Gen;

using RelaxNg.Schema;

internal class Generator
{
    private readonly Dictionary<RngPosition, CodeTypeDeclaration> enumCache;

    private readonly string[] exceptTypeAttr;

    private readonly AstTypeDeclarationBase[] types;

    private readonly Dictionary<object, CodeTypeDeclaration> generated;

    internal Generator(AstTypeDeclarationBase[] types, string[] exceptTypeAttr)
    {
        this.types = types;
        this.exceptTypeAttr = exceptTypeAttr;
        this.enumCache = new Dictionary<RngPosition, CodeTypeDeclaration>();
        this.generated = new Dictionary<object, CodeTypeDeclaration>();
    }

    internal CodeTypeDeclaration[] Types => this.generated.Values.Distinct().OrderBy(t => t.Name).ToArray();

    internal void Compile()
    {
        foreach (var type in this.types.Where(t => t.Depth == 1))
        {
            this.Compile(type, false);
        }

        foreach (var type in this.types.Where(t => t.Depth != 1))
        {
            this.Compile(type, false);
        }
    }

    private void AddMember(AstTypeMember member, CodeTypeDeclaration type, bool withSuffixAttr)
    {
        var nsUri = member.FindNamespace() is null ? null : new Uri(member.FindNamespace()!);
        var ns = nsUri?.AbsolutePath.Split('/').SkipLast(1).Last();

        var memberType =
            member.Type!.Type is not null ?
            new CodeTypeReference(member.Type!.Type) :
            member.Type!.Declaration is not null ?
            new CodeTypeReference(this.generated[member.Type!.Declaration].Name) :
            new CodeTypeReference(this.generated[member.Type!].Name);

        if (member.Type.IsArray)
        {
            memberType = Code.ToArray(memberType);
        }

        var propName = member.Name;

        if (ns is not null)
        {
            propName = $"{ns}_{propName}";
        }

        if (member.IsAttribute)
        {
            if (withSuffixAttr)
            {
                propName = $"{propName}_attr";
            }

            Code.ConvertForAttribute(
                memberType,
                propName,
                member.Name,
                out var field,
                out var prop);

            type.Members.Add(field);
            type.Members.Add(prop);

            if ((member.Type.IsEnum || member.Type.IsPrimitive) &&
                member.Type.Optional &&
                !member.Type.IsArray)
            {
                Code.ConvertForSpecified(propName, out field, out prop);

                type.Members.Add(field);
                type.Members.Add(prop);
            }
        }
        else
        {
            Code.ConvertForElement(
                memberType,
                propName,
                member.Name,
                member.FindNamespace(),
                out var field,
                out var prop);

            type.Members.Add(field);
            type.Members.Add(prop);

            if ((member.Type.IsEnum || member.Type.IsPrimitive) &&
                member.Type.Optional &&
                !member.Type.IsArray)
            {
                Code.ConvertForSpecified(propName, out field, out prop);

                type.Members.Add(field);
                type.Members.Add(prop);
            }
        }
    }

    private void Compile(AstTypeDeclarationBase type, bool withSuffixAttr)
    {
        if (this.generated.ContainsKey(type))
        {
            return;
        }

        foreach (var member in type.Members)
        {
            var count = type.Members.Count(n => n.Name == member.Name);
            this.Compile(member, count > 1 && member.IsAttribute);
        }

        this.ConvertToClalss(type, withSuffixAttr, out var cls);
        this.generated.Add(type, cls);
    }

    private void Compile(AstTypeMember member, bool withSuffixAttr)
    {
        if (member.Type!.IsDatetime ||
            member.Type!.IsPrimitive ||
            member.Type!.IsString)
        {
            return;
        }

        this.Compile(member.Name, member.Type!, withSuffixAttr);
    }

    private void Compile(string name, AstTypeReference reference, bool withSuffixAttr)
    {
        if (this.generated.ContainsKey(reference))
        {
            return;
        }

        if (reference.Declaration is not null)
        {
            this.Compile(reference.Declaration, withSuffixAttr);
            return;
        }

        if (reference.Type is not null)
        {
            return;
        }

        if (reference.Values is not null)
        {
            this.ConvertToEnum(name, reference, withSuffixAttr, out var cls);
            this.generated.Add(reference, cls);
            return;
        }

        throw new InvalidProgramException();
    }

    private void ConvertToClalss(AstTypeDeclarationBase type, bool withSuffixAttr, out CodeTypeDeclaration cls)
    {
        var nsUri = type.FindNamespace() is null ? null : new Uri(type.FindNamespace()!);
        var ns = nsUri?.AbsolutePath.Split('/').SkipLast(1).Last();

        var className = this.GetClassName(type);

        if (ns is not null)
        {
            className = $"{ns}_{className}";
        }

        if (withSuffixAttr)
        {
            className = $"{className}_attr";
        }

        if (type.Members.Length == 0 && (type.ValueType?.IsEnum ?? false))
        {
            var define = this.GetEnumDefine(type.Values);
            if (define is not null)
            {
                if (this.enumCache.ContainsKey(define.Position))
                {
                    cls = this.enumCache[define.Position];
                    return;
                }

                className = define.Name;
            }

            cls = new CodeTypeDeclaration(Utility.ToClassName(className))
            {
                IsEnum = true,
            };

            foreach (var value in type.ValueType.Values!.GroupBy(v => v.Val).OrderBy(v => v.Key))
            {
                Code.ConvertForEnum(value.Key, out var field);
                cls.Members.Add(field);
            }

            if (define is not null)
            {
                this.enumCache.Add(define.Position, cls);
            }
        }
        else
        {
            var xmlModifier = !exceptTypeAttr.Contains(className) && this.WithXmlModifier(type);
            Code.ConvertForType(className, type.ElementName, type.FindNamespace(), xmlModifier, out cls);

            foreach (var member in type.Members)
            {
                var count = type.Members.Count(n => n.Name == member.Name);
                this.AddMember(member, cls, count > 1 && member.IsAttribute);
            }

            if (type.ValueType is not null)
            {
                Code.ConvertForExtension(out var field, out var prop);
                cls.Members.Add(field);
                cls.Members.Add(prop);
            }
        }
    }

    private void ConvertToEnum(string name, AstTypeReference reference, bool withSuffixAttr, out CodeTypeDeclaration cls)
    {
        string parentName = this.GetClassName(reference.Parent!);
        var enumName = $"{parentName}_{name}";

        if (withSuffixAttr)
        {
            enumName = $"{enumName}_attr";
        }

        cls = new CodeTypeDeclaration(Utility.ToClassName(enumName))
        {
            IsEnum = true,
        };

        foreach (var value in reference.Values!.GroupBy(v => v.Val).OrderBy(v => v.Key))
        {
            Code.ConvertForEnum(value.Key, out var field);
            cls.Members.Add(field);
        }
    }

    private string GetClassName(AstTypeDeclarationBase type)
    {
        return type switch
        {
            AstTypeDeclaration d => this.GetClassName(d),
            AstMergedTypeDeclaration d => this.GetClassName(d),
            _ => throw new InvalidProgramException(),
        };
    }

    private string GetClassName(AstTypeDeclaration type)
    {
        var names = new List<string>();

        Define? define = null;
        foreach (var node in type.Stack)
        {
            switch (node)
            {
                case Define tmp:
                    define = tmp;
                    break;

                case IHasName hasName:
                    if (define is not null && define.Children.Length == 1)
                    {
                        names.Add(define.Name);
                    }
                    else
                    {
                        names.Add(hasName.Name.GetName());
                    }

                    define = null;

                    break;

                default:
                    define = null;
                    break;
            }
        }

        return string.Join("_", names);
    }

    private string GetClassName(AstMergedTypeDeclaration type)
    {
        var parentName = this.GetClassName(type.Parent);
        return $"{parentName}_{type.ElementName}";
    }

    private Define? GetEnumDefine(AstTypeFragment[] values)
    {
        var nodes = values.Select(v => v.Stack.SkipLast(2).LastOrDefault());
        if (nodes.Any(d => d is not Define))
        {
            return null;
        }

        var defines = nodes.OfType<Define>().ToArray();
        if (defines.Any(d => !d.Position.Equals(defines[0].Position)))
        {
            return null;
        }

        return defines[0];
    }

    private bool WithXmlModifier(AstTypeDeclarationBase type)
    {
        return type switch
        {
            AstTypeDeclaration t => this.WithXmlModifier(t),
            _ => false,
        };
    }

    private bool WithXmlModifier(AstTypeDeclaration type)
    {
        var node = type.Stack.SkipLast(1).LastOrDefault();
        return node is Define && type.Stack.Count(n => n is IHasName) < 4;
    }
}
