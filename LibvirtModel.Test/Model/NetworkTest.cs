namespace LibvirtModel.Test.Model;

[TestClass]
public class NetworkTest : TestBase
{
    [TestMethod]
    public void DnsmasqNetworkOptions()
    {
        const string expected = $@"
{XMLDECL}
<DnsmasqNetworkOptions {XMLNS} />
";

        this.AssertXml<DnsmasqNetworkOptions>(expected);
    }

    [TestMethod]
    public void DnsmasqNetworkOptionsOption()
    {
        const string expected = $@"
{XMLDECL}
<DnsmasqNetworkOptionsOption {XMLNS} />
";

        this.AssertXml<DnsmasqNetworkOptionsOption>(expected);
    }

    [TestMethod]
    public void MacTableManager()
    {
        var values = Enum.GetValues(typeof(MacTableManager));
        Assert.HasCount(2, values);
    }

    [TestMethod]
    public void Network()
    {
        const string expected = $@"
{XMLDECL}
<network {XMLNS} />
";

        this.AssertXml<Network>(expected);
    }

    [TestMethod]
    public void NetworkBridge()
    {
        const string expected = $@"
{XMLDECL}
<NetworkBridge {XMLNS} />
";

        this.AssertXml<NetworkBridge>(expected);
    }

    [TestMethod]
    public void NetworkDns()
    {
        const string expected = $@"
{XMLDECL}
<NetworkDns {XMLNS} />
";

        this.AssertXml<NetworkDns>(expected);
    }

    [TestMethod]
    public void NetworkDnsForwarder()
    {
        const string expected = $@"
{XMLDECL}
<NetworkDnsForwarder {XMLNS} />
";

        this.AssertXml<NetworkDnsForwarder>(expected);
    }

    [TestMethod]
    public void NetworkDnsHost()
    {
        const string expected = $@"
{XMLDECL}
<NetworkDnsHost {XMLNS} />
";

        this.AssertXml<NetworkDnsHost>(expected);
    }

    [TestMethod]
    public void NetworkDnsSrv()
    {
        const string expected = $@"
{XMLDECL}
<NetworkDnsSrv {XMLNS} />
";

        this.AssertXml<NetworkDnsSrv>(expected);
    }

    [TestMethod]
    public void NetworkDnsTxt()
    {
        const string expected = $@"
{XMLDECL}
<NetworkDnsTxt {XMLNS} />
";

        this.AssertXml<NetworkDnsTxt>(expected);
    }

    [TestMethod]
    public void NetworkDomain()
    {
        const string expected = $@"
{XMLDECL}
<NetworkDomain {XMLNS} />
";

        this.AssertXml<NetworkDomain>(expected);
    }

    [TestMethod]
    public void NetworkForward()
    {
        const string expected = $@"
{XMLDECL}
<NetworkForward {XMLNS} />
";

        this.AssertXml<NetworkForward>(expected);
    }

    [TestMethod]
    public void NetworkForwardAddress()
    {
        const string expected = $@"
{XMLDECL}
<NetworkForwardAddress {XMLNS} type=""pci"" />
";

        this.AssertXml<NetworkForwardAddress>(expected);
    }

    [TestMethod]
    public void NetworkForwardAddressType()
    {
        var values = Enum.GetValues(typeof(NetworkForwardAddressType));
        Assert.HasCount(1, values);
    }

    [TestMethod]
    public void NetworkForwardInterface()
    {
        const string expected = $@"
{XMLDECL}
<NetworkForwardInterface {XMLNS} />
";

        this.AssertXml<NetworkForwardInterface>(expected);
    }

    [TestMethod]
    public void NetworkForwardMode()
    {
        var values = Enum.GetValues(typeof(NetworkForwardMode));
        Assert.HasCount(8, values);
    }

    [TestMethod]
    public void NetworkForwardNat()
    {
        const string expected = $@"
{XMLDECL}
<NetworkForwardNat {XMLNS} />
";

        this.AssertXml<NetworkForwardNat>(expected);
    }

    [TestMethod]
    public void NetworkForwardNatAddress()
    {
        const string expected = $@"
{XMLDECL}
<NetworkForwardNatAddress {XMLNS} />
";

        this.AssertXml<NetworkForwardNatAddress>(expected);
    }

