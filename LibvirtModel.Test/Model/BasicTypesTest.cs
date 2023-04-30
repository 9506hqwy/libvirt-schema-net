namespace LibvirtModel.Test.Model;

[TestClass]
public class BasicTypesTest : TestBase
{
    [TestMethod]
    public void Archnames()
    {
        var values = Enum.GetValues(typeof(Archnames));
        Assert.AreEqual(34, values.Length);
    }

    [TestMethod]
    public void Link()
    {
        const string expected = $@"
{XMLDECL}
<Link {XMLNS} />
";

        this.AssertXml<Link>(expected);
    }

    [TestMethod]
    public void Metadata()
    {
        const string expected = $@"
{XMLDECL}
<metadata {XMLNS} />
";

        this.AssertXml<Metadata>(expected);
    }

    [TestMethod]
    public void LinkState()
    {
        var values = Enum.GetValues(typeof(LinkState));
        Assert.AreEqual(7, values.Length);
    }

    [TestMethod]
    public void Sourceinfoadapter()
    {
        const string expected = $@"
{XMLDECL}
<adapter {XMLNS} />
";

        this.AssertXml<Sourceinfoadapter>(expected);
    }

    [TestMethod]
    public void SourceinfoadapterParentaddr()
    {
        const string expected = $@"
{XMLDECL}
<SourceinfoadapterParentaddr {XMLNS} />
";

        this.AssertXml<SourceinfoadapterParentaddr>(expected);
    }

    [TestMethod]
    public void SourceinfoadapterParentaddrAddress()
    {
        const string expected = $@"
{XMLDECL}
<SourceinfoadapterParentaddrAddress {XMLNS} />
";

        this.AssertXml<SourceinfoadapterParentaddrAddress>(expected);
    }

    [TestMethod]
    public void Zpci()
    {
        const string expected = $@"
{XMLDECL}
<Zpci {XMLNS} />
";

        this.AssertXml<Zpci>(expected);
    }
}
