namespace Gen;

using RelaxNg.Schema;

internal class AstTypeReference
{
    private readonly Type? type;

    internal AstTypeReference(AstTypeDeclarationBase decl, bool optional, bool isArray)
    {
        this.Declaration = decl;
        this.Optional = optional;
        this.IsArray = isArray;
    }

    internal AstTypeReference(Value[] values, bool optional, bool isArray, AstTypeDeclarationBase parent)
    {
        this.Values = values;
        this.Optional = optional;
        this.IsArray = isArray;
        this.Parent = parent;
    }

    internal AstTypeReference(Type type, bool optional, bool isArray)
    {
        this.type = type;
        this.Optional = optional;
        this.IsArray = isArray;
    }

    internal AstTypeDeclarationBase? Declaration { get; }

    internal bool IsArray { get; }

    internal bool IsDatetime => this.IsDatetimeType();

    internal bool IsEnum => this.IsEnumType();

    internal bool IsPrimitive => this.IsPrimitiveType();

    internal bool IsString => this.IsStringType();

    internal bool Optional { get; }

    internal AstTypeDeclarationBase? Parent { get; }

    internal Type? Type => this.GetFundamentalType();

    internal Value[]? Values { get; }

    private Type? GetFundamentalType()
    {
        return
            this.type ??
            (this.IsExtensionType() ? null : this.Declaration?.ValueType?.Type);
    }

    private bool IsDatetimeType()
    {
        return
            (!this.IsExtensionType() && (this.Declaration?.ValueType?.IsDatetime ?? false)) ||
            (this.type == typeof(DateTime));
    }

    private bool IsEnumType()
    {
        return
            (!this.IsExtensionType() && (this.Declaration?.ValueType?.IsEnum ?? false)) ||
            (this.Values is not null);
    }

    private bool IsExtensionType()
    {
        return this.Declaration?.WithExtension ?? false;
    }

    private bool IsPrimitiveType()
    {
        return
            (!this.IsExtensionType() && (this.Declaration?.ValueType?.IsPrimitive ?? false)) ||
            (this.type?.IsPrimitive ?? false);
    }

    private bool IsStringType()
    {
        return
            (!this.IsExtensionType() && (this.Declaration?.ValueType?.IsString ?? false)) ||
            (this.type == typeof(string));
    }
}
