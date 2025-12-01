namespace LibvirtModel.Test.Model;

[TestClass]
public class CapabilityTest : TestBase
{
    [TestMethod]
    public void Capabilities()
    {
        const string expected = $@"
{XMLDECL}
<capabilities {XMLNS} />
";

        this.AssertXml<Capabilities>(expected);
    }

    [TestMethod]
    public void CapabilitiesArch()
    {
        const string expected = $@"
{XMLDECL}
<arch {XMLNS} name=""aarch64"">
  <wordsize>31</wordsize>
</arch>
";

        this.AssertXml<CapabilitiesArch>(expected);
    }

    [TestMethod]
    public void CapabilitiesCache()
    {
        const string expected = $@"
{XMLDECL}
<cache {XMLNS} />
";

        this.AssertXml<CapabilitiesCache>(expected);
    }

    [TestMethod]
    public void CapabilitiesCacheBank()
    {
        const string expected = $@"
{XMLDECL}
<CapabilitiesCacheBank {XMLNS} id=""0"" level=""0"" type=""both"" size=""0"" />
";

        this.AssertXml<CapabilitiesCacheBank>(expected);
    }

    [TestMethod]
    public void CapabilitiesCacheBankControl()
    {
        const string expected = $@"
{XMLDECL}
<CapabilitiesCacheBankControl {XMLNS} granularity=""0"" type=""both"" maxAllocs=""0"" />
";

        this.AssertXml<CapabilitiesCacheBankControl>(expected);
    }

    [TestMethod]
    public void CapabilitiesCacheType()
    {
        var values = Enum.GetValues(typeof(CapabilitiesCacheType));
        Assert.HasCount(3, values);
    }

    [TestMethod]
    public void CapabilitiesCell()
    {
        const string expected = $@"
{XMLDECL}
<CapabilitiesCell {XMLNS} id=""0"" />
";

        this.AssertXml<CapabilitiesCell>(expected);
    }

    [TestMethod]
    public void CapabilitiesCellCpus()
    {
        const string expected = $@"
{XMLDECL}
<CapabilitiesCellCpus {XMLNS} num=""0"" />
";

        this.AssertXml<CapabilitiesCellCpus>(expected);
    }

    [TestMethod]
    public void CapabilitiesCellDistances()
    {
        const string expected = $@"
{XMLDECL}
<CapabilitiesCellDistances {XMLNS} />
";

        this.AssertXml<CapabilitiesCellDistances>(expected);
    }

    [TestMethod]
    public void CapabilitiesCpu()
    {
        const string expected = $@"
{XMLDECL}
<CapabilitiesCpu {XMLNS} id=""0"" />
";

        this.AssertXml<CapabilitiesCpu>(expected);
    }

    [TestMethod]
    public void CapabilitiesCpuMonitor()
    {
        const string expected = $@"
{XMLDECL}
<CapabilitiesCpuMonitor {XMLNS} maxMonitors=""0"" />
";

        this.AssertXml<CapabilitiesCpuMonitor>(expected);
    }

    [TestMethod]
    public void CapabilitiesCpuMonitorFeature()
    {
        const string expected = $@"
{XMLDECL}
<CapabilitiesCpuMonitorFeature {XMLNS} />
";

        this.AssertXml<CapabilitiesCpuMonitorFeature>(expected);
    }

    [TestMethod]
    public void CapabilitiesDomain()
    {
        const string expected = $@"
{XMLDECL}
<CapabilitiesDomain {XMLNS} type=""bhyve"" />
";

        this.AssertXml<CapabilitiesDomain>(expected);
    }

    [TestMethod]
    public void CapabilitiesFeatures()
    {
        const string expected = $@"
{XMLDECL}
<features {XMLNS} />
";

        this.AssertXml<CapabilitiesFeatures>(expected);
    }

    [TestMethod]
    public void CapabilitiesFeaturesAcpi()
    {
        const string expected = $@"
{XMLDECL}
<CapabilitiesFeaturesAcpi {XMLNS} toggle=""no"" default=""off"" />
";

        this.AssertXml<CapabilitiesFeaturesAcpi>(expected);
    }

    [TestMethod]
    public void CapabilitiesFeaturesApic()
    {
        const string expected = $@"
{XMLDECL}
<CapabilitiesFeaturesApic {XMLNS} toggle=""no"" default=""off"" />
";

        this.AssertXml<CapabilitiesFeaturesApic>(expected);
    }

