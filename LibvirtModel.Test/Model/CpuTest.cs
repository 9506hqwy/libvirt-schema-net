namespace LibvirtModel.Test.Model;

[TestClass]
public class CpuTest : TestBase
{
    [TestMethod]
    public void Guestcpu()
    {
        const string expected = $@"
{XMLDECL}
<cpu {XMLNS} />
";

        this.AssertXml<Guestcpu>(expected);
    }

    [TestMethod]
    public void GuestcpuCpuCache()
    {
        const string expected = $@"
{XMLDECL}
<cache {XMLNS} mode=""disable"" />
";

        this.AssertXml<GuestcpuCpuCache>(expected);
    }

    [TestMethod]
    public void GuestcpuCpuCacheLevel()
    {
        var values = Enum.GetValues(typeof(GuestcpuCpuCacheLevel));
        Assert.HasCount(3, values);
    }

    [TestMethod]
    public void GuestcpuCpuCacheMode()
    {
        var values = Enum.GetValues(typeof(GuestcpuCpuCacheMode));
        Assert.HasCount(3, values);
    }

    [TestMethod]
    public void GuestcpuCpuCheck()
    {
        var values = Enum.GetValues(typeof(GuestcpuCpuCheck));
        Assert.HasCount(3, values);
    }

    [TestMethod]
    public void GuestcpuCpuFeature()
    {
        const string expected = $@"
{XMLDECL}
<feature {XMLNS} policy=""disable"" />
";

        this.AssertXml<GuestcpuCpuFeature>(expected);
    }

    [TestMethod]
    public void GuestcpuCGuestcpuCpuFeaturePolicypuMatch()
    {
        var values = Enum.GetValues(typeof(GuestcpuCpuFeaturePolicy));
        Assert.HasCount(5, values);
    }

    [TestMethod]
    public void GuestcpuCpuMatch()
    {
        var values = Enum.GetValues(typeof(GuestcpuCpuMatch));
        Assert.HasCount(3, values);
    }

    [TestMethod]
    public void GuestcpuCpuMaxPhysAddr()
    {
        const string expected = $@"
{XMLDECL}
<maxphysaddr {XMLNS} mode=""emulate"" />
";

        this.AssertXml<GuestcpuCpuMaxPhysAddr>(expected);
    }

    [TestMethod]
    public void GuestcpuCpuMaxPhysAddrMode()
    {
        var values = Enum.GetValues(typeof(GuestcpuCpuMaxPhysAddrMode));
        Assert.HasCount(2, values);
    }

    [TestMethod]
    public void GuestcpuCpuMode()
    {
        var values = Enum.GetValues(typeof(GuestcpuCpuMode));
        Assert.HasCount(4, values);
    }

    [TestMethod]
    public void GuestcpuCpuModel()
    {
        const string expected = $@"
{XMLDECL}
<model {XMLNS} />
";

        this.AssertXml<GuestcpuCpuModel>(expected);
    }

    [TestMethod]
    public void GuestcpuCpuModelFallback()
    {
        var values = Enum.GetValues(typeof(GuestcpuCpuModelFallback));
        Assert.HasCount(2, values);
    }

    [TestMethod]
    public void GuestcpuCpuNuma()
    {
        const string expected = $@"
{XMLDECL}
<numa {XMLNS} />
";

        this.AssertXml<GuestcpuCpuNuma>(expected);
    }

    [TestMethod]
    public void GuestcpuCpuTopology()
    {
        const string expected = $@"
{XMLDECL}
<topology {XMLNS} sockets=""0"" cores=""0"" threads=""0"" />
";

        this.AssertXml<GuestcpuCpuTopology>(expected);
    }

    [TestMethod]
    public void GuestcpuNumaCache()
    {
        const string expected = $@"
{XMLDECL}
<GuestcpuNumaCache {XMLNS} level=""0"" associativity=""direct"" policy=""none"" />
";

        this.AssertXml<GuestcpuNumaCache>(expected);
    }

    [TestMethod]
    public void GuestcpuNumaCacheAssociativity()
    {
        var values = Enum.GetValues(typeof(GuestcpuNumaCacheAssociativity));
        Assert.HasCount(3, values);
    }

    [TestMethod]
    public void GuestcpuNumaCacheLine()
    {
        const string expected = $@"
{XMLDECL}
<GuestcpuNumaCacheLine {XMLNS} value=""0"" />
";

        this.AssertXml<GuestcpuNumaCacheLine>(expected);
    }

    [TestMethod]
    public void GuestcpuNumaCachePolicy()
    {
        var values = Enum.GetValues(typeof(GuestcpuNumaCachePolicy));
        Assert.HasCount(3, values);
    }

    [TestMethod]
    public void GuestcpuNumaCacheSize()
    {
        const string expected = $@"
{XMLDECL}
<GuestcpuNumaCacheSize {XMLNS} value=""0"" />
";

        this.AssertXml<GuestcpuNumaCacheSize>(expected);
    }

    [TestMethod]
    public void GuestcpuNumaCell()
    {
        const string expected = $@"
{XMLDECL}
<cell {XMLNS} memory=""0"" />
";

        this.AssertXml<GuestcpuNumaCell>(expected);
    }

