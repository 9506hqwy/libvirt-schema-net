namespace Gen;

internal class GenTypeMember
{
    private readonly bool isAttribute;

    private readonly bool isElement;

    private readonly bool isEnum;

    private readonly bool isExtension;

    private readonly string? ns;

    private readonly PropertyState? status;

    private readonly TypeSpec? type;

    internal GenTypeMember()
        : this(null, "value", "value", null, false, false, false, true, null)
    {
    }

    internal GenTypeMember(CodeContext context, string name)
        : this(null, name, context.GetPropertyName(name, false), null, false, false, true, false, null)
    {
    }

    internal GenTypeMember(CodeContext context, TypeSpec type, string name, PropertyState status)
        : this(type, name, context.GetPropertyName(name, false), null, true, false, false, false, status)
    {
    }

    internal GenTypeMember(CodeContext context, TypeSpec type, string name, string? ns, PropertyState status)
        : this(type, name, context.GetPropertyName(name, true), ns, false, true, false, false, status)
    {
    }

    private GenTypeMember(
        TypeSpec? type,
        string name,
        string propertyName,
        string? ns,
        bool isAttribute,
        bool isElement,
        bool isEnum,
        bool isExtension,
        PropertyState? status)
    {
        this.type = type;
        this.Name = name;
        this.PropertyName = propertyName;
        this.ns = ns;
        this.isAttribute = isAttribute;
        this.isElement = isElement;
        this.isEnum = isEnum;
        this.isExtension = isExtension;
        this.status = status;
    }

    internal string Name { get; }

    internal string PropertyName { get; }

    internal CodeTypeReference Type => this.GetMemberType();

    internal static bool SameKind(GenTypeMember a, GenTypeMember b)
    {
        return
            a.isAttribute == b.isAttribute &&
            a.isElement == b.isElement &&
            a.isEnum == b.isEnum &&
            a.isExtension == b.isExtension;
    }

    internal IEnumerable<CodeTypeMember> Gen()
    {
        if (this.isAttribute)
        {
            Code.ConvertForAttribute(
                this.type!.Type,
                this.PropertyName,
                this.Name,
                out var field,
                out var prop);

            yield return field;
            yield return prop;

            if (this.status!.NeedSpecifiedFlag(this.type))
            {
                Code.ConvertForSpecified(this.PropertyName, out field, out prop);

                yield return field;
                yield return prop;
            }
        }
        else if (this.isElement)
        {
            Code.ConvertForElement(
                this.status!.ToType(this.type!),
                this.PropertyName,
                this.Name,
                this.ns,
                out var field,
                out var prop);

            yield return field;
            yield return prop;

            if (this.status.NeedSpecifiedFlag(this.type!))
            {
                Code.ConvertForSpecified(this.PropertyName, out field, out prop);

                yield return field;
                yield return prop;
            }
        }
        else if (this.isEnum)
        {
            Code.ConvertForEnum(this.Name, out var field);
            yield return field;
        }
        else if (this.isExtension)
        {
            Code.ConvertForExtension(out var field, out var prop);

            yield return field;
            yield return prop;
        }
        else
        {
            throw new InvalidProgramException();
        }
    }

    internal GenTypeDeclaration GetMemberType(CodeContext context)
    {
        var type = context
            .EnumerateTypes()
            .FirstOrDefault(t => t.Name == this.Type.BaseType);
        if (type is not null)
        {
            return type;
        }

        // for C# type.
        return new GenTypeDeclaration(this.type!.Type.BaseType, null, null, false, false);
    }

    internal void SetOptional()
    {
        if (this.status is not null)
        {
            this.status.Optional = true;
        }
    }

    internal GenTypeMember ToStringType()
    {
        var spec = new TypeSpec(typeof(string));
        return new GenTypeMember(
            spec,
            this.Name,
            this.PropertyName,
            this.ns,
            this.isAttribute,
            this.isElement,
            false,
            false,
            this.status);
    }

    private CodeTypeReference GetMemberType()
    {
        if (this.isAttribute)
        {
            return this.type!.Type;
        }
        else if (this.isElement)
        {
            return this.status!.ToType(this.type!);
        }
        else if (this.isEnum)
        {
            return new CodeTypeReference(typeof(string));
        }
        else if (this.isExtension)
        {
            return new CodeTypeReference(typeof(string));
        }
        else
        {
            throw new InvalidProgramException();
        }
    }
}
