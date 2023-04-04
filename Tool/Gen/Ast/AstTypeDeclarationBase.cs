namespace Gen;

internal abstract class AstTypeDeclarationBase
{
    internal AstTypeDeclarationBase(
        AstTypeMember[] members,
        AstTypeFragment[] values,
        bool isEmpty)
    {
        this.Members = members;
        this.Values = values;
        this.IsEmpty = isEmpty;
    }

    internal abstract int Depth { get; }

    internal abstract string ElementName { get; }

    internal bool FundamentalType => this.ValueType?.Type is not null;

    internal bool IsEmpty { get; }

    internal AstTypeMember[] Members { get; }

    internal bool StartReachable { get; set; }

    internal AstTypeFragment[] Values { get; }

    internal AstTypeReference? ValueType { get; set; }

    internal bool WithExtension => this.Members.Length != 0 && this.Values.Length != 0;

    internal abstract string? FindNamespace();
}