    [TestMethod]
    public void CapabilitiesFeaturesCpuselection()
    {
        const string expected = $@"
{XMLDECL}
<CapabilitiesFeaturesCpuselection {XMLNS} />
";

        this.AssertXml<CapabilitiesFeaturesCpuselection>(expected);
    }

    [TestMethod]
    public void CapabilitiesFeaturesDeviceboot()
    {
        const string expected = $@"
{XMLDECL}
<CapabilitiesFeaturesDeviceboot {XMLNS} />
";

        this.AssertXml<CapabilitiesFeaturesDeviceboot>(expected);
    }

    [TestMethod]
    public void CapabilitiesFeaturesDisksnapshot()
    {
        const string expected = $@"
{XMLDECL}
<CapabilitiesFeaturesDisksnapshot {XMLNS} toggle=""no"" default=""off"" />
";

        this.AssertXml<CapabilitiesFeaturesDisksnapshot>(expected);
    }

    [TestMethod]
    public void CapabilitiesFeaturesExternalSnapshot()
    {
        const string expected = $@"
{XMLDECL}
<CapabilitiesFeaturesExternalSnapshot {XMLNS} />
";

        this.AssertXml<CapabilitiesFeaturesExternalSnapshot>(expected);
    }

    [TestMethod]
    public void CapabilitiesFeaturesHap()
    {
        const string expected = $@"
{XMLDECL}
<CapabilitiesFeaturesHap {XMLNS} toggle=""no"" default=""off"" />
";

        this.AssertXml<CapabilitiesFeaturesHap>(expected);
    }

    [TestMethod]
    public void CapabilitiesFeaturesIa64Be()
    {
        const string expected = $@"
{XMLDECL}
<CapabilitiesFeaturesIa64Be {XMLNS} />
";

        this.AssertXml<CapabilitiesFeaturesIa64Be>(expected);
    }

    [TestMethod]
    public void CapabilitiesFeaturesNonpae()
    {
        const string expected = $@"
{XMLDECL}
<CapabilitiesFeaturesNonpae {XMLNS} />
";

        this.AssertXml<CapabilitiesFeaturesNonpae>(expected);
    }

    [TestMethod]
    public void CapabilitiesFeaturesPae()
    {
        const string expected = $@"
{XMLDECL}
<CapabilitiesFeaturesPae {XMLNS} />
";

        this.AssertXml<CapabilitiesFeaturesPae>(expected);
    }

    [TestMethod]
    public void CapabilitiesGuestcaps()
    {
        const string expected = $@"
{XMLDECL}
<guest {XMLNS}>
  <os_type>exe</os_type>
</guest>
";

        this.AssertXml<CapabilitiesGuestcaps>(expected);
    }

    [TestMethod]
    public void CapabilitiesGuestcapsArchMachine()
    {
        const string expected = $@"
{XMLDECL}
<CapabilitiesGuestcapsArchMachine {XMLNS} />
";

        this.AssertXml<CapabilitiesGuestcapsArchMachine>(expected);
    }

    [TestMethod]
    public void CapabilitiesHostcaps()
    {
        const string expected = $@"
{XMLDECL}
<host {XMLNS} />
";

        this.AssertXml<CapabilitiesHostcaps>(expected);
    }

    [TestMethod]
    public void CapabilitiesHostcapsSecmodelBaselabel()
    {
        const string expected = $@"
{XMLDECL}
<CapabilitiesHostcapsSecmodelBaselabel {XMLNS} />
";

        this.AssertXml<CapabilitiesHostcapsSecmodelBaselabel>(expected);
    }

    [TestMethod]
    public void CapabilitiesHostcapsTopologyCellsCellMemory()
    {
        const string expected = $@"
{XMLDECL}
<CapabilitiesHostcapsTopologyCellsCellMemory {XMLNS} />
";

        this.AssertXml<CapabilitiesHostcapsTopologyCellsCellMemory>(expected);
    }

    [TestMethod]
    public void CapabilitiesHostcapsTopologyCellsCellPagesNuma()
    {
        const string expected = $@"
{XMLDECL}
<CapabilitiesHostcapsTopologyCellsCellPagesNuma {XMLNS} size=""0"" />
";

        this.AssertXml<CapabilitiesHostcapsTopologyCellsCellPagesNuma>(expected);
    }

