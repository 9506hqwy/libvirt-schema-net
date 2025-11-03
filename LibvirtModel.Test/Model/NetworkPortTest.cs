namespace LibvirtModel.Test.Model;

[TestClass]
public class NetworkPortTest : TestBase
{
    [TestMethod]
    public void Networkport()
    {
        const string expected = $@"
{XMLDECL}
<networkport {XMLNS} />
";

        this.AssertXml<Networkport>(expected);
    }

    [TestMethod]
    public void NetworkportMac()
    {
        const string expected = $@"
{XMLDECL}
<mac {XMLNS} />
";

        this.AssertXml<NetworkportMac>(expected);
    }

    [TestMethod]
    public void NetworkportOwner()
    {
        const string expected = $@"
{XMLDECL}
<owner {XMLNS} />
";

        this.AssertXml<NetworkportOwner>(expected);
    }

    [TestMethod]
    public void NetworkportPlug()
    {
        const string expected = $@"
{XMLDECL}
<plug {XMLNS} type=""bridge"" />
";

        this.AssertXml<NetworkportPlug>(expected);
    }

    [TestMethod]
    public void NetworkportPlugAddress()
    {
        const string expected = $@"
{XMLDECL}
<NetworkportPlugAddress {XMLNS} />
";

        this.AssertXml<NetworkportPlugAddress>(expected);
    }

    [TestMethod]
    public void NetworkportPlugMode()
    {
        var values = Enum.GetValues(typeof(NetworkportPlugMode));
        Assert.HasCount(4, values);
    }

    [TestMethod]
    public void NetworkportPlugType()
    {
        var values = Enum.GetValues(typeof(NetworkportPlugType));
        Assert.HasCount(4, values);
    }

    [TestMethod]
    public void NetworkportRxfilters()
    {
        const string expected = $@"
{XMLDECL}
<rxfilters {XMLNS} trustGuest=""no"" />
";

        this.AssertXml<NetworkportRxfilters>(expected);
    }
}
