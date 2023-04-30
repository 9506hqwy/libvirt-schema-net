namespace LibvirtModel.Test.Model;

[TestClass]
public class InactiveDomainTest : TestBase
{
    [TestMethod]
    public void InactiveDomain()
    {
        const string expected = $@"
{XMLDECL}
<inactiveDomain {XMLNS} type=""bhyve"" />
";

        this.AssertXml<InactiveDomain>(expected);
    }

    [TestMethod]
    public void InactiveDomainOs()
    {
        const string expected = $@"
{XMLDECL}
<InactiveDomainOs {XMLNS} />
";

        this.AssertXml<InactiveDomainOs>(expected);
    }

    [TestMethod]
    public void InactiveDomainOsType()
    {
        const string expected = $@"
{XMLDECL}
<InactiveDomainOsType {XMLNS} />
";

        this.AssertXml<InactiveDomainOsType>(expected);
    }
}
