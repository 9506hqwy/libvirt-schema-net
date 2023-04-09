namespace Gen;

using RelaxNg.Schema;

internal class AstTypeDeclaration : AstTypeDeclarationBase
{
    private readonly IHasName node;

    internal AstTypeDeclaration(
        IHasName node,
        AstTypeMember[] members,
        AstTypeFragment[] values,
        bool isEmpty,
        bool isRawXml,
        INode[] statck)
        : base(members, values, isEmpty, isRawXml)
    {
        this.node = node;
        this.Stack = statck;
    }

    internal override string ElementName => this.Stack.OfType<IHasName>().Last().Name.GetName();

    internal override int Depth => this.Stack.Count(n => n is Attribute || n is Element);

    internal INode[] Stack { get; }

    internal RngPosition Position => this.node.Position;

    internal override string? FindNamespace()
    {
        var node = this.Stack.OfType<IHasName>().Last();
        return node switch
        {
            Element e => e.Namespace,
            _ => null,
        };
    }
}
