namespace Gen;

using RelaxNg.Schema;

internal class PropertyState : ICloneable
{
    internal bool Unordered { get; set; }

    internal bool IsArray { get; set; }

    internal bool Optional { get; set; }

    public object Clone()
    {
        return new PropertyState
        {
            Unordered = this.Unordered,
            IsArray = this.IsArray,
            Optional = this.Optional,
        };
    }

    internal bool NeedSpecifiedFlag(TypeSpec typeSpec)
    {
        return typeSpec.IsPrimitive && this.Optional && !this.IsArray;
    }

    internal void Set(IHasChildren property)
    {
        if (property is Interleave)
        {
            this.Unordered = true;
        }

        if (property is ZeroOrMore || property is OneOrMore)
        {
            this.IsArray = true;
        }

        if (property is Optional)
        {
            this.Optional = true;
        }
    }

    internal CodeTypeReference ToType(TypeSpec typeSpec)
    {
        return this.IsArray ? Code.ToArray(typeSpec.Type) : typeSpec.Type;
    }
}
