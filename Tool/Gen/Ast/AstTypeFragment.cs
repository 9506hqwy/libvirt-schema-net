namespace Gen;

using RelaxNg.Schema;

internal class AstTypeFragment
{
    private bool isArray;

    private bool isOptional;

    internal AstTypeFragment(INode node, INode[] attribute, INode[] stack, int branchCount, Guid branchId)
    {
        this.Node = node;
        this.Attributes = attribute;
        this.Stack = stack;
        this.BranchCount = branchCount;
        this.BranchId = branchId;
    }

    internal INode[] Attributes { get; }

    internal int BranchCount { get; private set; }

    internal Guid BranchId { get; }

    internal bool IsArray => this.isArray || this.Attributes.Any(n => n is ZeroOrMore || n is OneOrMore);

    internal INode Node { get; }

    internal bool Optional => this.isOptional || this.IsOptional();

    internal INode[] Stack { get; }

    internal AstTypeDeclaration? Type { get; set; }

    internal bool Unordered => this.Attributes.Any(n => n is Interleave);

    internal AstTypeFragment Copy()
    {
        var frag = new AstTypeFragment(this.Node, this.Attributes, this.Stack, this.BranchCount, this.BranchId);
        frag.isArray = this.isArray;
        frag.isOptional = this.isOptional;
        frag.Type = this.Type;
        return frag;
    }

    internal void SetBranchCount(int branchCount)
    {
        this.BranchCount = branchCount;
    }

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
        var attrs = this.Attributes.AsEnumerable();

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

        return this.Attributes.Any(n => n is Choice || n is Optional);
    }
}
