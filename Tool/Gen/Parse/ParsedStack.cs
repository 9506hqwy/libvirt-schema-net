namespace Gen;

using RelaxNg.Schema;

internal class ParsedStack
{
    private readonly List<INode> inner;

    internal ParsedStack()
    {
        this.inner = [];
    }

    internal INode[] Inner => [.. this.inner];

    internal RngPosition Position => this.inner.First().Position;

    public ParsedStack Copy()
    {
        var stack = new ParsedStack();
        this.inner.ForEach(stack.Add);
        return stack;
    }

    internal void Add(INode node)
    {
        this.inner.Add(node);
    }

    internal int Count<T>()
        where T : INode
    {
        return this.inner.Count(s => s is T);
    }

    internal INode[] GetFrom(INode node)
    {
        return this.inner
            .Reverse<INode>()
            .TakeWhile(n => !n.Position.Equals(node.Position))
            .Reverse()
            .ToArray();
    }

    internal bool HasNode(INode node)
    {
        return this.inner.Any(n => n.Position.Equals(node.Position));
    }

    internal void Restack(ParsedStack stack)
    {
        stack = stack.Copy();
        var cur = stack.inner.Last();
        var curIndex = this.inner.FindIndex(n => n.Position.Equals(cur.Position));
        if (curIndex < 0)
        {
            throw new InvalidProgramException($"Unexpected stack at `{cur.Position}`.");
        }

        foreach (var descendant in this.inner.Skip(curIndex + 1))
        {
            stack.Add(descendant);
        }

        this.inner.Clear();
        stack.inner.ForEach(this.inner.Add);
    }
}
