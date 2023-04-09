namespace Gen;

internal class AstMergedTypeDeclaration : AstTypeDeclarationBase
{
    internal AstMergedTypeDeclaration(
        string typeName,
        AstTypeMember[] members,
        AstTypeFragment[] values,
        bool isEmpty,
        AstTypeDeclarationBase parent)
        : base(members, values, isEmpty, false)
    {
        this.ElementName = typeName;
        this.Parent = parent;
    }

    internal override int Depth => 1;

    internal override string ElementName { get; }

    internal AstTypeDeclarationBase Parent { get; }

    internal override string? FindNamespace() => this.Parent.FindNamespace();
}
