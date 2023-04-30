namespace Gen;

using RelaxNg.Schema;

internal class AstTypeFragment
{
    private readonly INode[] attributes;

    private bool isArray;

    private bool isOptional;

    internal AstTypeFragment(INode node, INode[] attribute, INode[] stack, int branchCount, Guid branchId)
    {
        this.Node = node;
        this.attributes = attribute;
        this.Stack = stack;
        this.BranchCount = branchCount;
        this.BranchId = branchId;
    }

    internal int BranchCount { get; }

    internal Guid BranchId { get; }

    internal bool IsArray => this.isArray || this.attributes.Any(n => n is ZeroOrMore || n is OneOrMore);

    internal INode Node { get; }

    internal bool Optional => this.isOptional || this.IsOptional();

    internal INode[] Stack { get; }

    internal AstTypeDeclaration? Type { get; set; }

    internal bool Unordered => this.attributes.Any(n => n is Interleave);

    internal void SetIsArray(bool isArray)
    {
        this.isArray = isArray;
    }

    internal void SetOptional(bool isOptional)
    {
        this.isOptional = isOptional;
    }

    private bool IsOptional()
    {
        var attrs = this.attributes.AsEnumerable();

        switch (this.Node)
        {
            case Value _:
                if (attrs.SkipLast(1).LastOrDefault() is Choice)
                {
                    attrs = attrs.SkipLast(2);
                }

                break;
            default:
                break;
        }

        return this.attributes.Any(n => n is Choice || n is Optional);
    }
}
