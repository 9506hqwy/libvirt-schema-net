namespace LibvirtModel.Test.Model;

[TestClass]
public class StorageVolTest : TestBase
{
    [TestMethod]
    public void Vol()
    {
        const string expected = $@"
{XMLDECL}
<volume {XMLNS} />
";

        this.AssertXml<Vol>(expected);
    }

    [TestMethod]
    public void VolAllocation()
    {
        const string expected = $@"
{XMLDECL}
<VolAllocation {XMLNS} />
";

        this.AssertXml<VolAllocation>(expected);
    }

    [TestMethod]
    public void VolBackingStore()
    {
        const string expected = $@"
{XMLDECL}
<backingStore {XMLNS} />
";

        this.AssertXml<VolBackingStore>(expected);
    }

    [TestMethod]
    public void VolCapacity()
    {
        const string expected = $@"
{XMLDECL}
<VolCapacity {XMLNS} />
";

        this.AssertXml<VolCapacity>(expected);
    }

    [TestMethod]
    public void VolPhysical()
    {
        const string expected = $@"
{XMLDECL}
<VolPhysical {XMLNS} />
";

        this.AssertXml<VolPhysical>(expected);
    }

    [TestMethod]
    public void VolSource()
    {
        const string expected = $@"
{XMLDECL}
<source {XMLNS} />
";

        this.AssertXml<VolSource>(expected);
    }

    [TestMethod]
    public void VolSourcedev()
    {
        const string expected = $@"
{XMLDECL}
<device {XMLNS} />
";

        this.AssertXml<VolSourcedev>(expected);
    }

    [TestMethod]
    public void VolSourcedevExtent()
    {
        const string expected = $@"
{XMLDECL}
<VolSourcedevExtent {XMLNS} start=""0"" end=""0"" />
";

        this.AssertXml<VolSourcedevExtent>(expected);
    }

    [TestMethod]
    public void VolTarget()
    {
        const string expected = $@"
{XMLDECL}
<target {XMLNS} />
";

        this.AssertXml<VolTarget>(expected);
    }

    [TestMethod]
    public void VolTargetFormat()
    {
        const string expected = $@"
{XMLDECL}
<VolTargetFormat {XMLNS} type=""auto"" />
";

        this.AssertXml<VolTargetFormat>(expected);
    }

    [TestMethod]
    public void VolTargetFormatType()
    {
        var values = Enum.GetValues(typeof(VolTargetFormatType));
        Assert.HasCount(40, values);
    }

    [TestMethod]
    public void VolTargetNocow()
    {
        const string expected = $@"
{XMLDECL}
<VolTargetNocow {XMLNS} />
";

        this.AssertXml<VolTargetNocow>(expected);
    }

    [TestMethod]
    public void VolTargetTimestamps()
    {
        const string expected = $@"
{XMLDECL}
<VolTargetTimestamps {XMLNS} />
";

        this.AssertXml<VolTargetTimestamps>(expected);
    }

    [TestMethod]
    public void VolType()
    {
        var values = Enum.GetValues(typeof(VolType));
        Assert.HasCount(5, values);
    }
}
