namespace LibvirtModel.Test.Model;

[TestClass]
public class NwFilterTest : TestBase
{
    [TestMethod]
    public void ActionType()
    {
        var values = Enum.GetValues(typeof(ActionType));
        Assert.AreEqual(5, values.Length);
    }

    [TestMethod]
    public void Boolean()
    {
        var values = Enum.GetValues(typeof(Libvirt.Model.Boolean));
        Assert.AreEqual(6, values.Length);
    }

    [TestMethod]
    public void Filter()
    {
        const string expected = $@"
{XMLDECL}
<filter {XMLNS} />
";

        this.AssertXml<Filter>(expected);
    }

    [TestMethod]
    public void FilterFilterref()
    {
        const string expected = $@"
{XMLDECL}
<FilterFilterref {XMLNS} />
";

        this.AssertXml<FilterFilterref>(expected);
    }

    [TestMethod]
    public void FilterRule()
    {
        const string expected = $@"
{XMLDECL}
<FilterRule {XMLNS} action=""accept"" direction=""in"" />
";

        this.AssertXml<FilterRule>(expected);
    }

    [TestMethod]
    public void FilterRuleAh()
    {
        const string expected = $@"
{XMLDECL}
<FilterRuleAh {XMLNS} />
";

        this.AssertXml<FilterRuleAh>(expected);
    }

    [TestMethod]
    public void FilterRuleAhIpv6()
    {
        const string expected = $@"
{XMLDECL}
<FilterRuleAhIpv6 {XMLNS} />
";

        this.AssertXml<FilterRuleAhIpv6>(expected);
    }

    [TestMethod]
    public void FilterRuleAll()
    {
        const string expected = $@"
{XMLDECL}
<FilterRuleAll {XMLNS} />
";

        this.AssertXml<FilterRuleAll>(expected);
    }

    [TestMethod]
    public void FilterRuleAllIpv6()
    {
        const string expected = $@"
{XMLDECL}
<FilterRuleAllIpv6 {XMLNS} />
";

        this.AssertXml<FilterRuleAllIpv6>(expected);
    }

    [TestMethod]
    public void FilterRuleArp()
    {
        const string expected = $@"
{XMLDECL}
<FilterRuleArp {XMLNS} />
";

        this.AssertXml<FilterRuleArp>(expected);
    }

    [TestMethod]
    public void FilterRuleEsp()
    {
        const string expected = $@"
{XMLDECL}
<FilterRuleEsp {XMLNS} />
";

        this.AssertXml<FilterRuleEsp>(expected);
    }

    [TestMethod]
    public void FilterRuleEspIpv6()
    {
        const string expected = $@"
{XMLDECL}
<FilterRuleEspIpv6 {XMLNS} />
";

        this.AssertXml<FilterRuleEspIpv6>(expected);
    }

    [TestMethod]
    public void FilterRuleIcmp()
    {
        const string expected = $@"
{XMLDECL}
<FilterRuleIcmp {XMLNS} />
";

        this.AssertXml<FilterRuleIcmp>(expected);
    }

    [TestMethod]
    public void FilterRuleIcmpv6()
    {
        const string expected = $@"
{XMLDECL}
<FilterRuleIcmpv6 {XMLNS} />
";

        this.AssertXml<FilterRuleIcmpv6>(expected);
    }

    [TestMethod]
    public void FilterRuleIgmp()
    {
        const string expected = $@"
{XMLDECL}
<FilterRuleIgmp {XMLNS} />
";

        this.AssertXml<FilterRuleIgmp>(expected);
    }

    [TestMethod]
    public void FilterRuleIp()
    {
        const string expected = $@"
{XMLDECL}
<FilterRuleIp {XMLNS} />
";

        this.AssertXml<FilterRuleIp>(expected);
    }

    [TestMethod]
    public void FilterRuleIpv6()
    {
        const string expected = $@"
{XMLDECL}
<FilterRuleIpv6 {XMLNS} />
";

        this.AssertXml<FilterRuleIpv6>(expected);
    }

    [TestMethod]
    public void FilterRuleMac()
    {
        const string expected = $@"
{XMLDECL}
<FilterRuleMac {XMLNS} />
";

        this.AssertXml<FilterRuleMac>(expected);
    }

    [TestMethod]
    public void FilterRuleRarp()
    {
        const string expected = $@"
{XMLDECL}
<FilterRuleRarp {XMLNS} />
";

        this.AssertXml<FilterRuleRarp>(expected);
    }

    [TestMethod]
    public void FilterRuleSctp()
    {
        const string expected = $@"
{XMLDECL}
<FilterRuleSctp {XMLNS} />
";

        this.AssertXml<FilterRuleSctp>(expected);
    }

    [TestMethod]
    public void FilterRuleSctpIpv6()
    {
        const string expected = $@"
{XMLDECL}
<FilterRuleSctpIpv6 {XMLNS} />
";

        this.AssertXml<FilterRuleSctpIpv6>(expected);
    }

    [TestMethod]
    public void FilterRuleStp()
    {
        const string expected = $@"
{XMLDECL}
<FilterRuleStp {XMLNS} />
";

        this.AssertXml<FilterRuleStp>(expected);
    }

    [TestMethod]
    public void FilterRuleTcp()
    {
        const string expected = $@"
{XMLDECL}
<FilterRuleTcp {XMLNS} />
";

        this.AssertXml<FilterRuleTcp>(expected);
    }

    [TestMethod]
    public void FilterRuleTcpIpv6()
    {
        const string expected = $@"
{XMLDECL}
<FilterRuleTcpIpv6 {XMLNS} />
";

        this.AssertXml<FilterRuleTcpIpv6>(expected);
    }

    [TestMethod]
    public void FilterRuleUdp()
    {
        const string expected = $@"
{XMLDECL}
<FilterRuleUdp {XMLNS} />
";

        this.AssertXml<FilterRuleUdp>(expected);
    }

    [TestMethod]
    public void FilterRuleUdpIpv6()
    {
        const string expected = $@"
{XMLDECL}
<FilterRuleUdpIpv6 {XMLNS} />
";

        this.AssertXml<FilterRuleUdpIpv6>(expected);
    }

    [TestMethod]
    public void FilterRuleUdplite()
    {
        const string expected = $@"
{XMLDECL}
<FilterRuleUdplite {XMLNS} />
";

        this.AssertXml<FilterRuleUdplite>(expected);
    }

    [TestMethod]
    public void FilterRuleUdpliteIpv6()
    {
        const string expected = $@"
{XMLDECL}
<FilterRuleUdpliteIpv6 {XMLNS} />
";

        this.AssertXml<FilterRuleUdpliteIpv6>(expected);
    }

    [TestMethod]
    public void FilterRuleVlan()
    {
        const string expected = $@"
{XMLDECL}
<FilterRuleVlan {XMLNS} />
";

        this.AssertXml<FilterRuleVlan>(expected);
    }
}
