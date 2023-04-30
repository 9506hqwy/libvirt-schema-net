namespace Gen;

using RelaxNg.Schema;

internal class ParsedNode
{
    private readonly List<ParsedNode> childList;

    private readonly List<ParsedValue> valueList;

    internal ParsedNode(IHasName node)
    {
        this.childList = new List<ParsedNode>();
        this.valueList = new List<ParsedValue>();

        this.Node = node;
    }

    internal int BranchCount { get; set; }

    internal Guid BranchId { get; set; }

    internal bool ChildParsed { get; set; }

    internal ParsedNode[] Children => this.childList.ToArray();

    internal bool HasNotAllowed => this.valueList.Any(v => v.IsNotAllowed);

    internal bool HasRawXml => this.childList.Any(c => c.IsRawXml);

    internal bool IsAttribute => this.Node is Attribute;

    internal bool IsEmpty { get; private set; }

    internal bool IsRawXml => this.Node.Name.IsAnyName();

    internal string Name => this.Node.Name.GetName();

    internal IHasName Node { get; }

    internal ParsedStack? Stack { get; set; }

    internal ParsedValue[] Values => this.valueList.Where(v => !v.IsNotAllowed).ToArray();

    internal void AddChild(ParsedNode child)
    {
        this.childList.Add(child);
    }

    internal void AddValue(IPattern value, ParsedStack stack, int branchCount, Guid branchId)
    {
        this.valueList.Add(new ParsedValue(value, stack, branchCount, branchId));
    }

    internal ParsedNode Copy()
    {
        var node = new ParsedNode(this.Node);
        node.BranchCount = this.BranchCount;
        node.BranchId = this.BranchId;
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
            child.Restack(stack);
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