    [TestMethod]
    public void NetworkForwardNatPort()
    {
        const string expected = $@"
{XMLDECL}
<NetworkForwardNatPort {XMLNS} start=""0"" end=""0"" />
";

        this.AssertXml<NetworkForwardNatPort>(expected);
    }

    [TestMethod]
    public void NetworkForwardPf()
    {
        const string expected = $@"
{XMLDECL}
<NetworkForwardPf {XMLNS} />
";

        this.AssertXml<NetworkForwardPf>(expected);
    }

    [TestMethod]
    public void NetworkIp()
    {
        const string expected = $@"
{XMLDECL}
<NetworkIp {XMLNS} />
";

        this.AssertXml<NetworkIp>(expected);
    }

    [TestMethod]
    public void NetworkIpDhcp()
    {
        const string expected = $@"
{XMLDECL}
<NetworkIpDhcp {XMLNS} />
";

        this.AssertXml<NetworkIpDhcp>(expected);
    }

    [TestMethod]
    public void NetworkIpDhcpBootp()
    {
        const string expected = $@"
{XMLDECL}
<NetworkIpDhcpBootp {XMLNS} />
";

        this.AssertXml<NetworkIpDhcpBootp>(expected);
    }

    [TestMethod]
    public void NetworkIpDhcpHost()
    {
        const string expected = $@"
{XMLDECL}
<NetworkIpDhcpHost {XMLNS} />
";

        this.AssertXml<NetworkIpDhcpHost>(expected);
    }

    [TestMethod]
    public void NetworkIpDhcpHostLease()
    {
        const string expected = $@"
{XMLDECL}
<NetworkIpDhcpHostLease {XMLNS} expiry=""0"" />
";

        this.AssertXml<NetworkIpDhcpHostLease>(expected);
    }

    [TestMethod]
    public void NetworkIpDhcpRange()
    {
        const string expected = $@"
{XMLDECL}
<NetworkIpDhcpRange {XMLNS} />
";

        this.AssertXml<NetworkIpDhcpRange>(expected);
    }

    [TestMethod]
    public void NetworkIpDhcpRangeLease()
    {
        const string expected = $@"
{XMLDECL}
<NetworkIpDhcpRangeLease {XMLNS} expiry=""0"" />
";

        this.AssertXml<NetworkIpDhcpRangeLease>(expected);
    }

    [TestMethod]
    public void NetworkIpTftp()
    {
        const string expected = $@"
{XMLDECL}
<NetworkIpTftp {XMLNS} />
";

        this.AssertXml<NetworkIpTftp>(expected);
    }

    [TestMethod]
    public void NetworkMac()
    {
        const string expected = $@"
{XMLDECL}
<NetworkMac {XMLNS} />
";

        this.AssertXml<NetworkMac>(expected);
    }

    [TestMethod]
    public void NetworkPortgroup()
    {
        const string expected = $@"
{XMLDECL}
<NetworkPortgroup {XMLNS} />
";

        this.AssertXml<NetworkPortgroup>(expected);
    }

    [TestMethod]
    public void NetworkPortgroupVirtualport()
    {
        const string expected = $@"
{XMLDECL}
<NetworkPortgroupVirtualport {XMLNS} />
";

        this.AssertXml<NetworkPortgroupVirtualport>(expected);
    }

    [TestMethod]
    public void NetworkPortgroupVirtualportType()
    {
        var values = Enum.GetValues(typeof(NetworkPortgroupVirtualportType));
        Assert.HasCount(4, values);
    }

    [TestMethod]
    public void NetworkPortgroupVirtualportParameters()
    {
        const string expected = $@"
{XMLDECL}
<NetworkPortgroupVirtualportParameters {XMLNS} />
";

        this.AssertXml<NetworkPortgroupVirtualportParameters>(expected);
    }

    [TestMethod]
    public void NetworkVirtualport()
    {
        const string expected = $@"
{XMLDECL}
<NetworkVirtualport {XMLNS} />
";

        this.AssertXml<NetworkVirtualport>(expected);
    }

    [TestMethod]
    public void NetworkVirtualportType()
    {
        var values = Enum.GetValues(typeof(NetworkVirtualportType));
        Assert.HasCount(4, values);
    }

    [TestMethod]
    public void NetworkVirtualportParameters()
    {
        const string expected = $@"
{XMLDECL}
<NetworkVirtualportParameters {XMLNS} />
";

        this.AssertXml<NetworkVirtualportParameters>(expected);
    }
}
