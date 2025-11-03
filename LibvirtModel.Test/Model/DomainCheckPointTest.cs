namespace LibvirtModel.Test.Model;

[TestClass]
public class DomainCheckPointTest : TestBase
{
    [TestMethod]
    public void Domaincheckpoint()
    {
        const string expected = $@"
{XMLDECL}
<domaincheckpoint {XMLNS} />
";

        this.AssertXml<Domaincheckpoint>(expected);
    }

    [TestMethod]
    public void DomaincheckpointDisks()
    {
        const string expected = $@"
{XMLDECL}
<DomaincheckpointDisks {XMLNS} />
";

        this.AssertXml<DomaincheckpointDisks>(expected);
    }

    [TestMethod]
    public void DomaincheckpointDiskcheckpoint()
    {
        const string expected = $@"
{XMLDECL}
<DomaincheckpointDiskcheckpoint {XMLNS} />
";

        this.AssertXml<DomaincheckpointDiskcheckpoint>(expected);
    }

    [TestMethod]
    public void DomaincheckpointDiskcheckpointCheckpoint()
    {
        var values = Enum.GetValues(typeof(DomaincheckpointDiskcheckpointCheckpoint));
        Assert.HasCount(2, values);
    }

    [TestMethod]
    public void DomaincheckpointParent()
    {
        const string expected = $@"
{XMLDECL}
<DomaincheckpointParent {XMLNS} />
";

        this.AssertXml<DomaincheckpointParent>(expected);
    }
}
