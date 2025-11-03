namespace LibvirtModel.Test.Model;

[TestClass]
public class DomainSnapshotTest : TestBase
{
    [TestMethod]
    public void Domainsnapshot()
    {
        const string expected = $@"
{XMLDECL}
<domainsnapshot {XMLNS} />
";

        this.AssertXml<Domainsnapshot>(expected);
    }

    [TestMethod]
    public void DomainsnapshotActive()
    {
        var values = Enum.GetValues(typeof(DomainsnapshotActive));
        Assert.HasCount(2, values);
    }

    [TestMethod]
    public void DomainsnapshotDisks()
    {
        const string expected = $@"
{XMLDECL}
<DomainsnapshotDisks {XMLNS} />
";

        this.AssertXml<DomainsnapshotDisks>(expected);
    }

    [TestMethod]
    public void DomainsnapshotDisksnapshot()
    {
        const string expected = $@"
{XMLDECL}
<DomainsnapshotDisksnapshot {XMLNS} />
";

        this.AssertXml<DomainsnapshotDisksnapshot>(expected);
    }

    [TestMethod]
    public void DomainsnapshotDisksnapshotDriver()
    {
        const string expected = $@"
{XMLDECL}
<DomainsnapshotDisksnapshotDriver {XMLNS} />
";

        this.AssertXml<DomainsnapshotDisksnapshotDriver>(expected);
    }

    [TestMethod]
    public void DomainsnapshotDisksnapshotDriverMetadataCache()
    {
        const string expected = $@"
{XMLDECL}
<DomainsnapshotDisksnapshotDriverMetadataCache {XMLNS} />
";

        this.AssertXml<DomainsnapshotDisksnapshotDriverMetadataCache>(expected);
    }

    [TestMethod]
    public void DomainsnapshotDisksDisksnapshotDriverMetadataCacheMaxSize()
    {
        const string expected = $@"
{XMLDECL}
<DomainsnapshotDisksDisksnapshotDriverMetadataCacheMaxSize {XMLNS} />
";

        this.AssertXml<DomainsnapshotDisksDisksnapshotDriverMetadataCacheMaxSize>(expected);
    }

    [TestMethod]
    public void StorageFormatBacking()
    {
        var values = Enum.GetValues(typeof(StorageFormatBacking));
        Assert.HasCount(5, values);
    }

    [TestMethod]
    public void DomainsnapshotDisksnapshotSnapshot()
    {
        var values = Enum.GetValues(typeof(DomainsnapshotDisksnapshotSnapshot));
        Assert.HasCount(4, values);
    }

    [TestMethod]
    public void DomainsnapshotDisksnapshotSnapshotDeleteInProgress()
    {
        const string expected = $@"
{XMLDECL}
<DomainsnapshotDisksnapshotSnapshotDeleteInProgress {XMLNS} />
";

        this.AssertXml<DomainsnapshotDisksnapshotSnapshotDeleteInProgress>(expected);
    }

    [TestMethod]
    public void DomainsnapshotDisksnapshotSource()
    {
        const string expected = $@"
{XMLDECL}
<DomainsnapshotDisksnapshotSource {XMLNS} />
";

        this.AssertXml<DomainsnapshotDisksnapshotSource>(expected);
    }

    [TestMethod]
    public void DomainsnapshotDisksnapshotSourceIdentity()
    {
        const string expected = $@"
{XMLDECL}
<DomainsnapshotDisksnapshotSourceIdentity {XMLNS} />
";

        this.AssertXml<DomainsnapshotDisksnapshotSourceIdentity>(expected);
    }

    [TestMethod]
    public void DomainsnapshotDisksnapshotSourceProtocol()
    {
        var values = Enum.GetValues(typeof(DomainsnapshotDisksnapshotSourceProtocol));
        Assert.HasCount(13, values);
    }

    [TestMethod]
    public void DomainsnapshotDisksnapshotType()
    {
        var values = Enum.GetValues(typeof(DomainsnapshotDisksnapshotType));
        Assert.HasCount(3, values);
    }

    [TestMethod]
    public void DomainsnapshotDomain()
    {
        const string expected = $@"
{XMLDECL}
<DomainsnapshotDomain {XMLNS} />
";

        this.AssertXml<DomainsnapshotDomain>(expected);
    }

    [TestMethod]
    public void DomainsnapshotMemory()
    {
        const string expected = $@"
{XMLDECL}
<DomainsnapshotMemory {XMLNS} />
";

        this.AssertXml<DomainsnapshotMemory>(expected);
    }

    [TestMethod]
    public void DomainsnapshotMemorySnapshot()
    {
        var values = Enum.GetValues(typeof(DomainsnapshotMemorySnapshot));
        Assert.HasCount(3, values);
    }

    [TestMethod]
    public void DomainsnapshotDomainOs()
    {
        const string expected = $@"
{XMLDECL}
<DomainsnapshotDomainOs {XMLNS} />
";

        this.AssertXml<DomainsnapshotDomainOs>(expected);
    }

    [TestMethod]
    public void DomainsnapshotDomainOsType()
    {
        const string expected = $@"
{XMLDECL}
<DomainsnapshotDomainOsType {XMLNS} />
";

        this.AssertXml<DomainsnapshotDomainOsType>(expected);
    }

    [TestMethod]
    public void DomainsnapshotParent()
    {
        const string expected = $@"
{XMLDECL}
<DomainsnapshotParent {XMLNS} />
";

        this.AssertXml<DomainsnapshotParent>(expected);
    }

    [TestMethod]
    public void State()
    {
        var values = Enum.GetValues(typeof(State));
        Assert.HasCount(7, values);
    }
}
