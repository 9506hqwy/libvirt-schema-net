namespace Gen;

using RelaxNg.Schema;

internal class AstTypeFragment
{
    private readonly INode[] attributes;

    internal AstTypeFragment(INode node, INode[] attribute, INode[] stack)
    {
        this.Node = node;
        this.attributes = attribute;
        this.Stack = stack;
    }

    internal bool IsArray => this.attributes.Any(n => n is ZeroOrMore || n is OneOrMore);

    internal INode Node { get; }

    internal bool Optional => this.IsOptional();

    internal INode[] Stack { get; }

    internal AstTypeDeclaration? Type { get; set; }

    internal bool Unordered => this.attributes.Any(n => n is Interleave);

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
