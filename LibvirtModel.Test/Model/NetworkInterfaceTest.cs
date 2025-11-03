namespace LibvirtModel.Test.Model;

[TestClass]
public class NetworkInterfaceTest : TestBase
{
    [TestMethod]
    public void BondInterface()
    {
        const string expected = $@"
{XMLDECL}
<interface {XMLNS} type=""bond"" />
";

        this.AssertXml<BondInterface>(expected);
    }

    [TestMethod]
    public void BondInterfaceBondElement()
    {
        const string expected = $@"
{XMLDECL}
<bond {XMLNS} />
";

        this.AssertXml<BondInterfaceBondElement>(expected);
    }

    [TestMethod]
    public void BondInterfaceProtocol()
    {
        const string expected = $@"
{XMLDECL}
<BondInterfaceProtocol {XMLNS} family=""ipv4"" />
";

        this.AssertXml<BondInterfaceProtocol>(expected);
    }

    [TestMethod]
    public void BondInterfaceProtocolFamily()
    {
        var values = Enum.GetValues(typeof(BondInterfaceProtocolFamily));
        Assert.HasCount(2, values);
    }

    [TestMethod]
    public void BondInterfaceProtocolRoute()
    {
        const string expected = $@"
{XMLDECL}
<BondInterfaceProtocolRoute {XMLNS} />
";

        this.AssertXml<BondInterfaceProtocolRoute>(expected);
    }

    [TestMethod]
    public void BondInterfaceProtocolIp()
    {
        const string expected = $@"
{XMLDECL}
<BondInterfaceProtocolIp {XMLNS} />
";

        this.AssertXml<BondInterfaceProtocolIp>(expected);
    }

    [TestMethod]
    public void BondInterfaceBareEthernetInterface()
    {
        const string expected = $@"
{XMLDECL}
<BondInterfaceBareEthernetInterface {XMLNS} type=""ethernet"" />
";

        this.AssertXml<BondInterfaceBareEthernetInterface>(expected);
    }

    [TestMethod]
    public void BondInterfaceBondElementArpmon()
    {
        const string expected = $@"
{XMLDECL}
<BondInterfaceBondElementArpmon {XMLNS} interval=""0"" />
";

        this.AssertXml<BondInterfaceBondElementArpmon>(expected);
    }

    [TestMethod]
    public void BondInterfaceBondElementArpmonValidate()
    {
        var values = Enum.GetValues(typeof(BondInterfaceBondElementArpmonValidate));
        Assert.HasCount(4, values);
    }

    [TestMethod]
    public void BondInterfaceBondElementMiimon()
    {
        const string expected = $@"
{XMLDECL}
<BondInterfaceBondElementMiimon {XMLNS} freq=""0"" />
";

        this.AssertXml<BondInterfaceBondElementMiimon>(expected);
    }

    [TestMethod]
    public void BondInterfaceBondElementMiimonCarrier()
    {
        var values = Enum.GetValues(typeof(BondInterfaceBondElementMiimonCarrier));
        Assert.HasCount(2, values);
    }

    [TestMethod]
    public void BondInterfaceBondElementMode()
    {
        var values = Enum.GetValues(typeof(BondInterfaceBondElementMode));
        Assert.HasCount(7, values);
    }

    [TestMethod]
    public void BondInterfaceCommon()
    {
        var values = Enum.GetValues(typeof(BondInterfaceCommon));
        Assert.HasCount(1, values);
    }

    [TestMethod]
    public void BridgeInterface()
    {
        const string expected = $@"
{XMLDECL}
<interface {XMLNS} type=""bridge"" />
";

        this.AssertXml<BridgeInterface>(expected);
    }

    [TestMethod]
    public void BridgeInterfaceBridge()
    {
        const string expected = $@"
{XMLDECL}
<BridgeInterfaceBridge {XMLNS} />
";

        this.AssertXml<BridgeInterfaceBridge>(expected);
    }

    [TestMethod]
    public void BridgeInterfaceBridgeInterface()
    {
        const string expected = $@"
{XMLDECL}
<BridgeInterfaceBridgeInterface {XMLNS} type=""bond"" />
";

        this.AssertXml<BridgeInterfaceBridgeInterface>(expected);
    }

    [TestMethod]
    public void BridgeInterfaceBridgeInterfaceType()
    {
        var values = Enum.GetValues(typeof(BridgeInterfaceBridgeInterfaceType));
        Assert.HasCount(3, values);
    }

    [TestMethod]
    public void BridgeInterfaceProtocol()
    {
        const string expected = $@"
{XMLDECL}
<BridgeInterfaceProtocol {XMLNS} family=""ipv4"" />
";

        this.AssertXml<BridgeInterfaceProtocol>(expected);
    }

    [TestMethod]
    public void BridgeInterfaceProtocolRoute()
    {
        const string expected = $@"
{XMLDECL}
<BridgeInterfaceProtocolRoute {XMLNS} />
";

        this.AssertXml<BridgeInterfaceProtocolRoute>(expected);
    }