    [TestMethod]
    public void CapabilitiesIommuSupport()
    {
        const string expected = $@"
{XMLDECL}
<iommu {XMLNS} />
";

        this.AssertXml<CapabilitiesIommuSupport>(expected);
    }

    [TestMethod]
    public void CapabilitiesMemoryBandwidth()
    {
        const string expected = $@"
{XMLDECL}
<memory_bandwidth {XMLNS} />
";

        this.AssertXml<CapabilitiesMemoryBandwidth>(expected);
    }

    [TestMethod]
    public void CapabilitiesMemoryBandwidthNode()
    {
        const string expected = $@"
{XMLDECL}
<CapabilitiesMemoryBandwidthNode {XMLNS} id=""0"" />
";

        this.AssertXml<CapabilitiesMemoryBandwidthNode>(expected);
    }

    [TestMethod]
    public void CapabilitiesMemoryBandwidthNodeControl()
    {
        const string expected = $@"
{XMLDECL}
<CapabilitiesMemoryBandwidthNodeControl {XMLNS} granularity=""0"" maxAllocs=""0"" />
";

        this.AssertXml<CapabilitiesMemoryBandwidthNodeControl>(expected);
    }

    [TestMethod]
    public void CapabilitiesMigration()
    {
        const string expected = $@"
{XMLDECL}
<migration_features {XMLNS} />
";

        this.AssertXml<CapabilitiesMigration>(expected);
    }

    [TestMethod]
    public void CapabilitiesMigrationLive()
    {
        const string expected = $@"
{XMLDECL}
<CapabilitiesMigrationLive {XMLNS} />
";

        this.AssertXml<CapabilitiesMigrationLive>(expected);
    }

    [TestMethod]
    public void CapabilitiesMigrationUriTransports()
    {
        const string expected = $@"
{XMLDECL}
<CapabilitiesMigrationUriTransports {XMLNS} />
";

        this.AssertXml<CapabilitiesMigrationUriTransports>(expected);
    }

    [TestMethod]
    public void CapabilitiesMigrationUriTransportsUriTransport()
    {
        var values = Enum.GetValues(typeof(CapabilitiesMigrationUriTransportsUriTransport));
        Assert.HasCount(4, values);
    }

    [TestMethod]
    public void CapabilitiesPowerManagement()
    {
        const string expected = $@"
{XMLDECL}
<power_management {XMLNS} />
";

        this.AssertXml<CapabilitiesPowerManagement>(expected);
    }

    [TestMethod]
    public void CapabilitiesPowerManagementSuspendDisk()
    {
        const string expected = $@"
{XMLDECL}
<CapabilitiesPowerManagementSuspendDisk {XMLNS} />
";

        this.AssertXml<CapabilitiesPowerManagementSuspendDisk>(expected);
    }

    [TestMethod]
    public void CapabilitiesPowerManagementSuspendHybrid()
    {
        const string expected = $@"
{XMLDECL}
<CapabilitiesPowerManagementSuspendHybrid {XMLNS} />
";

        this.AssertXml<CapabilitiesPowerManagementSuspendHybrid>(expected);
    }

    [TestMethod]
    public void CapabilitiesPowerManagementSuspendMem()
    {
        const string expected = $@"
{XMLDECL}
<CapabilitiesPowerManagementSuspendMem {XMLNS} />
";

        this.AssertXml<CapabilitiesPowerManagementSuspendMem>(expected);
    }

    [TestMethod]
    public void CapabilitiesSecmodel()
    {
        const string expected = $@"
{XMLDECL}
<secmodel {XMLNS} />
";

        this.AssertXml<CapabilitiesSecmodel>(expected);
    }

    [TestMethod]
    public void CapabilitiesTopology()
    {
        const string expected = $@"
{XMLDECL}
<CapabilitiesTopology {XMLNS} />
";

        this.AssertXml<CapabilitiesTopology>(expected);
    }

    [TestMethod]
    public void CapabilitiesTopologyCells()
    {
        const string expected = $@"
{XMLDECL}
<CapabilitiesTopologyCells {XMLNS} num=""0"" />
";

        this.AssertXml<CapabilitiesTopologyCells>(expected);
    }
}
