namespace LibvirtModel.Test.Model;

[TestClass]
public class NwFilterBindingTest : TestBase
{
    [TestMethod]
    public void Filterbinding()
    {
        const string expected = $@"
{XMLDECL}
<filterbinding {XMLNS} />
";

        this.AssertXml<Filterbinding>(expected);
    }

    [TestMethod]
    public void FilterbindingFilterref()
    {
        const string expected = $@"
{XMLDECL}
<FilterbindingFilterref {XMLNS} />
";

        this.AssertXml<FilterbindingFilterref>(expected);
    }

    [TestMethod]
    public void FilterFilterrefParameter()
    {
        const string expected = $@"
{XMLDECL}
<FilterFilterrefParameter {XMLNS} />
";

        this.AssertXml<FilterFilterrefParameter>(expected);
    }

    [TestMethod]
    public void FilterbindingLinkdev()
    {
        const string expected = $@"
{XMLDECL}
<FilterbindingLinkdev {XMLNS} />
";

        this.AssertXml<FilterbindingLinkdev>(expected);
    }

    [TestMethod]
    public void FilterbindingMac()
    {
        const string expected = $@"
{XMLDECL}
<FilterbindingMac {XMLNS} />
";

        this.AssertXml<FilterbindingMac>(expected);
    }

    [TestMethod]
    public void FilterbindingPortdev()
    {
        const string expected = $@"
{XMLDECL}
<FilterbindingPortdev {XMLNS} />
";

        this.AssertXml<FilterbindingPortdev>(expected);
    }

    [TestMethod]
    public void FilterbindingOwner()
    {
        const string expected = $@"
{XMLDECL}
<FilterbindingOwner {XMLNS} />
";

        this.AssertXml<FilterbindingOwner>(expected);
    }
}
