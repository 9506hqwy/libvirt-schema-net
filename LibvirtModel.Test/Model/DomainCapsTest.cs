namespace LibvirtModel.Test.Model;

[TestClass]
public class DomainCapsTest : TestBase
{
    [TestMethod]
    public void DomainCapabilities()
    {
        const string expected = $@"
{XMLDECL}
<domainCapabilities {XMLNS} />
";

        this.AssertXml<DomainCapabilities>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesAsyncTeardown()
    {
        const string expected = $@"
{XMLDECL}
<async-teardown {XMLNS} supported=""no"" />
";

        this.AssertXml<DomainCapabilitiesAsyncTeardown>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesConsole()
    {
        const string expected = $@"
{XMLDECL}
<console {XMLNS} supported=""no"" />
";

        this.AssertXml<DomainCapabilitiesConsole>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesCpu()
    {
        const string expected = $@"
{XMLDECL}
<cpu {XMLNS} />
";

        this.AssertXml<DomainCapabilitiesCpu>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesCpuCustomBlockers()
    {
        const string expected = $@"
{XMLDECL}
<DomainCapabilitiesCpuCustomBlockers {XMLNS} />
";

        this.AssertXml<DomainCapabilitiesCpuCustomBlockers>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesCpuCustomModelUsable()
    {
        var values = Enum.GetValues(typeof(DomainCapabilitiesCpuCustomModelUsable));
        Assert.HasCount(3, values);
    }

    [TestMethod]
    public void DomainCapabilitiesCpuMode()
    {
        const string expected = $@"
{XMLDECL}
<DomainCapabilitiesCpuMode {XMLNS} name=""custom"" supported=""no"" />
";

        this.AssertXml<DomainCapabilitiesCpuMode>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesCpuModeModel()
    {
        const string expected = $@"
{XMLDECL}
<DomainCapabilitiesCpuModeModel {XMLNS} />
";

        this.AssertXml<DomainCapabilitiesCpuModeModel>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesCpuModeName()
    {
        var values = Enum.GetValues(typeof(DomainCapabilitiesCpuModeName));
        Assert.HasCount(4, values);
    }

    [TestMethod]
    public void DomainCapabilitiesDevices()
    {
        const string expected = $@"
{XMLDECL}
<devices {XMLNS} />
";

        this.AssertXml<DomainCapabilitiesDevices>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesChannel()
    {
        const string expected = $@"
{XMLDECL}
<channel {XMLNS} supported=""no"" />
";

        this.AssertXml<DomainCapabilitiesChannel>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesCrypto()
    {
        const string expected = $@"
{XMLDECL}
<crypto {XMLNS} supported=""no"" />
";

        this.AssertXml<DomainCapabilitiesCrypto>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesDisk()
    {
        const string expected = $@"
{XMLDECL}
<disk {XMLNS} supported=""no"" />
";

        this.AssertXml<DomainCapabilitiesDisk>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesFilesystem()
    {
        const string expected = $@"
{XMLDECL}
<filesystem {XMLNS} supported=""no"" />
";

        this.AssertXml<DomainCapabilitiesFilesystem>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesGraphics()
    {
        const string expected = $@"
{XMLDECL}
<graphics {XMLNS} supported=""no"" />
";

        this.AssertXml<DomainCapabilitiesGraphics>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesHostdev()
    {
        const string expected = $@"
{XMLDECL}
<hostdev {XMLNS} supported=""no"" />
";

        this.AssertXml<DomainCapabilitiesHostdev>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesRedirdev()
    {
        const string expected = $@"
{XMLDECL}
<redirdev {XMLNS} supported=""no"" />
";

        this.AssertXml<DomainCapabilitiesRedirdev>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesRng()
    {
        const string expected = $@"
{XMLDECL}
<rng {XMLNS} supported=""no"" />
";

        this.AssertXml<DomainCapabilitiesRng>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesTdx()
    {
        const string expected = $@"
{XMLDECL}
<tdx {XMLNS} supported=""no"" />
";

        this.AssertXml<DomainCapabilitiesTdx>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesTpm()
    {
        const string expected = $@"
{XMLDECL}
<tpm {XMLNS} supported=""no"" />
";

        this.AssertXml<DomainCapabilitiesTpm>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesVideo()
    {
        const string expected = $@"
{XMLDECL}
<video {XMLNS} supported=""no"" />
";

        this.AssertXml<DomainCapabilitiesVideo>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesFeatures()
    {
        const string expected = $@"
{XMLDECL}
<features {XMLNS} />
";

        this.AssertXml<DomainCapabilitiesFeatures>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesBackingStoreInput()
    {
        const string expected = $@"
{XMLDECL}
<backingStoreInput {XMLNS} supported=""no"" />
";

        this.AssertXml<DomainCapabilitiesBackingStoreInput>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesBackup()
    {
        const string expected = $@"
{XMLDECL}
<backup {XMLNS} supported=""no"" />
";

        this.AssertXml<DomainCapabilitiesBackup>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesGic()
    {
        const string expected = $@"
{XMLDECL}
<gic {XMLNS} supported=""no"" />
";

        this.AssertXml<DomainCapabilitiesGic>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesHyperv()
    {
        const string expected = $@"
{XMLDECL}
<hyperv {XMLNS} supported=""no"" />
";

        this.AssertXml<DomainCapabilitiesHyperv>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesHypervDefaults()
    {
        const string expected = $@"
{XMLDECL}
<DomainCapabilitiesHypervDefaults {XMLNS} />
";

        this.AssertXml<DomainCapabilitiesHypervDefaults>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesS390Pv()
    {
        const string expected = $@"
{XMLDECL}
<s390-pv {XMLNS} supported=""no"" />
";

        this.AssertXml<DomainCapabilitiesS390Pv>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesSev()
    {
        const string expected = $@"
{XMLDECL}
<sev {XMLNS} supported=""no"" />
";

        this.AssertXml<DomainCapabilitiesSev>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesSgx()
    {
        const string expected = $@"
{XMLDECL}
<sgx {XMLNS} supported=""no"" />
";

        this.AssertXml<DomainCapabilitiesSgx>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesSgxSections()
    {
        const string expected = $@"
{XMLDECL}
<DomainCapabilitiesSgxSections {XMLNS} />
";

        this.AssertXml<DomainCapabilitiesSgxSections>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesSgxSectionsSection()
    {
        const string expected = $@"
{XMLDECL}
<DomainCapabilitiesSgxSectionsSection {XMLNS} node=""0"" size=""0"" unit=""KiB"" />
";

        this.AssertXml<DomainCapabilitiesSgxSectionsSection>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesSgxSectionsSectionUnit()
    {
        var values = Enum.GetValues(typeof(DomainCapabilitiesSgxSectionsSectionUnit));
        Assert.HasCount(1, values);
    }

    [TestMethod]
    public void DomainCapabilitiesFeaturesSgxSectionSize()
    {
        const string expected = $@"
{XMLDECL}
<DomainCapabilitiesFeaturesSgxSectionSize {XMLNS} unit=""KiB"" />
";

        this.AssertXml<DomainCapabilitiesFeaturesSgxSectionSize>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesSgxSectionSizeUnit()
    {
        var values = Enum.GetValues(typeof(DomainCapabilitiesSgxSectionSizeUnit));
        Assert.HasCount(1, values);
    }

    [TestMethod]
    public void DomainCapabilitiesVmcoreinfo()
    {
        const string expected = $@"
{XMLDECL}
<vmcoreinfo {XMLNS} supported=""no"" />
";

        this.AssertXml<DomainCapabilitiesVmcoreinfo>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesVmgenid()
    {
        const string expected = $@"
{XMLDECL}
<genid {XMLNS} supported=""no"" />
";

        this.AssertXml<DomainCapabilitiesVmgenid>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesIothreads()
    {
        const string expected = $@"
{XMLDECL}
<iothreads {XMLNS} supported=""no"" />
";

        this.AssertXml<DomainCapabilitiesIothreads>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesInterface()
    {
        const string expected = $@"
{XMLDECL}
<interface {XMLNS} supported=""no"" />
";

        this.AssertXml<DomainCapabilitiesInterface>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesMemoryBacking()
    {
        const string expected = $@"
{XMLDECL}
<memoryBacking {XMLNS} supported=""no"" />
";

        this.AssertXml<DomainCapabilitiesMemoryBacking>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesOsEnum()
    {
        const string expected = $@"
{XMLDECL}
<DomainCapabilitiesOsEnum {XMLNS} />
";

        this.AssertXml<DomainCapabilitiesOsEnum>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesOs()
    {
        const string expected = $@"
{XMLDECL}
<os {XMLNS} supported=""no"" />
";

        this.AssertXml<DomainCapabilitiesOs>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesLaunchSecurity()
    {
        const string expected = $@"
{XMLDECL}
<launchSecurity {XMLNS} supported=""no"" />
";

        this.AssertXml<DomainCapabilitiesLaunchSecurity>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesLoader()
    {
        const string expected = $@"
{XMLDECL}
<loader {XMLNS} supported=""no"" />
";

        this.AssertXml<DomainCapabilitiesLoader>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesPanic()
    {
        const string expected = $@"
{XMLDECL}
<panic {XMLNS} supported=""no"" />
";

        this.AssertXml<DomainCapabilitiesPanic>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesPs2()
    {
        const string expected = $@"
{XMLDECL}
<ps2 {XMLNS} supported=""no"" />
";

        this.AssertXml<DomainCapabilitiesPs2>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesVcpu()
    {
        const string expected = $@"
{XMLDECL}
<vcpu {XMLNS} max=""0"" />
";

        this.AssertXml<DomainCapabilitiesVcpu>(expected);
    }
}