    [TestMethod]
    public void BridgeInterfaceProtocolIp()
    {
        const string expected = $@"
{XMLDECL}
<BridgeInterfaceProtocolIp {XMLNS} />
";

        this.AssertXml<BridgeInterfaceProtocolIp>(expected);
    }

    [TestMethod]
    public void BridgeInterfaceType()
    {
        var values = Enum.GetValues(typeof(BridgeInterfaceType));
        Assert.HasCount(1, values);
    }

    [TestMethod]
    public void EthernetInterface()
    {
        const string expected = $@"
{XMLDECL}
<interface {XMLNS} type=""ethernet"" />
";

        this.AssertXml<EthernetInterface>(expected);
    }

    [TestMethod]
    public void EthernetInterfaceMac()
    {
        const string expected = $@"
{XMLDECL}
<EthernetInterfaceMac {XMLNS} />
";

        this.AssertXml<EthernetInterfaceMac>(expected);
    }

    [TestMethod]
    public void EthernetInterfaceMtu()
    {
        const string expected = $@"
{XMLDECL}
<EthernetInterfaceMtu {XMLNS} size=""0"" />
";

        this.AssertXml<EthernetInterfaceMtu>(expected);
    }

    [TestMethod]
    public void EthernetInterfaceProtocol()
    {
        const string expected = $@"
{XMLDECL}
<EthernetInterfaceProtocol {XMLNS} family=""ipv4"" />
";

        this.AssertXml<EthernetInterfaceProtocol>(expected);
    }

    [TestMethod]
    public void EthernetInterfaceProtocolIpv6Autoconf()
    {
        const string expected = $@"
{XMLDECL}
<EthernetInterfaceProtocolIpv6Autoconf {XMLNS} />
";

        this.AssertXml<EthernetInterfaceProtocolIpv6Autoconf>(expected);
    }

    [TestMethod]
    public void EthernetInterfaceDhcpElement()
    {
        const string expected = $@"
{XMLDECL}
<dhcp {XMLNS} />
";

        this.AssertXml<EthernetInterfaceDhcpElement>(expected);
    }

    [TestMethod]
    public void EthernetInterfaceProtocolRoute()
    {
        const string expected = $@"
{XMLDECL}
<EthernetInterfaceProtocolRoute {XMLNS} />
";

        this.AssertXml<EthernetInterfaceProtocolRoute>(expected);
    }

    [TestMethod]
    public void EthernetInterfaceProtocolIp()
    {
        const string expected = $@"
{XMLDECL}
<EthernetInterfaceProtocolIp {XMLNS} />
";

        this.AssertXml<EthernetInterfaceProtocolIp>(expected);
    }

    [TestMethod]
    public void EthernetInterfaceStart()
    {
        const string expected = $@"
{XMLDECL}
<EthernetInterfaceStart {XMLNS} mode=""hotplug"" />
";

        this.AssertXml<EthernetInterfaceStart>(expected);
    }

    [TestMethod]
    public void EthernetInterfaceStartMode()
    {
        var values = Enum.GetValues(typeof(EthernetInterfaceStartMode));
        Assert.HasCount(3, values);
    }

    [TestMethod]
    public void EthernetInterfaceType()
    {
        var values = Enum.GetValues(typeof(EthernetInterfaceType));
        Assert.HasCount(1, values);
    }

    [TestMethod]
    public void VlanInterface()
    {
        const string expected = $@"
{XMLDECL}
<interface {XMLNS} type=""vlan"" />
";

        this.AssertXml<VlanInterface>(expected);
    }

    [TestMethod]
    public void VlanInterfaceProtocol()
    {
        const string expected = $@"
{XMLDECL}
<VlanInterfaceProtocol {XMLNS} family=""ipv4"" />
";

        this.AssertXml<VlanInterfaceProtocol>(expected);
    }

    [TestMethod]
    public void VlanInterfaceProtocolRoute()
    {
        const string expected = $@"
{XMLDECL}
<VlanInterfaceProtocolRoute {XMLNS} />
";

        this.AssertXml<VlanInterfaceProtocolRoute>(expected);
    }

    [TestMethod]
    public void VlanInterfaceProtocolIp()
    {
        const string expected = $@"
{XMLDECL}
<VlanInterfaceProtocolIp {XMLNS} />
";

        this.AssertXml<VlanInterfaceProtocolIp>(expected);
    }

    [TestMethod]
    public void VlanInterfaceVlanDevice()
    {
        const string expected = $@"
{XMLDECL}
<vlan {XMLNS} tag=""0"" />
";

        this.AssertXml<VlanInterfaceVlanDevice>(expected);
    }

    [TestMethod]
    public void VlanInterfaceVlanDeviceInterface()
    {
        const string expected = $@"
{XMLDECL}
<VlanInterfaceVlanDeviceInterface {XMLNS} />
";

        this.AssertXml<VlanInterfaceVlanDeviceInterface>(expected);
    }
}
