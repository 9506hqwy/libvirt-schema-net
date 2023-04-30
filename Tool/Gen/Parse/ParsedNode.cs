namespace Gen;

using RelaxNg.Schema;

internal class ParsedNode
{
    private readonly List<ParsedChildNode> childList;

    private readonly List<ParsedValue> valueList;

    internal ParsedNode(IHasName node)
    {
        this.childList = new List<ParsedChildNode>();
        this.valueList = new List<ParsedValue>();

        this.Node = node;
    }

    internal bool ChildParsed { get; set; }

    internal ParsedChildNode[] Children => this.childList.ToArray();

    internal bool HasNotAllowed => this.valueList.Any(v => v.IsNotAllowed);

    internal bool HasRawXml => this.childList.Select(c => c.Value).Any(c => c.IsRawXml);

    internal bool IsAttribute => this.Node is Attribute;

    internal bool IsEmpty { get; private set; }

    internal bool IsRawXml => this.Node.Name.IsAnyName();

    internal string Name => this.Node.Name.GetName();

    internal IHasName Node { get; }

    internal ParsedStack? Stack { get; set; }

    internal ParsedValue[] Values => this.valueList.Where(v => !v.IsNotAllowed).ToArray();

    internal void AddChild(ParsedNode child, int branchCount, Guid branchId)
    {
        this.childList.Add(new ParsedChildNode(child, branchCount, branchId));
    }

    internal void AddValue(IPattern value, ParsedStack stack, int branchCount, Guid branchId)
    {
        this.valueList.Add(new ParsedValue(value, stack, branchCount, branchId));
    }

    internal ParsedNode Copy()
    {
        var node = new ParsedNode(this.Node);
        this.childList.ForEach(c => node.childList.Add(c.Copy()));
        node.ChildParsed = this.ChildParsed;
        node.IsEmpty = this.IsEmpty;
        node.Stack = this.Stack?.Copy();
        this.valueList.ForEach(v => node.valueList.Add(v.Copy()));
        return node;
    }

    internal void Restack(ParsedStack stack)
    {
        this.Stack?.Restack(stack);

        foreach (var child in this.childList)
        {
            child.Value.Restack(stack);
        }

        foreach (var value in this.valueList)
        {
            value.Restack(stack);
        }
    }

    internal void SetEmpty()
    {
        this.IsEmpty = true;
    }
}
