namespace Gen;

internal class ParsedChildNode
{
    internal ParsedChildNode(ParsedNode value, int branchCount, Guid branchId)
    {
        this.Value = value;
        this.BranchCount = branchCount;
        this.BranchId = branchId;
    }

    internal int BranchCount { get; }

    internal Guid BranchId { get; }

    internal ParsedNode Value { get; }

    internal ParsedChildNode Copy()
    {
        return new ParsedChildNode(this.Value.Copy(), this.BranchCount, this.BranchId);
    }
}
