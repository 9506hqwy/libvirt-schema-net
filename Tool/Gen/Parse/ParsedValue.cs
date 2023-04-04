namespace Gen;

using RelaxNg.Schema;

internal class ParsedValue
{
    internal ParsedValue(IPattern node, ParsedStack stack)
    {
        this.Node = node;
        this.Stack = stack;
    }

    internal IPattern Node { get; }

    internal ParsedStack Stack { get; }

    internal ParsedValue Copy()
    {
        return new ParsedValue(this.Node, this.Stack.Copy());
    }

    internal void Restack(ParsedStack stack)
    {
        this.Stack.Restack(stack);
    }
}
