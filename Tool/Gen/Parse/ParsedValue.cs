namespace Gen;

using RelaxNg.Schema;

internal class ParsedValue
{
    internal ParsedValue(IPattern node, ParsedStack stack, int branchCount)
    {
        this.Node = node;
        this.Stack = stack;
        this.BranchCount = branchCount;
    }

    internal int BranchCount { get; }

    internal IPattern Node { get; }

    internal ParsedStack Stack { get; }

    internal ParsedValue Copy()
    {
        return new ParsedValue(this.Node, this.Stack.Copy(), this.BranchCount);
    }

    internal void Restack(ParsedStack stack)
    {
        this.Stack.Restack(stack);
    }
}
