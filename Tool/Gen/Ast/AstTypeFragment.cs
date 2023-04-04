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

    internal bool Optional => this.attributes.Any(n => n is Optional);

    internal INode[] Stack { get; }

    internal AstTypeDeclaration? Type { get; set; }

    internal bool Unordered => this.attributes.Any(n => n is Interleave);
}
