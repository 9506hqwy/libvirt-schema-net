namespace LibvirtModel.Test.Model;

[TestClass]
public class NetworkCommonTest : TestBase
{
    [TestMethod]
    public void NetworkBandwidth()
    {
        const string expected = $@"
{XMLDECL}
<bandwidth {XMLNS} />
";

        this.AssertXml<NetworkBandwidth>(expected);
    }

    [TestMethod]
    public void NetworkBandwidthInbound()
    {
        const string expected = $@"
{XMLDECL}
<NetworkBandwidthInbound {XMLNS} />
";

        this.AssertXml<NetworkBandwidthInbound>(expected);
    }

    [TestMethod]
    public void NetworkBandwidthOutbound()
    {
        const string expected = $@"
{XMLDECL}
<NetworkBandwidthOutbound {XMLNS} />
";

        this.AssertXml<NetworkBandwidthOutbound>(expected);
    }

    [TestMethod]
    public void NetworkMtu()
    {
        const string expected = $@"
{XMLDECL}
<mtu {XMLNS} size=""0"" />
";

        this.AssertXml<NetworkMtu>(expected);
    }

    [TestMethod]
    public void NetworkPortOptions()
    {
        const string expected = $@"
{XMLDECL}
<port {XMLNS} />
";

        this.AssertXml<NetworkPortOptions>(expected);
    }

    [TestMethod]
    public void NetworkportVirtualport()
    {
        const string expected = $@"
{XMLDECL}
<NetworkportVirtualport {XMLNS} />
";

        this.AssertXml<NetworkportVirtualport>(expected);
    }

    [TestMethod]
    public void NetworkRoute()
    {
        const string expected = $@"
{XMLDECL}
<route {XMLNS} />
";

        this.AssertXml<NetworkRoute>(expected);
    }

    [TestMethod]
    public void NetworkportVirtualportType()
    {
        var values = Enum.GetValues(typeof(NetworkportVirtualportType));
        Assert.HasCount(4, values);
    }

    [TestMethod]
    public void NetworkportVirtualportParameters()
    {
        const string expected = $@"
{XMLDECL}
<NetworkportVirtualportParameters {XMLNS} />
";

        this.AssertXml<NetworkportVirtualportParameters>(expected);
    }

    [TestMethod]
    public void NetworkVlan()
    {
        const string expected = $@"
{XMLDECL}
<vlan {XMLNS} />
";

        this.AssertXml<NetworkVlan>(expected);
    }

    [TestMethod]
    public void NetworkVlanTag()
    {
        const string expected = $@"
{XMLDECL}
<NetworkVlanTag {XMLNS} id=""0"" />
";

        this.AssertXml<NetworkVlanTag>(expected);
    }

    [TestMethod]
    public void NetworkVlanTagNativeMode()
    {
        var values = Enum.GetValues(typeof(NetworkVlanTagNativeMode));
        Assert.HasCount(2, values);
    }

    [TestMethod]
    public void NetworkVlanTrunk()
    {
        var values = Enum.GetValues(typeof(NetworkVlanTrunk));
        Assert.HasCount(1, values);
    }
}
