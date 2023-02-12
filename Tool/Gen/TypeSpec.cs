namespace Gen;

internal class TypeSpec
{
    internal TypeSpec(Type type)
        : this(new CodeTypeReference(type), type.IsPrimitive)
    {
    }

    internal TypeSpec(CodeTypeReference type, bool isPrimitive)
    {
        this.Type = type;
        this.IsPrimitive = isPrimitive;
    }

    internal bool IsPrimitive { get; }

    internal CodeTypeReference Type { get; }
}