    [TestMethod]
    public void GuestcpuNumaCellDistances()
    {
        const string expected = $@"
{XMLDECL}
<GuestcpuNumaCellDistances {XMLNS} />
";

        this.AssertXml<GuestcpuNumaCellDistances>(expected);
    }

    [TestMethod]
    public void GuestcpuNumaDistance()
    {
        const string expected = $@"
{XMLDECL}
<GuestcpuNumaDistance {XMLNS} id=""0"" value=""0"" />
";

        this.AssertXml<GuestcpuNumaDistance>(expected);
    }

    [TestMethod]
    public void GuestcpuNumaCellMemAccess()
    {
        var values = Enum.GetValues(typeof(GuestcpuNumaCellMemAccess));
        Assert.HasCount(2, values);
    }

    [TestMethod]
    public void GuestcpuNumaInterconnects()
    {
        const string expected = $@"
{XMLDECL}
<interconnects {XMLNS} />
";

        this.AssertXml<GuestcpuNumaInterconnects>(expected);
    }

    [TestMethod]
    public void GuestcpuNumaInterconnectsBandwidth()
    {
        const string expected = $@"
{XMLDECL}
<GuestcpuNumaInterconnectsBandwidth {XMLNS} initiator=""0"" target=""0"" type=""access"" value=""0"" />
";

        this.AssertXml<GuestcpuNumaInterconnectsBandwidth>(expected);
    }

    [TestMethod]
    public void GuestcpuNumaInterconnectsBandwidthType()
    {
        var values = Enum.GetValues(typeof(GuestcpuNumaInterconnectsBandwidthType));
        Assert.HasCount(3, values);
    }

    [TestMethod]
    public void GuestcpuNumaInterconnectsLatency()
    {
        const string expected = $@"
{XMLDECL}
<GuestcpuNumaInterconnectsLatency {XMLNS} initiator=""0"" target=""0"" type=""access"" value=""0"" />
";

        this.AssertXml<GuestcpuNumaInterconnectsLatency>(expected);
    }

    [TestMethod]
    public void GuestcpuNumaInterconnectsLatencyType()
    {
        var values = Enum.GetValues(typeof(GuestcpuNumaInterconnectsLatencyType));
        Assert.HasCount(3, values);
    }

    [TestMethod]
    public void Hostcpu()
    {
        const string expected = $@"
{XMLDECL}
<cpu {XMLNS}>
  <arch>aarch64</arch>
</cpu>
";

        this.AssertXml<Hostcpu>(expected);
    }

    [TestMethod]
    public void HostcpuCounter()
    {
        const string expected = $@"
{XMLDECL}
<HostcpuCounter {XMLNS} frequency=""0"" scaling=""no"" />
";

        this.AssertXml<HostcpuCounter>(expected);
    }

    [TestMethod]
    public void HostcpuFeature()
    {
        const string expected = $@"
{XMLDECL}
<HostcpuFeature {XMLNS} />
";

        this.AssertXml<HostcpuFeature>(expected);
    }

    [TestMethod]
    public void HostcpuFeatures()
    {
        const string expected = $@"
{XMLDECL}
<HostcpuFeatures {XMLNS} />
";

        this.AssertXml<HostcpuFeatures>(expected);
    }

    [TestMethod]
    public void HostcpuFeaturesNonpae()
    {
        const string expected = $@"
{XMLDECL}
<HostcpuFeaturesNonpae {XMLNS} />
";

        this.AssertXml<HostcpuFeaturesNonpae>(expected);
    }

    [TestMethod]
    public void HostcpuFeaturesPae()
    {
        const string expected = $@"
{XMLDECL}
<HostcpuFeaturesPae {XMLNS} />
";

        this.AssertXml<HostcpuFeaturesPae>(expected);
    }

    [TestMethod]
    public void HostcpuFeaturesSvm()
    {
        const string expected = $@"
{XMLDECL}
<HostcpuFeaturesSvm {XMLNS} />
";

        this.AssertXml<HostcpuFeaturesSvm>(expected);
    }

    [TestMethod]
    public void HostcpuFeaturesVmx()
    {
        const string expected = $@"
{XMLDECL}
<HostcpuFeaturesVmx {XMLNS} />
";

        this.AssertXml<HostcpuFeaturesVmx>(expected);
    }

    [TestMethod]
    public void HostcpuMicrocode()
    {
        const string expected = $@"
{XMLDECL}
<HostcpuMicrocode {XMLNS} version=""0"" />
";

        this.AssertXml<HostcpuMicrocode>(expected);
    }

    [TestMethod]
    public void HostcpuPages()
    {
        const string expected = $@"
{XMLDECL}
<HostcpuPages {XMLNS} size=""0"" />
";

        this.AssertXml<HostcpuPages>(expected);
    }

    [TestMethod]
    public void HostcpuSignature()
    {
        const string expected = $@"
{XMLDECL}
<HostcpuSignature {XMLNS} family=""0"" model=""0"" stepping=""0"" />
";

        this.AssertXml<HostcpuSignature>(expected);
    }
}
