namespace LibvirtModel.Test.Model;

[TestClass]
public class DomainTest : TestBase
{
    [TestMethod]
    public void DomainAia()
    {
        const string expected = $@"
{XMLDECL}
<aia {XMLNS} value=""aplic"" />
";

        this.AssertXml<DomainAia>(expected);
    }

    [TestMethod]
    public void DomainAiaValue()
    {
        var values = Enum.GetValues(typeof(DomainAiaValue));
        Assert.HasCount(3, values);
    }

    [TestMethod]
    public void BhyveDomainBhyvecmdline()
    {
        const string expected = $@"
{XMLDECL}
<commandline {XMLNS} />
";

        this.AssertXml<BhyveDomainBhyvecmdline>(expected);
    }

    [TestMethod]
    public void BhyveDomainBhyvecmdlineArg()
    {
        const string expected = $@"
{XMLDECL}
<BhyveDomainBhyvecmdlineArg {XMLNS} />
";

        this.AssertXml<BhyveDomainBhyvecmdlineArg>(expected);
    }

    [TestMethod]
    public void CrashOptions()
    {
        var values = Enum.GetValues(typeof(CrashOptions));
        Assert.HasCount(6, values);
    }

    [TestMethod]
    public void Domain()
    {
        const string expected = $@"
{XMLDECL}
<domain {XMLNS} type=""bhyve"" />
";

        this.AssertXml<Domain>(expected);
    }

    [TestMethod]
    public void DomainAcpi()
    {
        const string expected = $@"
{XMLDECL}
<DomainAcpi {XMLNS} />
";

        this.AssertXml<DomainAcpi>(expected);
    }

    [TestMethod]
    public void DomainAcpiTable()
    {
        const string expected = $@"
{XMLDECL}
<acpi {XMLNS} />
";

        this.AssertXml<DomainAcpiTable>(expected);
    }

    [TestMethod]
    public void DomainAddress()
    {
        const string expected = $@"
{XMLDECL}
<DomainAddress {XMLNS} type=""ccid"" />
";

        this.AssertXml<DomainAddress>(expected);
    }

    [TestMethod]
    public void DomainAddressType()
    {
        var values = Enum.GetValues(typeof(DomainAddressType));
        Assert.HasCount(11, values);
    }

    [TestMethod]
    public void DomainAudio()
    {
        const string expected = $@"
{XMLDECL}
<audio {XMLNS} type=""alsa"" />
";

        this.AssertXml<DomainAudio>(expected);
    }

    [TestMethod]
    public void DomainAudioDriver()
    {
        var values = Enum.GetValues(typeof(DomainAudioDriver));
        Assert.HasCount(4, values);
    }

    [TestMethod]
    public void DomainAudioInput()
    {
        const string expected = $@"
{XMLDECL}
<DomainAudioInput {XMLNS} />
";

        this.AssertXml<DomainAudioInput>(expected);
    }

    [TestMethod]
    public void DomainAudioInputSettings()
    {
        const string expected = $@"
{XMLDECL}
<DomainAudioInputSettings {XMLNS} />
";

        this.AssertXml<DomainAudioInputSettings>(expected);
    }

    [TestMethod]
    public void DomainAudioInputSettingsFormat()
    {
        var values = Enum.GetValues(typeof(DomainAudioInputSettingsFormat));
        Assert.HasCount(7, values);
    }

    [TestMethod]
    public void DomainAudioOutput()
    {
        const string expected = $@"
{XMLDECL}
<DomainAudioOutput {XMLNS} />
";

        this.AssertXml<DomainAudioOutput>(expected);
    }

    [TestMethod]
    public void DomainAudioType()
    {
        var values = Enum.GetValues(typeof(DomainAudioType));
        Assert.HasCount(11, values);
    }

    [TestMethod]
    public void DomainBios()
    {
        const string expected = $@"
{XMLDECL}
<bios {XMLNS} />
";

        this.AssertXml<DomainBios>(expected);
    }

    [TestMethod]
    public void DomainBlkiotune()
    {
        const string expected = $@"
{XMLDECL}
<blkiotune {XMLNS} />
";

        this.AssertXml<DomainBlkiotune>(expected);
    }

    [TestMethod]
    public void DomainBlkiotuneDevice()
    {
        const string expected = $@"
{XMLDECL}
<DomainBlkiotuneDevice {XMLNS} />
";

        this.AssertXml<DomainBlkiotuneDevice>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesAuditControl()
    {
        const string expected = $@"
{XMLDECL}
<DomainCapabilitiesAuditControl {XMLNS} state=""off"" />
";

        this.AssertXml<DomainCapabilitiesAuditControl>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesAuditWrite()
    {
        const string expected = $@"
{XMLDECL}
<DomainCapabilitiesAuditWrite {XMLNS} state=""off"" />
";

        this.AssertXml<DomainCapabilitiesAuditWrite>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesBlockSuspend()
    {
        const string expected = $@"
{XMLDECL}
<DomainCapabilitiesBlockSuspend {XMLNS} state=""off"" />
";

        this.AssertXml<DomainCapabilitiesBlockSuspend>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesChown()
    {
        const string expected = $@"
{XMLDECL}
<DomainCapabilitiesChown {XMLNS} state=""off"" />
";

        this.AssertXml<DomainCapabilitiesChown>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesDacOverride()
    {
        const string expected = $@"
{XMLDECL}
<DomainCapabilitiesDacOverride {XMLNS} state=""off"" />
";

        this.AssertXml<DomainCapabilitiesDacOverride>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesDacReadSearch()
    {
        const string expected = $@"
{XMLDECL}
<DomainCapabilitiesDacReadSearch {XMLNS} state=""off"" />
";

        this.AssertXml<DomainCapabilitiesDacReadSearch>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesFowner()
    {
        const string expected = $@"
{XMLDECL}
<DomainCapabilitiesFowner {XMLNS} state=""off"" />
";

        this.AssertXml<DomainCapabilitiesFowner>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesFsetid()
    {
        const string expected = $@"
{XMLDECL}
<DomainCapabilitiesFsetid {XMLNS} state=""off"" />
";

        this.AssertXml<DomainCapabilitiesFsetid>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesIpcLock()
    {
        const string expected = $@"
{XMLDECL}
<DomainCapabilitiesIpcLock {XMLNS} state=""off"" />
";

        this.AssertXml<DomainCapabilitiesIpcLock>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesIpcOwner()
    {
        const string expected = $@"
{XMLDECL}
<DomainCapabilitiesIpcOwner {XMLNS} state=""off"" />
";

        this.AssertXml<DomainCapabilitiesIpcOwner>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesKill()
    {
        const string expected = $@"
{XMLDECL}
<DomainCapabilitiesKill {XMLNS} state=""off"" />
";

        this.AssertXml<DomainCapabilitiesKill>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesLease()
    {
        const string expected = $@"
{XMLDECL}
<DomainCapabilitiesLease {XMLNS} state=""off"" />
";

        this.AssertXml<DomainCapabilitiesLease>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesLinuxImmutable()
    {
        const string expected = $@"
{XMLDECL}
<DomainCapabilitiesLinuxImmutable {XMLNS} state=""off"" />
";

        this.AssertXml<DomainCapabilitiesLinuxImmutable>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesMacAdmin()
    {
        const string expected = $@"
{XMLDECL}
<DomainCapabilitiesMacAdmin {XMLNS} state=""off"" />
";

        this.AssertXml<DomainCapabilitiesMacAdmin>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesMacOverride()
    {
        const string expected = $@"
{XMLDECL}
<DomainCapabilitiesMacOverride {XMLNS} state=""off"" />
";

        this.AssertXml<DomainCapabilitiesMacOverride>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesMknod()
    {
        const string expected = $@"
{XMLDECL}
<DomainCapabilitiesMknod {XMLNS} state=""off"" />
";

        this.AssertXml<DomainCapabilitiesMknod>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesNetAdmin()
    {
        const string expected = $@"
{XMLDECL}
<DomainCapabilitiesNetAdmin {XMLNS} state=""off"" />
";

        this.AssertXml<DomainCapabilitiesNetAdmin>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesNetBindService()
    {
        const string expected = $@"
{XMLDECL}
<DomainCapabilitiesNetBindService {XMLNS} state=""off"" />
";

        this.AssertXml<DomainCapabilitiesNetBindService>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesNetBroadcast()
    {
        const string expected = $@"
{XMLDECL}
<DomainCapabilitiesNetBroadcast {XMLNS} state=""off"" />
";

        this.AssertXml<DomainCapabilitiesNetBroadcast>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesNetRaw()
    {
        const string expected = $@"
{XMLDECL}
<DomainCapabilitiesNetRaw {XMLNS} state=""off"" />
";

        this.AssertXml<DomainCapabilitiesNetRaw>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiespolicy()
    {
        var values = Enum.GetValues(typeof(DomainCapabilitiespolicy));
        Assert.HasCount(3, values);
    }

    [TestMethod]
    public void DomainCapabilitiesSetfcap()
    {
        const string expected = $@"
{XMLDECL}
<DomainCapabilitiesSetfcap {XMLNS} state=""off"" />
";

        this.AssertXml<DomainCapabilitiesSetfcap>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesSetgid()
    {
        const string expected = $@"
{XMLDECL}
<DomainCapabilitiesSetgid {XMLNS} state=""off"" />
";

        this.AssertXml<DomainCapabilitiesSetgid>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesSetpcap()
    {
        const string expected = $@"
{XMLDECL}
<DomainCapabilitiesSetpcap {XMLNS} state=""off"" />
";

        this.AssertXml<DomainCapabilitiesSetpcap>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesSetuid()
    {
        const string expected = $@"
{XMLDECL}
<DomainCapabilitiesSetuid {XMLNS} state=""off"" />
";

        this.AssertXml<DomainCapabilitiesSetuid>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesSysAdmin()
    {
        const string expected = $@"
{XMLDECL}
<DomainCapabilitiesSysAdmin {XMLNS} state=""off"" />
";

        this.AssertXml<DomainCapabilitiesSysAdmin>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesSysBoot()
    {
        const string expected = $@"
{XMLDECL}
<DomainCapabilitiesSysBoot {XMLNS} state=""off"" />
";

        this.AssertXml<DomainCapabilitiesSysBoot>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesSysChroot()
    {
        const string expected = $@"
{XMLDECL}
<DomainCapabilitiesSysChroot {XMLNS} state=""off"" />
";

        this.AssertXml<DomainCapabilitiesSysChroot>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesSysModule()
    {
        const string expected = $@"
{XMLDECL}
<DomainCapabilitiesSysModule {XMLNS} state=""off"" />
";

        this.AssertXml<DomainCapabilitiesSysModule>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesSysNice()
    {
        const string expected = $@"
{XMLDECL}
<DomainCapabilitiesSysNice {XMLNS} state=""off"" />
";

        this.AssertXml<DomainCapabilitiesSysNice>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesSysPacct()
    {
        const string expected = $@"
{XMLDECL}
<DomainCapabilitiesSysPacct {XMLNS} state=""off"" />
";

        this.AssertXml<DomainCapabilitiesSysPacct>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesSysPtrace()
    {
        const string expected = $@"
{XMLDECL}
<DomainCapabilitiesSysPtrace {XMLNS} state=""off"" />
";

        this.AssertXml<DomainCapabilitiesSysPtrace>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesSysRawio()
    {
        const string expected = $@"
{XMLDECL}
<DomainCapabilitiesSysRawio {XMLNS} state=""off"" />
";

        this.AssertXml<DomainCapabilitiesSysRawio>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesSysResource()
    {
        const string expected = $@"
{XMLDECL}
<DomainCapabilitiesSysResource {XMLNS} state=""off"" />
";

        this.AssertXml<DomainCapabilitiesSysResource>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesSysTime()
    {
        const string expected = $@"
{XMLDECL}
<DomainCapabilitiesSysTime {XMLNS} state=""off"" />
";

        this.AssertXml<DomainCapabilitiesSysTime>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesSysTtyConfig()
    {
        const string expected = $@"
{XMLDECL}
<DomainCapabilitiesSysTtyConfig {XMLNS} state=""off"" />
";

        this.AssertXml<DomainCapabilitiesSysTtyConfig>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesSyslog()
    {
        const string expected = $@"
{XMLDECL}
<DomainCapabilitiesSyslog {XMLNS} state=""off"" />
";

        this.AssertXml<DomainCapabilitiesSyslog>(expected);
    }

    [TestMethod]
    public void DomainCapabilitiesWakeAlarm()
    {
        const string expected = $@"
{XMLDECL}
<DomainCapabilitiesWakeAlarm {XMLNS} state=""off"" />
";

        this.AssertXml<DomainCapabilitiesWakeAlarm>(expected);
    }

    [TestMethod]
    public void DomainCfpc()
    {
        const string expected = $@"
{XMLDECL}
<cfpc {XMLNS} value=""broken"" />
";

        this.AssertXml<DomainCfpc>(expected);
    }

    [TestMethod]
    public void DomainCfpcValue()
    {
        var values = Enum.GetValues(typeof(DomainCfpcValue));
        Assert.HasCount(3, values);
    }

    [TestMethod]
    public void DomainChannel()
    {
        const string expected = $@"
{XMLDECL}
<channel {XMLNS} type=""dbus"" />
";

        this.AssertXml<DomainChannel>(expected);
    }

    [TestMethod]
    public void DomainChannelTarget()
    {
        const string expected = $@"
{XMLDECL}
<DomainChannelTarget {XMLNS} type=""guestfwd"" />
";

        this.AssertXml<DomainChannelTarget>(expected);
    }

    [TestMethod]
    public void DomainChannelTargetType()
    {
        var values = Enum.GetValues(typeof(DomainChannelTargetType));
        Assert.HasCount(3, values);
    }

    [TestMethod]
    public void DomainClipboard()
    {
        const string expected = $@"
{XMLDECL}
<DomainClipboard {XMLNS} copypaste=""no"" />
";

        this.AssertXml<DomainClipboard>(expected);
    }

    [TestMethod]
    public void DomainClock()
    {
        const string expected = $@"
{XMLDECL}
<DomainClock {XMLNS} offset=""absolute"" />
";

        this.AssertXml<DomainClock>(expected);
    }

    [TestMethod]
    public void DomainClockBasis()
    {
        var values = Enum.GetValues(typeof(DomainClockBasis));
        Assert.HasCount(2, values);
    }

    [TestMethod]
    public void DomainClockOffset()
    {
        var values = Enum.GetValues(typeof(DomainClockOffset));
        Assert.HasCount(5, values);
    }

    [TestMethod]
    public void DomainCoalesce()
    {
        const string expected = $@"
{XMLDECL}
<DomainCoalesce {XMLNS} />
";

        this.AssertXml<DomainCoalesce>(expected);
    }

    [TestMethod]
    public void DomainCoalesceRx()
    {
        const string expected = $@"
{XMLDECL}
<DomainCoalesceRx {XMLNS} />
";

        this.AssertXml<DomainCoalesceRx>(expected);
    }

    [TestMethod]
    public void DomainCoalesceRxFrames()
    {
        const string expected = $@"
{XMLDECL}
<DomainCoalesceRxFrames {XMLNS} />
";

        this.AssertXml<DomainCoalesceRxFrames>(expected);
    }

    [TestMethod]
    public void DomainCodec()
    {
        const string expected = $@"
{XMLDECL}
<DomainCodec {XMLNS} type=""duplex"" />
";

        this.AssertXml<DomainCodec>(expected);
    }

    [TestMethod]
    public void DomainCodecType()
    {
        var values = Enum.GetValues(typeof(DomainCodecType));
        Assert.HasCount(3, values);
    }

    [TestMethod]
    public void DomainController()
    {
        const string expected = $@"
{XMLDECL}
<controller {XMLNS} type=""ccid"" />
";

        this.AssertXml<DomainController>(expected);
    }

    [TestMethod]
    public void DomainControllerDriver()
    {
        const string expected = $@"
{XMLDECL}
<DomainControllerDriver {XMLNS} />
";

        this.AssertXml<DomainControllerDriver>(expected);
    }

    [TestMethod]
    public void DomainControllerModel()
    {
        const string expected = $@"
{XMLDECL}
<DomainControllerModel {XMLNS} name=""i82801b11-bridge"" />
";

        this.AssertXml<DomainControllerModel>(expected);
    }

    [TestMethod]
    public void DomainControllerModelAttr()
    {
        var values = Enum.GetValues(typeof(DomainControllerModelAttr));
        Assert.HasCount(41, values);
    }

    [TestMethod]
    public void DomainControllerModelName()
    {
        var values = Enum.GetValues(typeof(DomainControllerModelName));
        Assert.HasCount(10, values);
    }

    [TestMethod]
    public void DomainConsole()
    {
        const string expected = $@"
{XMLDECL}
<console {XMLNS} />
";

        this.AssertXml<DomainConsole>(expected);
    }

    [TestMethod]
    public void DomainControllerTarget()
    {
        const string expected = $@"
{XMLDECL}
<DomainControllerTarget {XMLNS} />
";

        this.AssertXml<DomainControllerTarget>(expected);
    }

    [TestMethod]
    public void DomainControllerType()
    {
        var values = Enum.GetValues(typeof(DomainControllerType));
        Assert.HasCount(11, values);
    }

    [TestMethod]
    public void DomainCurrentMemory()
    {
        const string expected = $@"
{XMLDECL}
<DomainCurrentMemory {XMLNS} />
";

        this.AssertXml<DomainCurrentMemory>(expected);
    }

    [TestMethod]
    public void DomainCputune()
    {
        const string expected = $@"
{XMLDECL}
<cputune {XMLNS} />
";

        this.AssertXml<DomainCputune>(expected);
    }

    [TestMethod]
    public void DomainCputuneCachetune()
    {
        const string expected = $@"
{XMLDECL}
<DomainCputuneCachetune {XMLNS} />
";

        this.AssertXml<DomainCputuneCachetune>(expected);
    }

    [TestMethod]
    public void DomainCputuneCachetuneCache()
    {
        const string expected = $@"
{XMLDECL}
<DomainCputuneCachetuneCache {XMLNS} id=""0"" level=""0"" type=""both"" size=""0"" />
";

        this.AssertXml<DomainCputuneCachetuneCache>(expected);
    }

    [TestMethod]
    public void DomainCputuneCachetuneCacheType()
    {
        var values = Enum.GetValues(typeof(DomainCputuneCachetuneCacheType));
        Assert.HasCount(3, values);
    }

    [TestMethod]
    public void DomainCputuneCachetuneMonitor()
    {
        const string expected = $@"
{XMLDECL}
<DomainCputuneCachetuneMonitor {XMLNS} level=""0"" />
";

        this.AssertXml<DomainCputuneCachetuneMonitor>(expected);
    }

    [TestMethod]
    public void DomainCputuneEmulatorpin()
    {
        const string expected = $@"
{XMLDECL}
<DomainCputuneEmulatorpin {XMLNS} />
";

        this.AssertXml<DomainCputuneEmulatorpin>(expected);
    }

    [TestMethod]
    public void DomainCputuneEmulatorsched()
    {
        const string expected = $@"
{XMLDECL}
<DomainCputuneEmulatorsched {XMLNS} scheduler=""batch"" />
";

        this.AssertXml<DomainCputuneEmulatorsched>(expected);
    }

    [TestMethod]
    public void DomainCputuneEmulatorschedScheduler()
    {
        var values = Enum.GetValues(typeof(DomainCputuneEmulatorschedScheduler));
        Assert.HasCount(4, values);
    }

    [TestMethod]
    public void DomainCputuneIothreadpin()
    {
        const string expected = $@"
{XMLDECL}
<DomainCputuneIothreadpin {XMLNS} iothread=""0"" />
";

        this.AssertXml<DomainCputuneIothreadpin>(expected);
    }

    [TestMethod]
    public void DomainCputuneIothreadsched()
    {
        const string expected = $@"
{XMLDECL}
<DomainCputuneIothreadsched {XMLNS} scheduler=""batch"" />
";

        this.AssertXml<DomainCputuneIothreadsched>(expected);
    }

    [TestMethod]
    public void DomainCputuneIothreadschedScheduler()
    {
        var values = Enum.GetValues(typeof(DomainCputuneIothreadschedScheduler));
        Assert.HasCount(4, values);
    }

    [TestMethod]
    public void DomainCputuneMemorytune()
    {
        const string expected = $@"
{XMLDECL}
<DomainCputuneMemorytune {XMLNS} />
";

        this.AssertXml<DomainCputuneMemorytune>(expected);
    }

    [TestMethod]
    public void DomainCputuneMemorytuneMonitor()
    {
        const string expected = $@"
{XMLDECL}
<DomainCputuneMemorytuneMonitor {XMLNS} />
";

        this.AssertXml<DomainCputuneMemorytuneMonitor>(expected);
    }

    [TestMethod]
    public void DomainCputuneMemorytuneNode()
    {
        const string expected = $@"
{XMLDECL}
<DomainCputuneMemorytuneNode {XMLNS} id=""0"" bandwidth=""0"" />
";

        this.AssertXml<DomainCputuneMemorytuneNode>(expected);
    }

    [TestMethod]
    public void DomainCputuneVcpupin()
    {
        const string expected = $@"
{XMLDECL}
<DomainCputuneVcpupin {XMLNS} vcpu=""0"" />
";

        this.AssertXml<DomainCputuneVcpupin>(expected);
    }

    [TestMethod]
    public void DomainCputuneVcpusched()
    {
        const string expected = $@"
{XMLDECL}
<DomainCputuneVcpusched {XMLNS} scheduler=""batch"" />
";

        this.AssertXml<DomainCputuneVcpusched>(expected);
    }

    [TestMethod]
    public void DomainCputuneVcpuschedScheduler()
    {
        var values = Enum.GetValues(typeof(DomainCputuneVcpuschedScheduler));
        Assert.HasCount(4, values);
    }

    [TestMethod]
    public void DomainCrypto()
    {
        const string expected = $@"
{XMLDECL}
<crypto {XMLNS} model=""virtio"" type=""qemu"" />
";

        this.AssertXml<DomainCrypto>(expected);
    }

    [TestMethod]
    public void DomainCryptoBackend()
    {
        const string expected = $@"
{XMLDECL}
<DomainCryptoBackend {XMLNS} model=""builtin"" />
";

        this.AssertXml<DomainCryptoBackend>(expected);
    }

    [TestMethod]
    public void DomainCryptoBackendModel()
    {
        var values = Enum.GetValues(typeof(DomainCryptoBackendModel));
        Assert.HasCount(2, values);
    }

    [TestMethod]
    public void DomainCryptoDriver()
    {
        const string expected = $@"
{XMLDECL}
<DomainCryptoDriver {XMLNS} />
";

        this.AssertXml<DomainCryptoDriver>(expected);
    }

    [TestMethod]
    public void DomainDefaultiothread()
    {
        const string expected = $@"
{XMLDECL}
<DomainDefaultiothread {XMLNS} />
";

        this.AssertXml<DomainDefaultiothread>(expected);
    }

    [TestMethod]
    public void DomainDeviceBoot()
    {
        const string expected = $@"
{XMLDECL}
<DomainDeviceBoot {XMLNS} order=""0"" />
";

        this.AssertXml<DomainDeviceBoot>(expected);
    }

    [TestMethod]
    public void DomainDevices()
    {
        const string expected = $@"
{XMLDECL}
<devices {XMLNS} />
";

        this.AssertXml<DomainDevices>(expected);
    }

    [TestMethod]
    public void DomainDevicesControllerPcihole64()
    {
        const string expected = $@"
{XMLDECL}
<DomainDevicesControllerPcihole64 {XMLNS} />
";

        this.AssertXml<DomainDevicesControllerPcihole64>(expected);
    }

    [TestMethod]
    public void DomainDevicesDiskDiskDriverMetadataCacheMaxSize()
    {
        const string expected = $@"
{XMLDECL}
<DomainDevicesDiskDiskDriverMetadataCacheMaxSize {XMLNS} />
";

        this.AssertXml<DomainDevicesDiskDiskDriverMetadataCacheMaxSize>(expected);
    }

    [TestMethod]
    public void DomainDevicesDiskDiskMirrorDiskFormatMetadataCacheMaxSize()
    {
        const string expected = $@"
{XMLDECL}
<DomainDevicesDiskDiskMirrorDiskFormatMetadataCacheMaxSize {XMLNS} />
";

        this.AssertXml<DomainDevicesDiskDiskMirrorDiskFormatMetadataCacheMaxSize>(expected);
    }

    [TestMethod]
    public void DomainDevicesFilesystemSpaceHardLimit()
    {
        const string expected = $@"
{XMLDECL}
<DomainDevicesFilesystemSpaceHardLimit {XMLNS} />
";

        this.AssertXml<DomainDevicesFilesystemSpaceHardLimit>(expected);
    }

    [TestMethod]
    public void DomainDevicesFilesystemSpaceSoftLimit()
    {
        const string expected = $@"
{XMLDECL}
<DomainDevicesFilesystemSpaceSoftLimit {XMLNS} />
";

        this.AssertXml<DomainDevicesFilesystemSpaceSoftLimit>(expected);
    }

    [TestMethod]
    public void DomainDevicesMemorydevMemorydevSourceAlignsize()
    {
        const string expected = $@"
{XMLDECL}
<DomainDevicesMemorydevMemorydevSourceAlignsize {XMLNS} />
";

        this.AssertXml<DomainDevicesMemorydevMemorydevSourceAlignsize>(expected);
    }

    [TestMethod]
    public void DomainDevicesMemorydevMemorydevSourcePagesize()
    {
        const string expected = $@"
{XMLDECL}
<DomainDevicesMemorydevMemorydevSourcePagesize {XMLNS} />
";

        this.AssertXml<DomainDevicesMemorydevMemorydevSourcePagesize>(expected);
    }

    [TestMethod]
    public void DomainDevicesMemorydevMemorydevTargetBlock()
    {
        const string expected = $@"
{XMLDECL}
<DomainDevicesMemorydevMemorydevTargetBlock {XMLNS} />
";

        this.AssertXml<DomainDevicesMemorydevMemorydevTargetBlock>(expected);
    }

    [TestMethod]
    public void DomainDevicesMemorydevMemorydevTargetCurrent()
    {
        const string expected = $@"
{XMLDECL}
<DomainDevicesMemorydevMemorydevTargetCurrent {XMLNS} />
";

        this.AssertXml<DomainDevicesMemorydevMemorydevTargetCurrent>(expected);
    }

    [TestMethod]
    public void DomainDevicesMemorydevMemorydevTargetLabelSize()
    {
        const string expected = $@"
{XMLDECL}
<DomainDevicesMemorydevMemorydevTargetLabelSize {XMLNS} />
";

        this.AssertXml<DomainDevicesMemorydevMemorydevTargetLabelSize>(expected);
    }

    [TestMethod]
    public void DomainDevicesMemorydevMemorydevTargetRequested()
    {
        const string expected = $@"
{XMLDECL}
<DomainDevicesMemorydevMemorydevTargetRequested {XMLNS} />
";

        this.AssertXml<DomainDevicesMemorydevMemorydevTargetRequested>(expected);
    }

    [TestMethod]
    public void DomainDevicesMemorydevMemorydevTargetSize()
    {
        const string expected = $@"
{XMLDECL}
<DomainDevicesMemorydevMemorydevTargetSize {XMLNS} />
";

        this.AssertXml<DomainDevicesMemorydevMemorydevTargetSize>(expected);
    }

    [TestMethod]
    public void DomainDevicesRngRngBackend()
    {
        const string expected = $@"
{XMLDECL}
<DomainDevicesRngRngBackend {XMLNS} model=""builtin"" />
";

        this.AssertXml<DomainDevicesRngRngBackend>(expected);
    }

    [TestMethod]
    public void DomainDevicesRngRngBackendModel()
    {
        var values = Enum.GetValues(typeof(DomainDevicesRngRngBackendModel));
        Assert.HasCount(3, values);
    }

    [TestMethod]
    public void DomainDevicesShmemSize()
    {
        const string expected = $@"
{XMLDECL}
<DomainDevicesShmemSize {XMLNS} />
";

        this.AssertXml<DomainDevicesShmemSize>(expected);
    }

    [TestMethod]
    public void DomainDevSeclabel()
    {
        const string expected = $@"
{XMLDECL}
<DomainDevSeclabel {XMLNS} />
";

        this.AssertXml<DomainDevSeclabel>(expected);
    }

    [TestMethod]
    public void DomainDevSeclabelLabelskip()
    {
        var values = Enum.GetValues(typeof(DomainDevSeclabelLabelskip));
        Assert.HasCount(1, values);
    }

    [TestMethod]
    public void DomainDetectZeroes()
    {
        var values = Enum.GetValues(typeof(DomainDetectZeroes));
        Assert.HasCount(3, values);
    }

    [TestMethod]
    public void DomainDiscard()
    {
        var values = Enum.GetValues(typeof(DomainDiscard));
        Assert.HasCount(2, values);
    }

    [TestMethod]
    public void DomainDevSeclabelRelabel()
    {
        var values = Enum.GetValues(typeof(DomainDevSeclabelRelabel));
        Assert.HasCount(2, values);
    }

    [TestMethod]
    public void DomainDisk()
    {
        const string expected = $@"
{XMLDECL}
<disk {XMLNS} />
";

        this.AssertXml<DomainDisk>(expected);
    }

    [TestMethod]
    public void DomainDiskAuth()
    {
        const string expected = $@"
{XMLDECL}
<DomainDiskAuth {XMLNS} />
";

        this.AssertXml<DomainDiskAuth>(expected);
    }

    [TestMethod]
    public void DomainDiskAuthSecret()
    {
        const string expected = $@"
{XMLDECL}
<DomainDiskAuthSecret {XMLNS} type=""ceph"" />
";

        this.AssertXml<DomainDiskAuthSecret>(expected);
    }

    [TestMethod]
    public void DomainDiskAuthSecretType()
    {
        var values = Enum.GetValues(typeof(DomainDiskAuthSecretType));
        Assert.HasCount(2, values);
    }

    [TestMethod]
    public void DomainDiskBackenddomain()
    {
        const string expected = $@"
{XMLDECL}
<DomainDiskBackenddomain {XMLNS} />
";

        this.AssertXml<DomainDiskBackenddomain>(expected);
    }

    [TestMethod]
    public void DomainDiskBackingStore()
    {
        const string expected = $@"
{XMLDECL}
<DomainDiskBackingStore {XMLNS} />
";

        this.AssertXml<DomainDiskBackingStore>(expected);
    }

    [TestMethod]
    public void DomainDiskBackingStoreSource()
    {
        const string expected = $@"
{XMLDECL}
<DomainDiskBackingStoreSource {XMLNS} />
";

        this.AssertXml<DomainDiskBackingStoreSource>(expected);
    }

    [TestMethod]
    public void DomainDiskBackingStoreSourceIdentity()
    {
        const string expected = $@"
{XMLDECL}
<DomainDiskBackingStoreSourceIdentity {XMLNS} />
";

        this.AssertXml<DomainDiskBackingStoreSourceIdentity>(expected);
    }

    [TestMethod]
    public void DomainDiskBackingStoreType()
    {
        var values = Enum.GetValues(typeof(DomainDiskBackingStoreType));
        Assert.HasCount(8, values);
    }

    [TestMethod]
    public void DomainDiskBlockIo()
    {
        const string expected = $@"
{XMLDECL}
<DomainDiskBlockIo {XMLNS} />
";

        this.AssertXml<DomainDiskBlockIo>(expected);
    }

    [TestMethod]
    public void DomainDiskDevice()
    {
        var values = Enum.GetValues(typeof(DomainDiskDevice));
        Assert.HasCount(4, values);
    }

    [TestMethod]
    public void DomainDiskDriver()
    {
        const string expected = $@"
{XMLDECL}
<DomainDiskDriver {XMLNS} />
";

        this.AssertXml<DomainDiskDriver>(expected);
    }

    [TestMethod]
    public void DomainDiskDriverMetadataCache()
    {
        const string expected = $@"
{XMLDECL}
<DomainDiskDriverMetadataCache {XMLNS} />
";

        this.AssertXml<DomainDiskDriverMetadataCache>(expected);
    }

    [TestMethod]
    public void DomainDiskDriverType()
    {
        var values = Enum.GetValues(typeof(DomainDiskDriverType));
        Assert.HasCount(18, values);
    }

    [TestMethod]
    public void DomainDiskFormat()
    {
        const string expected = $@"
{XMLDECL}
<DomainDiskFormat {XMLNS} type=""bochs"" />
";

        this.AssertXml<DomainDiskFormat>(expected);
    }

    [TestMethod]
    public void DomainDiskFormatMetadataCache()
    {
        const string expected = $@"
{XMLDECL}
<DomainDiskFormatMetadataCache {XMLNS} />
";

        this.AssertXml<DomainDiskFormatMetadataCache>(expected);
    }

    [TestMethod]
    public void DomainDiskIoTune()
    {
        const string expected = $@"
{XMLDECL}
<DomainDiskIoTune {XMLNS} />
";

        this.AssertXml<DomainDiskIoTune>(expected);
    }

    [TestMethod]
    public void DomainDiskMirror()
    {
        const string expected = $@"
{XMLDECL}
<DomainDiskMirror {XMLNS} />
";

        this.AssertXml<DomainDiskMirror>(expected);
    }

    [TestMethod]
    public void DomainDiskMirrorBackingStore()
    {
        const string expected = $@"
{XMLDECL}
<DomainDiskMirrorBackingStore {XMLNS} />
";

        this.AssertXml<DomainDiskMirrorBackingStore>(expected);
    }

    [TestMethod]
    public void DomainDiskMirrorBackingStoreSource()
    {
        const string expected = $@"
{XMLDECL}
<DomainDiskMirrorBackingStoreSource {XMLNS} />
";

        this.AssertXml<DomainDiskMirrorBackingStoreSource>(expected);
    }

    [TestMethod]
    public void DomainDiskMirrorBackingStoreSourceIdentity()
    {
        const string expected = $@"
{XMLDECL}
<DomainDiskMirrorBackingStoreSourceIdentity {XMLNS} />
";

        this.AssertXml<DomainDiskMirrorBackingStoreSourceIdentity>(expected);
    }

    [TestMethod]
    public void DomainDiskMirrorJob()
    {
        var values = Enum.GetValues(typeof(DomainDiskMirrorJob));
        Assert.HasCount(2, values);
    }

    [TestMethod]
    public void DomainDiskMirrorReady()
    {
        var values = Enum.GetValues(typeof(DomainDiskMirrorReady));
        Assert.HasCount(3, values);
    }

    [TestMethod]
    public void DomainDiskMirrorSource()
    {
        const string expected = $@"
{XMLDECL}
<DomainDiskMirrorSource {XMLNS} />
";

        this.AssertXml<DomainDiskMirrorSource>(expected);
    }

    [TestMethod]
    public void DomainDiskMirrorSourceIdentity()
    {
        const string expected = $@"
{XMLDECL}
<DomainDiskMirrorSourceIdentity {XMLNS} />
";

        this.AssertXml<DomainDiskMirrorSourceIdentity>(expected);
    }

    [TestMethod]
    public void DomainDiskModel()
    {
        var values = Enum.GetValues(typeof(DomainDiskModel));
        Assert.HasCount(5, values);
    }

    [TestMethod]
    public void DomainDiskReadonly()
    {
        const string expected = $@"
{XMLDECL}
<DomainDiskReadonly {XMLNS} />
";

        this.AssertXml<DomainDiskReadonly>(expected);
    }

    [TestMethod]
    public void DomainDiskShareable()
    {
        const string expected = $@"
{XMLDECL}
<DomainDiskShareable {XMLNS} />
";

        this.AssertXml<DomainDiskShareable>(expected);
    }

    [TestMethod]
    public void DomainDiskSource()
    {
        const string expected = $@"
{XMLDECL}
<DomainDiskSource {XMLNS} />
";

        this.AssertXml<DomainDiskSource>(expected);
    }

    [TestMethod]
    public void DomainDiskSourceIdentity()
    {
        const string expected = $@"
{XMLDECL}
<DomainDiskSourceIdentity {XMLNS} />
";

        this.AssertXml<DomainDiskSourceIdentity>(expected);
    }

    [TestMethod]
    public void DomainDiskSourceNetworkHost()
    {
        const string expected = $@"
{XMLDECL}
<DomainDiskSourceNetworkHost {XMLNS} />
";

        this.AssertXml<DomainDiskSourceNetworkHost>(expected);
    }

    [TestMethod]
    public void DomainDiskSourceNetworkHostTransport()
    {
        var values = Enum.GetValues(typeof(DomainDiskSourceNetworkHostTransport));
        Assert.HasCount(3, values);
    }

    [TestMethod]
    public void DomainDiskSourceNetworkProtocolHttpcookies()
    {
        const string expected = $@"
{XMLDECL}
<DomainDiskSourceNetworkProtocolHttpcookies {XMLNS} />
";

        this.AssertXml<DomainDiskSourceNetworkProtocolHttpcookies>(expected);
    }

    [TestMethod]
    public void DomainOsNvramDiskSourceNetworkProtocolHttpDiskSourceNetworkProtocolHttpcookiesCookie()
    {
        const string expected = $@"
{XMLDECL}
<DomainOsNvramDiskSourceNetworkProtocolHttpDiskSourceNetworkProtocolHttpcookiesCookie {XMLNS} />
";

        this.AssertXml<DomainOsNvramDiskSourceNetworkProtocolHttpDiskSourceNetworkProtocolHttpcookiesCookie>(expected);
    }

    [TestMethod]
    public void DomainDiskSourceNetworkProtocolHttpReadahead()
    {
        const string expected = $@"
{XMLDECL}
<DomainDiskSourceNetworkProtocolHttpReadahead {XMLNS} size=""0"" />
";

        this.AssertXml<DomainDiskSourceNetworkProtocolHttpReadahead>(expected);
    }

    [TestMethod]
    public void DomainDiskSourceNetworkProtocolHttpTimeout()
    {
        const string expected = $@"
{XMLDECL}
<DomainDiskSourceNetworkProtocolHttpTimeout {XMLNS} seconds=""0"" />
";

        this.AssertXml<DomainDiskSourceNetworkProtocolHttpTimeout>(expected);
    }

    [TestMethod]
    public void DomainDiskSourceNetworkProtocolRbdConfig()
    {
        const string expected = $@"
{XMLDECL}
<DomainDiskSourceNetworkProtocolRbdConfig {XMLNS} />
";

        this.AssertXml<DomainDiskSourceNetworkProtocolRbdConfig>(expected);
    }

    [TestMethod]
    public void DomainDiskSourceNetworkProtocolRbdSnapshot()
    {
        const string expected = $@"
{XMLDECL}
<DomainDiskSourceNetworkProtocolRbdSnapshot {XMLNS} />
";

        this.AssertXml<DomainDiskSourceNetworkProtocolRbdSnapshot>(expected);
    }

    [TestMethod]
    public void DomainDiskSourceNetworkProtocolSslverify()
    {
        const string expected = $@"
{XMLDECL}
<DomainDiskSourceNetworkProtocolSslverify {XMLNS} verify=""no"" />
";

        this.AssertXml<DomainDiskSourceNetworkProtocolSslverify>(expected);
    }

    [TestMethod]
    public void DomainDiskSourceNetworkProtocolSshhostVerify()
    {
        const string expected = $@"
{XMLDECL}
<DomainDiskSourceNetworkProtocolSshhostVerify {XMLNS} />
";

        this.AssertXml<DomainDiskSourceNetworkProtocolSshhostVerify>(expected);
    }

    [TestMethod]
    public void DomainDiskSourceType()
    {
        var values = Enum.GetValues(typeof(DomainDiskSourceType));
        Assert.HasCount(2, values);
    }

    [TestMethod]
    public void DomainDiskTarget()
    {
        const string expected = $@"
{XMLDECL}
<DomainDiskTarget {XMLNS} />
";

        this.AssertXml<DomainDiskTarget>(expected);
    }

    [TestMethod]
    public void DomainDiskTargetBus()
    {
        var values = Enum.GetValues(typeof(DomainDiskTargetBus));
        Assert.HasCount(10, values);
    }

    [TestMethod]
    public void DomainDiskTargetTray()
    {
        var values = Enum.GetValues(typeof(DomainDiskTargetTray));
        Assert.HasCount(2, values);
    }

    [TestMethod]
    public void DomainDiskTransient()
    {
        const string expected = $@"
{XMLDECL}
<DomainDiskTransient {XMLNS} />
";

        this.AssertXml<DomainDiskTransient>(expected);
    }

    [TestMethod]
    public void DomainDiskType()
    {
        var values = Enum.GetValues(typeof(DomainDiskType));
        Assert.HasCount(8, values);
    }

    [TestMethod]
    public void DomainDriverCache()
    {
        var values = Enum.GetValues(typeof(DomainDriverCache));
        Assert.HasCount(6, values);
    }

    [TestMethod]
    public void DomainDriverErrorPolicy()
    {
        var values = Enum.GetValues(typeof(DomainDriverErrorPolicy));
        Assert.HasCount(4, values);
    }

    [TestMethod]
    public void DomainDriverIo()
    {
        var values = Enum.GetValues(typeof(DomainDriverIo));
        Assert.HasCount(3, values);
    }

    [TestMethod]
    public void DomainDriverRerrorPolicy()
    {
        var values = Enum.GetValues(typeof(DomainDriverRerrorPolicy));
        Assert.HasCount(3, values);
    }

    [TestMethod]
    public void DomainFeatures()
    {
        const string expected = $@"
{XMLDECL}
<DomainFeatures {XMLNS} />
";

        this.AssertXml<DomainFeatures>(expected);
    }

    [TestMethod]
    public void DomainFeaturesAcpi()
    {
        const string expected = $@"
{XMLDECL}
<DomainFeaturesAcpi {XMLNS} />
";

        this.AssertXml<DomainFeaturesAcpi>(expected);
    }

    [TestMethod]
    public void DomainFeaturesApic()
    {
        const string expected = $@"
{XMLDECL}
<DomainFeaturesApic {XMLNS} />
";

        this.AssertXml<DomainFeaturesApic>(expected);
    }

    [TestMethod]
    public void DomainFeaturesAsyncTeardown()
    {
        const string expected = $@"
{XMLDECL}
<DomainFeaturesAsyncTeardown {XMLNS} />
";

        this.AssertXml<DomainFeaturesAsyncTeardown>(expected);
    }

    [TestMethod]
    public void DomainFeaturesCapabilities()
    {
        const string expected = $@"
{XMLDECL}
<capabilities {XMLNS} policy=""allow"" />
";

        this.AssertXml<DomainFeaturesCapabilities>(expected);
    }

    [TestMethod]
    public void DomainFeaturesCcfAssist()
    {
        const string expected = $@"
{XMLDECL}
<DomainFeaturesCcfAssist {XMLNS} state=""off"" />
";

        this.AssertXml<DomainFeaturesCcfAssist>(expected);
    }

    [TestMethod]
    public void DomainFeaturesGic()
    {
        const string expected = $@"
{XMLDECL}
<DomainFeaturesGic {XMLNS} />
";

        this.AssertXml<DomainFeaturesGic>(expected);
    }

    [TestMethod]
    public void DomainFeaturesGicVersion()
    {
        var values = Enum.GetValues(typeof(DomainFeaturesGicVersion));
        Assert.HasCount(3, values);
    }

    [TestMethod]
    public void DomainFeaturesHap()
    {
        const string expected = $@"
{XMLDECL}
<DomainFeaturesHap {XMLNS} />
";

        this.AssertXml<DomainFeaturesHap>(expected);
    }

    [TestMethod]
    public void DomainFeaturesHtm()
    {
        const string expected = $@"
{XMLDECL}
<DomainFeaturesHtm {XMLNS} state=""off"" />
";

        this.AssertXml<DomainFeaturesHtm>(expected);
    }

    [TestMethod]
    public void DomainFeaturesHptMaxpagesize()
    {
        const string expected = $@"
{XMLDECL}
<DomainFeaturesHptMaxpagesize {XMLNS} />
";

        this.AssertXml<DomainFeaturesHptMaxpagesize>(expected);
    }

    [TestMethod]
    public void DomainFeaturesNestedHv()
    {
        const string expected = $@"
{XMLDECL}
<DomainFeaturesNestedHv {XMLNS} state=""off"" />
";

        this.AssertXml<DomainFeaturesNestedHv>(expected);
    }

    [TestMethod]
    public void DomainFeaturesPae()
    {
        const string expected = $@"
{XMLDECL}
<DomainFeaturesPae {XMLNS} />
";

        this.AssertXml<DomainFeaturesPae>(expected);
    }

    [TestMethod]
    public void DomainFeaturesPs2()
    {
        const string expected = $@"
{XMLDECL}
<DomainFeaturesPs2 {XMLNS} state=""off"" />
";

        this.AssertXml<DomainFeaturesPs2>(expected);
    }

    [TestMethod]
    public void DomainFeaturesPrivnet()
    {
        const string expected = $@"
{XMLDECL}
<DomainFeaturesPrivnet {XMLNS} />
";

        this.AssertXml<DomainFeaturesPrivnet>(expected);
    }

    [TestMethod]
    public void DomainFeaturesPvspinlock()
    {
        const string expected = $@"
{XMLDECL}
<DomainFeaturesPvspinlock {XMLNS} />
";

        this.AssertXml<DomainFeaturesPvspinlock>(expected);
    }

    [TestMethod]
    public void DomainFeaturesRas()
    {
        const string expected = $@"
{XMLDECL}
<DomainFeaturesRas {XMLNS} state=""off"" />
";

        this.AssertXml<DomainFeaturesRas>(expected);
    }

    [TestMethod]
    public void DomainFeaturesSmm()
    {
        const string expected = $@"
{XMLDECL}
<DomainFeaturesSmm {XMLNS} />
";

        this.AssertXml<DomainFeaturesSmm>(expected);
    }

    [TestMethod]
    public void DomainFeaturesSmmTseg()
    {
        const string expected = $@"
{XMLDECL}
<DomainFeaturesSmmTseg {XMLNS} />
";

        this.AssertXml<DomainFeaturesSmmTseg>(expected);
    }

    [TestMethod]
    public void DomainFeaturesTcgfeaturesTbCache()
    {
        const string expected = $@"
{XMLDECL}
<DomainFeaturesTcgfeaturesTbCache {XMLNS} />
";

        this.AssertXml<DomainFeaturesTcgfeaturesTbCache>(expected);
    }

    [TestMethod]
    public void DomainFeaturesViridian()
    {
        const string expected = $@"
{XMLDECL}
<DomainFeaturesViridian {XMLNS} />
";

        this.AssertXml<DomainFeaturesViridian>(expected);
    }

    [TestMethod]
    public void DomainFeaturesVmport()
    {
        const string expected = $@"
{XMLDECL}
<DomainFeaturesVmport {XMLNS} />
";

        this.AssertXml<DomainFeaturesVmport>(expected);
    }

    [TestMethod]
    public void DomainFibrechannel()
    {
        const string expected = $@"
{XMLDECL}
<fibrechannel {XMLNS} />
";

        this.AssertXml<DomainFibrechannel>(expected);
    }

    [TestMethod]
    public void DomainFilesystem()
    {
        const string expected = $@"
{XMLDECL}
<filesystem {XMLNS} />
";

        this.AssertXml<DomainFilesystem>(expected);
    }

    [TestMethod]
    public void DomainFilesystemAccessmode()
    {
        var values = Enum.GetValues(typeof(DomainFilesystemAccessmode));
        Assert.HasCount(3, values);
    }

    [TestMethod]
    public void DomainFilesystemModel()
    {
        var values = Enum.GetValues(typeof(DomainFilesystemModel));
        Assert.HasCount(3, values);
    }

    [TestMethod]
    public void DomainFilesystemMultidevs()
    {
        var values = Enum.GetValues(typeof(DomainFilesystemMultidevs));
        Assert.HasCount(4, values);
    }

    [TestMethod]
    public void DomainFilesystemReadonly()
    {
        const string expected = $@"
{XMLDECL}
<DomainFilesystemReadonly {XMLNS} />
";

        this.AssertXml<DomainFilesystemReadonly>(expected);
    }

    [TestMethod]
    public void DomainFilesystemSource()
    {
        const string expected = $@"
{XMLDECL}
<DomainFilesystemSource {XMLNS} />
";

        this.AssertXml<DomainFilesystemSource>(expected);
    }

    [TestMethod]
    public void DomainFilesystemTarget()
    {
        const string expected = $@"
{XMLDECL}
<DomainFilesystemTarget {XMLNS} />
";

        this.AssertXml<DomainFilesystemTarget>(expected);
    }

    [TestMethod]
    public void DomainFilesystemType()
    {
        var values = Enum.GetValues(typeof(DomainFilesystemType));
        Assert.HasCount(6, values);
    }

    [TestMethod]
    public void DomainFsBinary()
    {
        const string expected = $@"
{XMLDECL}
<DomainFsBinary {XMLNS} />
";

        this.AssertXml<DomainFsBinary>(expected);
    }

    [TestMethod]
    public void DomainFsBinaryCache()
    {
        const string expected = $@"
{XMLDECL}
<DomainFsBinaryCache {XMLNS} />
";

        this.AssertXml<DomainFsBinaryCache>(expected);
    }

    [TestMethod]
    public void DomainFsBinaryCacheMode()
    {
        var values = Enum.GetValues(typeof(DomainFsBinaryCacheMode));
        Assert.HasCount(2, values);
    }

    [TestMethod]
    public void DomainFsBinaryLock()
    {
        const string expected = $@"
{XMLDECL}
<DomainFsBinaryLock {XMLNS} />
";

        this.AssertXml<DomainFsBinaryLock>(expected);
    }

    [TestMethod]
    public void DomainFsBinaryOpenfiles()
    {
        const string expected = $@"
{XMLDECL}
<DomainFsBinaryOpenfiles {XMLNS} />
";

        this.AssertXml<DomainFsBinaryOpenfiles>(expected);
    }

    [TestMethod]
    public void DomainFsBinarySandbox()
    {
        const string expected = $@"
{XMLDECL}
<DomainFsBinarySandbox {XMLNS} />
";

        this.AssertXml<DomainFsBinarySandbox>(expected);
    }

    [TestMethod]
    public void DomainFsBinarySandboxMode()
    {
        var values = Enum.GetValues(typeof(DomainFsBinarySandboxMode));
        Assert.HasCount(2, values);
    }

    [TestMethod]
    public void DomainFsBinaryThreadPool()
    {
        const string expected = $@"
{XMLDECL}
<DomainFsBinaryThreadPool {XMLNS} />
";

        this.AssertXml<DomainFsBinaryThreadPool>(expected);
    }

    [TestMethod]
    public void DomainFsDriver()
    {
        const string expected = $@"
{XMLDECL}
<DomainFsDriver {XMLNS} />
";

        this.AssertXml<DomainFsDriver>(expected);
    }

    [TestMethod]
    public void DomainFsDriverFormat()
    {
        var values = Enum.GetValues(typeof(DomainFsDriverFormat));
        Assert.HasCount(17, values);
    }

    [TestMethod]
    public void DomainFsDriverType()
    {
        var values = Enum.GetValues(typeof(DomainFsDriverType));
        Assert.HasCount(7, values);
    }

    [TestMethod]
    public void DomainFsDriverWrpolicy()
    {
        var values = Enum.GetValues(typeof(DomainFsDriverWrpolicy));
        Assert.HasCount(1, values);
    }

    [TestMethod]
    public void DomainGraphic()
    {
        const string expected = $@"
{XMLDECL}
<graphics {XMLNS} type=""dbus"" />
";

        this.AssertXml<DomainGraphic>(expected);
    }

    [TestMethod]
    public void DomainGraphicAudio()
    {
        const string expected = $@"
{XMLDECL}
<DomainGraphicAudio {XMLNS} />
";

        this.AssertXml<DomainGraphicAudio>(expected);
    }

    [TestMethod]
    public void DomainGraphicChannel()
    {
        const string expected = $@"
{XMLDECL}
<DomainGraphicChannel {XMLNS} name=""cursor"" mode=""any"" />
";

        this.AssertXml<DomainGraphicChannel>(expected);
    }

    [TestMethod]
    public void DomainGraphicChannelMode()
    {
        var values = Enum.GetValues(typeof(DomainGraphicChannelMode));
        Assert.HasCount(3, values);
    }

    [TestMethod]
    public void DomainGraphicChannelName()
    {
        var values = Enum.GetValues(typeof(DomainGraphicChannelName));
        Assert.HasCount(8, values);
    }

    [TestMethod]
    public void DomainGraphicConnected()
    {
        var values = Enum.GetValues(typeof(DomainGraphicConnected));
        Assert.HasCount(3, values);
    }

    [TestMethod]
    public void DomainGraphicDefaultMode()
    {
        var values = Enum.GetValues(typeof(DomainGraphicDefaultMode));
        Assert.HasCount(3, values);
    }

    [TestMethod]
    public void DomainGraphicFiletransfer()
    {
        const string expected = $@"
{XMLDECL}
<DomainGraphicFiletransfer {XMLNS} enable=""no"" />
";

        this.AssertXml<DomainGraphicFiletransfer>(expected);
    }

    [TestMethod]
    public void DomainGraphicGl()
    {
        const string expected = $@"
{XMLDECL}
<DomainGraphicGl {XMLNS} />
";

        this.AssertXml<DomainGraphicGl>(expected);
    }

    [TestMethod]
    public void DomainGraphicImage()
    {
        const string expected = $@"
{XMLDECL}
<DomainGraphicImage {XMLNS} compression=""auto_glz"" />
";

        this.AssertXml<DomainGraphicImage>(expected);
    }

    [TestMethod]
    public void DomainGraphicImageCompression()
    {
        var values = Enum.GetValues(typeof(DomainGraphicImageCompression));
        Assert.HasCount(6, values);
    }

    [TestMethod]
    public void DomainGraphicJpeg()
    {
        const string expected = $@"
{XMLDECL}
<DomainGraphicJpeg {XMLNS} compression=""always"" />
";

        this.AssertXml<DomainGraphicJpeg>(expected);
    }

    [TestMethod]
    public void DomainGraphicJpegCompression()
    {
        var values = Enum.GetValues(typeof(DomainGraphicJpegCompression));
        Assert.HasCount(3, values);
    }

    [TestMethod]
    public void DomainGraphicListen()
    {
        const string expected = $@"
{XMLDECL}
<DomainGraphicListen {XMLNS} type=""address"" />
";

        this.AssertXml<DomainGraphicListen>(expected);
    }

    [TestMethod]
    public void DomainGraphicListenType()
    {
        var values = Enum.GetValues(typeof(DomainGraphicListenType));
        Assert.HasCount(4, values);
    }

    [TestMethod]
    public void DomainGraphicPlayback()
    {
        const string expected = $@"
{XMLDECL}
<DomainGraphicPlayback {XMLNS} compression=""off"" />
";

        this.AssertXml<DomainGraphicPlayback>(expected);
    }

    [TestMethod]
    public void DomainGraphicSharePolicy()
    {
        var values = Enum.GetValues(typeof(DomainGraphicSharePolicy));
        Assert.HasCount(3, values);
    }

    [TestMethod]
    public void DomainGraphicStreaming()
    {
        const string expected = $@"
{XMLDECL}
<DomainGraphicStreaming {XMLNS} mode=""all"" />
";

        this.AssertXml<DomainGraphicStreaming>(expected);
    }

    [TestMethod]
    public void DomainGraphicStreamingMode()
    {
        var values = Enum.GetValues(typeof(DomainGraphicStreamingMode));
        Assert.HasCount(3, values);
    }

    [TestMethod]
    public void DomainGraphicType()
    {
        var values = Enum.GetValues(typeof(DomainGraphicType));
        Assert.HasCount(7, values);
    }

    [TestMethod]
    public void DomainGraphicZlib()
    {
        const string expected = $@"
{XMLDECL}
<DomainGraphicZlib {XMLNS} compression=""always"" />
";

        this.AssertXml<DomainGraphicZlib>(expected);
    }

    [TestMethod]
    public void DomainGraphicZlibCompression()
    {
        var values = Enum.GetValues(typeof(DomainGraphicZlibCompression));
        Assert.HasCount(3, values);
    }

    [TestMethod]
    public void DomainGeometry()
    {
        const string expected = $@"
{XMLDECL}
<DomainGeometry {XMLNS} cyls=""0"" heads=""0"" secs=""0"" />
";

        this.AssertXml<DomainGeometry>(expected);
    }

    [TestMethod]
    public void DomainGeometryTrans()
    {
        var values = Enum.GetValues(typeof(DomainGeometryTrans));
        Assert.HasCount(3, values);
    }

    [TestMethod]
    public void DomainHostdev()
    {
        const string expected = $@"
{XMLDECL}
<hostdev {XMLNS} type=""mdev"" />
";

        this.AssertXml<DomainHostdev>(expected);
    }

    [TestMethod]
    public void DomainHostdevIp()
    {
        const string expected = $@"
{XMLDECL}
<DomainHostdevIp {XMLNS} />
";

        this.AssertXml<DomainHostdevIp>(expected);
    }

    [TestMethod]
    public void DomainHostdevMode()
    {
        var values = Enum.GetValues(typeof(DomainHostdevMode));
        Assert.HasCount(2, values);
    }

    [TestMethod]
    public void DomainHostdevModel()
    {
        var values = Enum.GetValues(typeof(DomainHostdevModel));
        Assert.HasCount(6, values);
    }

    [TestMethod]
    public void DomainHostdevReadonly()
    {
        const string expected = $@"
{XMLDECL}
<DomainHostdevReadonly {XMLNS} />
";

        this.AssertXml<DomainHostdevReadonly>(expected);
    }

    [TestMethod]
    public void DomainHostdevShareable()
    {
        const string expected = $@"
{XMLDECL}
<DomainHostdevShareable {XMLNS} />
";

        this.AssertXml<DomainHostdevShareable>(expected);
    }

    [TestMethod]
    public void DomainHostdevSource()
    {
        const string expected = $@"
{XMLDECL}
<DomainHostdevSource {XMLNS} />
";

        this.AssertXml<DomainHostdevSource>(expected);
    }

    [TestMethod]
    public void DomainHostdevSourceAddress()
    {
        const string expected = $@"
{XMLDECL}
<DomainHostdevSourceAddress {XMLNS} />
";

        this.AssertXml<DomainHostdevSourceAddress>(expected);
    }

    [TestMethod]
    public void DomainHostdevSourceHost()
    {
        const string expected = $@"
{XMLDECL}
<DomainHostdevSourceHost {XMLNS} />
";

        this.AssertXml<DomainHostdevSourceHost>(expected);
    }

    [TestMethod]
    public void DomainHostdevSourceGuestReset()
    {
        var values = Enum.GetValues(typeof(DomainHostdevSourceGuestReset));
        Assert.HasCount(3, values);
    }

    [TestMethod]
    public void DomainHostdevSourceProduct()
    {
        const string expected = $@"
{XMLDECL}
<DomainHostdevSourceProduct {XMLNS} />
";

        this.AssertXml<DomainHostdevSourceProduct>(expected);
    }

    [TestMethod]
    public void DomainHostdevSourceProtocol()
    {
        var values = Enum.GetValues(typeof(DomainHostdevSourceProtocol));
        Assert.HasCount(3, values);
    }

    [TestMethod]
    public void DomainHostdevSourceVendor()
    {
        const string expected = $@"
{XMLDECL}
<DomainHostdevSourceVendor {XMLNS} />
";

        this.AssertXml<DomainHostdevSourceVendor>(expected);
    }

    [TestMethod]
    public void DomainHostdevType()
    {
        var values = Enum.GetValues(typeof(DomainHostdevType));
        Assert.HasCount(8, values);
    }

    [TestMethod]
    public void DomainHpt()
    {
        const string expected = $@"
{XMLDECL}
<hpt {XMLNS} />
";

        this.AssertXml<DomainHpt>(expected);
    }

    [TestMethod]
    public void DomainHptResizing()
    {
        var values = Enum.GetValues(typeof(DomainHptResizing));
        Assert.HasCount(3, values);
    }

    [TestMethod]
    public void DomainHub()
    {
        const string expected = $@"
{XMLDECL}
<hub {XMLNS} type=""usb"" />
";

        this.AssertXml<DomainHub>(expected);
    }

    [TestMethod]
    public void DomainHubAlias()
    {
        const string expected = $@"
{XMLDECL}
<DomainHubAlias {XMLNS} />
";

        this.AssertXml<DomainHubAlias>(expected);
    }

    [TestMethod]
    public void DomainHubType()
    {
        var values = Enum.GetValues(typeof(DomainHubType));
        Assert.HasCount(1, values);
    }

    [TestMethod]
    public void DomainHvs()
    {
        var values = Enum.GetValues(typeof(DomainHvs));
        Assert.HasCount(15, values);
    }

    [TestMethod]
    public void DomainHyperv()
    {
        const string expected = $@"
{XMLDECL}
<hyperv {XMLNS} />
";

        this.AssertXml<DomainHyperv>(expected);
    }

    [TestMethod]
    public void DomainHypervAvic()
    {
        const string expected = $@"
{XMLDECL}
<DomainHypervAvic {XMLNS} state=""off"" />
";

        this.AssertXml<DomainHypervAvic>(expected);
    }

    [TestMethod]
    public void DomainHypervEmsrBitmap()
    {
        const string expected = $@"
{XMLDECL}
<DomainHypervEmsrBitmap {XMLNS} state=""off"" />
";

        this.AssertXml<DomainHypervEmsrBitmap>(expected);
    }

    [TestMethod]
    public void DomainHypervEvmcs()
    {
        const string expected = $@"
{XMLDECL}
<DomainHypervEvmcs {XMLNS} state=""off"" />
";

        this.AssertXml<DomainHypervEvmcs>(expected);
    }

    [TestMethod]
    public void DomainHypervFrequencies()
    {
        const string expected = $@"
{XMLDECL}
<DomainHypervFrequencies {XMLNS} state=""off"" />
";

        this.AssertXml<DomainHypervFrequencies>(expected);
    }

    [TestMethod]
    public void DomainHypervIpi()
    {
        const string expected = $@"
{XMLDECL}
<DomainHypervIpi {XMLNS} state=""off"" />
";

        this.AssertXml<DomainHypervIpi>(expected);
    }

    [TestMethod]
    public void DomainHypervMode()
    {
        var values = Enum.GetValues(typeof(DomainHypervMode));
        Assert.HasCount(3, values);
    }

    [TestMethod]
    public void DomainHypervReenlightenment()
    {
        const string expected = $@"
{XMLDECL}
<DomainHypervReenlightenment {XMLNS} state=""off"" />
";

        this.AssertXml<DomainHypervReenlightenment>(expected);
    }

    [TestMethod]
    public void DomainHypervRelaxed()
    {
        const string expected = $@"
{XMLDECL}
<DomainHypervRelaxed {XMLNS} state=""off"" />
";

        this.AssertXml<DomainHypervRelaxed>(expected);
    }

    [TestMethod]
    public void DomainHypervReset()
    {
        const string expected = $@"
{XMLDECL}
<DomainHypervReset {XMLNS} state=""off"" />
";

        this.AssertXml<DomainHypervReset>(expected);
    }

    [TestMethod]
    public void DomainHypervRuntime()
    {
        const string expected = $@"
{XMLDECL}
<DomainHypervRuntime {XMLNS} state=""off"" />
";

        this.AssertXml<DomainHypervRuntime>(expected);
    }

    [TestMethod]
    public void DomainHypervSpinlocks()
    {
        const string expected = $@"
{XMLDECL}
<DomainHypervSpinlocks {XMLNS} state=""off"" />
";

        this.AssertXml<DomainHypervSpinlocks>(expected);
    }

    [TestMethod]
    public void DomainHypervSynic()
    {
        const string expected = $@"
{XMLDECL}
<DomainHypervSynic {XMLNS} state=""off"" />
";

        this.AssertXml<DomainHypervSynic>(expected);
    }

    [TestMethod]
    public void DomainHypervStimer()
    {
        const string expected = $@"
{XMLDECL}
<DomainHypervStimer {XMLNS} />
";

        this.AssertXml<DomainHypervStimer>(expected);
    }

    [TestMethod]
    public void DomainHypervStimerDirect()
    {
        const string expected = $@"
{XMLDECL}
<DomainHypervStimerDirect {XMLNS} state=""off"" />
";

        this.AssertXml<DomainHypervStimerDirect>(expected);
    }

    [TestMethod]
    public void DomainHypervTlbflush()
    {
        const string expected = $@"
{XMLDECL}
<DomainHypervTlbflush {XMLNS} />
";

        this.AssertXml<DomainHypervTlbflush>(expected);
    }

    [TestMethod]
    public void DomainHypervTlbflushDirect()
    {
        const string expected = $@"
{XMLDECL}
<DomainHypervTlbflushDirect {XMLNS} state=""off"" />
";

        this.AssertXml<DomainHypervTlbflushDirect>(expected);
    }

    [TestMethod]
    public void DomainHypervTlbflushExtended()
    {
        const string expected = $@"
{XMLDECL}
<DomainHypervTlbflushExtended {XMLNS} state=""off"" />
";

        this.AssertXml<DomainHypervTlbflushExtended>(expected);
    }

    [TestMethod]
    public void DomainHypervVapic()
    {
        const string expected = $@"
{XMLDECL}
<DomainHypervVapic {XMLNS} state=""off"" />
";

        this.AssertXml<DomainHypervVapic>(expected);
    }

    [TestMethod]
    public void DomainHypervVendorId()
    {
        const string expected = $@"
{XMLDECL}
<DomainHypervVendorId {XMLNS} state=""off"" />
";

        this.AssertXml<DomainHypervVendorId>(expected);
    }

    [TestMethod]
    public void DomainHypervVpindex()
    {
        const string expected = $@"
{XMLDECL}
<DomainHypervVpindex {XMLNS} state=""off"" />
";

        this.AssertXml<DomainHypervVpindex>(expected);
    }

    [TestMethod]
    public void DomainHypervXmmInput()
    {
        const string expected = $@"
{XMLDECL}
<DomainHypervXmmInput {XMLNS} state=""off"" />
";

        this.AssertXml<DomainHypervXmmInput>(expected);
    }

    [TestMethod]
    public void DomainIbs()
    {
        const string expected = $@"
{XMLDECL}
<ibs {XMLNS} value=""broken"" />
";

        this.AssertXml<DomainIbs>(expected);
    }

    [TestMethod]
    public void DomainIbsValue()
    {
        var values = Enum.GetValues(typeof(DomainIbsValue));
        Assert.HasCount(5, values);
    }

    [TestMethod]
    public void DomainIdmap()
    {
        const string expected = $@"
{XMLDECL}
<idmap {XMLNS} />
";

        this.AssertXml<DomainIdmap>(expected);
    }

    [TestMethod]
    public void DomainIdmapGid()
    {
        const string expected = $@"
{XMLDECL}
<DomainIdmapGid {XMLNS} start=""0"" target=""0"" count=""0"" />
";

        this.AssertXml<DomainIdmapGid>(expected);
    }

    [TestMethod]
    public void DomainIdmapUid()
    {
        const string expected = $@"
{XMLDECL}
<DomainIdmapUid {XMLNS} start=""0"" target=""0"" count=""0"" />
";

        this.AssertXml<DomainIdmapUid>(expected);
    }

    [TestMethod]
    public void DomainInput()
    {
        const string expected = $@"
{XMLDECL}
<input {XMLNS} type=""evdev"" />
";

        this.AssertXml<DomainInput>(expected);
    }

    [TestMethod]
    public void DomainInputBus()
    {
        var values = Enum.GetValues(typeof(DomainInputBus));
        Assert.HasCount(4, values);
    }

    [TestMethod]
    public void DomainInputDriver()
    {
        const string expected = $@"
{XMLDECL}
<DomainInputDriver {XMLNS} />
";

        this.AssertXml<DomainInputDriver>(expected);
    }

    [TestMethod]
    public void DomainInputModel()
    {
        var values = Enum.GetValues(typeof(DomainInputModel));
        Assert.HasCount(3, values);
    }

    [TestMethod]
    public void DomainInputSource()
    {
        const string expected = $@"
{XMLDECL}
<DomainInputSource {XMLNS} />
";

        this.AssertXml<DomainInputSource>(expected);
    }

    [TestMethod]
    public void DomainInputSourceGrab()
    {
        var values = Enum.GetValues(typeof(DomainInputSourceGrab));
        Assert.HasCount(1, values);
    }

    [TestMethod]
    public void DomainInputSourceGrabToggle()
    {
        var values = Enum.GetValues(typeof(DomainInputSourceGrabToggle));
        Assert.HasCount(6, values);
    }

    [TestMethod]
    public void DomainInputType()
    {
        var values = Enum.GetValues(typeof(DomainInputType));
        Assert.HasCount(5, values);
    }

    [TestMethod]
    public void DomainInterface()
    {
        const string expected = $@"
{XMLDECL}
<interface {XMLNS} type=""bridge"" />
";

        this.AssertXml<DomainInterface>(expected);
    }

    [TestMethod]
    public void DomainInterfaceBackend()
    {
        const string expected = $@"
{XMLDECL}
<DomainInterfaceBackend {XMLNS} />
";

        this.AssertXml<DomainInterfaceBackend>(expected);
    }

    [TestMethod]
    public void DomainInterfaceBackenddomain()
    {
        const string expected = $@"
{XMLDECL}
<DomainInterfaceBackenddomain {XMLNS} />
";

        this.AssertXml<DomainInterfaceBackenddomain>(expected);
    }

    [TestMethod]
    public void DomainInterfaceBackendType()
    {
        var values = Enum.GetValues(typeof(DomainInterfaceBackendType));
        Assert.HasCount(2, values);
    }

    [TestMethod]
    public void DomainInterfaceDownscript()
    {
        const string expected = $@"
{XMLDECL}
<DomainInterfaceDownscript {XMLNS} />
";

        this.AssertXml<DomainInterfaceDownscript>(expected);
    }

    [TestMethod]
    public void DomainInterfaceDriver()
    {
        const string expected = $@"
{XMLDECL}
<DomainInterfaceDriver {XMLNS} />
";

        this.AssertXml<DomainInterfaceDriver>(expected);
    }

    [TestMethod]
    public void DomainInterfaceDriverGuest()
    {
        const string expected = $@"
{XMLDECL}
<DomainInterfaceDriverGuest {XMLNS} />
";

        this.AssertXml<DomainInterfaceDriverGuest>(expected);
    }

    [TestMethod]
    public void DomainInterfaceDriverHost()
    {
        const string expected = $@"
{XMLDECL}
<DomainInterfaceDriverHost {XMLNS} />
";

        this.AssertXml<DomainInterfaceDriverHost>(expected);
    }

    [TestMethod]
    public void DomainInterfaceDriverName()
    {
        var values = Enum.GetValues(typeof(DomainInterfaceDriverName));
        Assert.HasCount(5, values);
    }

    [TestMethod]
    public void DomainInterfaceDriverTxmode()
    {
        var values = Enum.GetValues(typeof(DomainInterfaceDriverTxmode));
        Assert.HasCount(2, values);
    }

    [TestMethod]
    public void DomainInterfaceFilterref()
    {
        const string expected = $@"
{XMLDECL}
<DomainInterfaceFilterref {XMLNS} />
";

        this.AssertXml<DomainInterfaceFilterref>(expected);
    }

    [TestMethod]
    public void DomainInterfaceGuest()
    {
        const string expected = $@"
{XMLDECL}
<DomainInterfaceGuest {XMLNS} />
";

        this.AssertXml<DomainInterfaceGuest>(expected);
    }

    [TestMethod]
    public void DomainInterfaceLink()
    {
        const string expected = $@"
{XMLDECL}
<DomainInterfaceLink {XMLNS} state=""down"" />
";

        this.AssertXml<DomainInterfaceLink>(expected);
    }

    [TestMethod]
    public void DomainInterfaceLinkState()
    {
        var values = Enum.GetValues(typeof(DomainInterfaceLinkState));
        Assert.HasCount(2, values);
    }

    [TestMethod]
    public void DomainInterfaceMac()
    {
        const string expected = $@"
{XMLDECL}
<DomainInterfaceMac {XMLNS} />
";

        this.AssertXml<DomainInterfaceMac>(expected);
    }

    [TestMethod]
    public void DomainInterfaceMacType()
    {
        var values = Enum.GetValues(typeof(DomainInterfaceMacType));
        Assert.HasCount(2, values);
    }

    [TestMethod]
    public void DomainInterfaceModel()
    {
        const string expected = $@"
{XMLDECL}
<DomainInterfaceModel {XMLNS} />
";

        this.AssertXml<DomainInterfaceModel>(expected);
    }

    [TestMethod]
    public void DomainInterfacePortForward()
    {
        const string expected = $@"
{XMLDECL}
<DomainInterfacePortForward {XMLNS} proto=""tcp"" />
";

        this.AssertXml<DomainInterfacePortForward>(expected);
    }

    [TestMethod]
    public void DomainInterfacePortForwardProto()
    {
        var values = Enum.GetValues(typeof(DomainInterfacePortForwardProto));
        Assert.HasCount(2, values);
    }

    [TestMethod]
    public void DomainInterfacePortForwardRange()
    {
        const string expected = $@"
{XMLDECL}
<DomainInterfacePortForwardRange {XMLNS} start=""0"" />
";

        this.AssertXml<DomainInterfacePortForwardRange>(expected);
    }

    [TestMethod]
    public void DomainInterfaceSource()
    {
        const string expected = $@"
{XMLDECL}
<DomainInterfaceSource {XMLNS} />
";

        this.AssertXml<DomainInterfaceSource>(expected);
    }

    [TestMethod]
    public void DomainInterfaceSourceAddress()
    {
        const string expected = $@"
{XMLDECL}
<DomainInterfaceSourceAddress {XMLNS} type=""pci"" />
";

        this.AssertXml<DomainInterfaceSourceAddress>(expected);
    }

    [TestMethod]
    public void DomainInterfaceSourceAddressType()
    {
        var values = Enum.GetValues(typeof(DomainInterfaceSourceAddressType));
        Assert.HasCount(2, values);
    }

    [TestMethod]
    public void DomainInterfaceSourceLocal()
    {
        const string expected = $@"
{XMLDECL}
<DomainInterfaceSourceLocal {XMLNS} port=""0"" />
";

        this.AssertXml<DomainInterfaceSourceLocal>(expected);
    }

    [TestMethod]
    public void DomainInterfaceScript()
    {
        const string expected = $@"
{XMLDECL}
<DomainInterfaceScript {XMLNS} />
";

        this.AssertXml<DomainInterfaceScript>(expected);
    }

    [TestMethod]
    public void DomainInterfaceTarget()
    {
        const string expected = $@"
{XMLDECL}
<DomainInterfaceTarget {XMLNS} />
";

        this.AssertXml<DomainInterfaceTarget>(expected);
    }

    [TestMethod]
    public void DomainInterfaceTune()
    {
        const string expected = $@"
{XMLDECL}
<DomainInterfaceTune {XMLNS} />
";

        this.AssertXml<DomainInterfaceTune>(expected);
    }

    [TestMethod]
    public void DomainInterfaceType()
    {
        var values = Enum.GetValues(typeof(DomainInterfaceType));
        Assert.HasCount(15, values);
    }

    [TestMethod]
    public void DomainInterfaceVirtualport()
    {
        const string expected = $@"
{XMLDECL}
<DomainInterfaceVirtualport {XMLNS} />
";

        this.AssertXml<DomainInterfaceVirtualport>(expected);
    }

    [TestMethod]
    public void DomainInterfaceVirtualportType()
    {
        var values = Enum.GetValues(typeof(DomainInterfaceVirtualportType));
        Assert.HasCount(4, values);
    }

    [TestMethod]
    public void DomainInterfaceVirtualportParameters()
    {
        const string expected = $@"
{XMLDECL}
<DomainInterfaceVirtualportParameters {XMLNS} />
";

        this.AssertXml<DomainInterfaceVirtualportParameters>(expected);
    }

    [TestMethod]
    public void DomainIoapic()
    {
        const string expected = $@"
{XMLDECL}
<ioapic {XMLNS} driver=""kvm"" />
";

        this.AssertXml<DomainIoapic>(expected);
    }

    [TestMethod]
    public void DomainIoapicDriver()
    {
        var values = Enum.GetValues(typeof(DomainIoapicDriver));
        Assert.HasCount(2, values);
    }

    [TestMethod]
    public void DomainIommu()
    {
        const string expected = $@"
{XMLDECL}
<iommu {XMLNS} model=""amd"" />
";

        this.AssertXml<DomainIommu>(expected);
    }

    [TestMethod]
    public void DomainIommuDriver()
    {
        const string expected = $@"
{XMLDECL}
<DomainIommuDriver {XMLNS} />
";

        this.AssertXml<DomainIommuDriver>(expected);
    }

    [TestMethod]
    public void DomainIommuModel()
    {
        var values = Enum.GetValues(typeof(DomainIommuModel));
        Assert.HasCount(4, values);
    }

    [TestMethod]
    public void DomainIothreadids()
    {
        const string expected = $@"
{XMLDECL}
<DomainIothreadids {XMLNS} />
";

        this.AssertXml<DomainIothreadids>(expected);
    }

    [TestMethod]
    public void DomainIothreadidsIothread()
    {
        const string expected = $@"
{XMLDECL}
<DomainIothreadidsIothread {XMLNS} id=""0"" />
";

        this.AssertXml<DomainIothreadidsIothread>(expected);
    }

    [TestMethod]
    public void DomainIothreadMapping()
    {
        const string expected = $@"
{XMLDECL}
<DomainIothreadMapping {XMLNS} />
";

        this.AssertXml<DomainIothreadMapping>(expected);
    }

    [TestMethod]
    public void DomainIothreadMappingIothread()
    {
        const string expected = $@"
{XMLDECL}
<DomainIothreadMappingIothread {XMLNS} id=""0"" />
";

        this.AssertXml<DomainIothreadMappingIothread>(expected);
    }

    [TestMethod]
    public void DomainIothreadMappingIothreadQueue()
    {
        const string expected = $@"
{XMLDECL}
<DomainIothreadMappingIothreadQueue {XMLNS} id=""0"" />
";

        this.AssertXml<DomainIothreadMappingIothreadQueue>(expected);
    }

    [TestMethod]
    public void DomainKeywrap()
    {
        const string expected = $@"
{XMLDECL}
<keywrap {XMLNS} />
";

        this.AssertXml<DomainKeywrap>(expected);
    }

    [TestMethod]
    public void DomainKeywrapCipher()
    {
        const string expected = $@"
{XMLDECL}
<DomainKeywrapCipher {XMLNS} name=""aes"" state=""off"" />
";

        this.AssertXml<DomainKeywrapCipher>(expected);
    }

    [TestMethod]
    public void DomainKeywrapCipherName()
    {
        var values = Enum.GetValues(typeof(DomainKeywrapCipherName));
        Assert.HasCount(2, values);
    }

    [TestMethod]
    public void DomainKvm()
    {
        const string expected = $@"
{XMLDECL}
<kvm {XMLNS} />
";

        this.AssertXml<DomainKvm>(expected);
    }

    [TestMethod]
    public void DomainKvmDirtyRing()
    {
        const string expected = $@"
{XMLDECL}
<DomainKvmDirtyRing {XMLNS} state=""off"" />
";

        this.AssertXml<DomainKvmDirtyRing>(expected);
    }

    [TestMethod]
    public void DomainKvmHidden()
    {
        const string expected = $@"
{XMLDECL}
<DomainKvmHidden {XMLNS} state=""off"" />
";

        this.AssertXml<DomainKvmHidden>(expected);
    }

    [TestMethod]
    public void DomainKvmHintDedicated()
    {
        const string expected = $@"
{XMLDECL}
<DomainKvmHintDedicated {XMLNS} state=""off"" />
";

        this.AssertXml<DomainKvmHintDedicated>(expected);
    }

    [TestMethod]
    public void DomainKvmPollControl()
    {
        const string expected = $@"
{XMLDECL}
<DomainKvmPollControl {XMLNS} state=""off"" />
";

        this.AssertXml<DomainKvmPollControl>(expected);
    }

    [TestMethod]
    public void DomainKvmPvIpi()
    {
        const string expected = $@"
{XMLDECL}
<DomainKvmPvIpi {XMLNS} state=""off"" />
";

        this.AssertXml<DomainKvmPvIpi>(expected);
    }

    [TestMethod]
    public void DomainLaunchSecurity()
    {
        const string expected = $@"
{XMLDECL}
<launchSecurity {XMLNS} type=""s390-pv"" />
";

        this.AssertXml<DomainLaunchSecurity>(expected);
    }

    [TestMethod]
    public void DomainLaunchSecurityQuoteGenerationService()
    {
        const string expected = $@"
{XMLDECL}
<DomainLaunchSecurityQuoteGenerationService {XMLNS} />
";

        this.AssertXml<DomainLaunchSecurityQuoteGenerationService>(expected);
    }

    [TestMethod]
    public void DomainLaunchSecurityType()
    {
        var values = Enum.GetValues(typeof(DomainLaunchSecurityType));
        Assert.HasCount(4, values);
    }

    [TestMethod]
    public void DomainLease()
    {
        const string expected = $@"
{XMLDECL}
<lease {XMLNS} />
";

        this.AssertXml<DomainLease>(expected);
    }

    [TestMethod]
    public void DomainLeaseTarget()
    {
        const string expected = $@"
{XMLDECL}
<DomainLeaseTarget {XMLNS} />
";

        this.AssertXml<DomainLeaseTarget>(expected);
    }

    [TestMethod]
    public void DomainLxcsharensShareipcType()
    {
        var values = Enum.GetValues(typeof(DomainLxcsharensShareipcType));
        Assert.HasCount(2, values);
    }

    [TestMethod]
    public void DomainLxcsharensSharenetType()
    {
        var values = Enum.GetValues(typeof(DomainLxcsharensSharenetType));
        Assert.HasCount(3, values);
    }

    [TestMethod]
    public void DomainLxcsharensShareutsType()
    {
        var values = Enum.GetValues(typeof(DomainLxcsharensShareutsType));
        Assert.HasCount(2, values);
    }

    [TestMethod]
    public void DomainMaxMemory()
    {
        const string expected = $@"
{XMLDECL}
<DomainMaxMemory {XMLNS} />
";

        this.AssertXml<DomainMaxMemory>(expected);
    }

    [TestMethod]
    public void DomainMemballoon()
    {
        const string expected = $@"
{XMLDECL}
<memballoon {XMLNS} model=""none"" />
";

        this.AssertXml<DomainMemballoon>(expected);
    }

    [TestMethod]
    public void DomainMemballoonDriver()
    {
        const string expected = $@"
{XMLDECL}
<DomainMemballoonDriver {XMLNS} />
";

        this.AssertXml<DomainMemballoonDriver>(expected);
    }

    [TestMethod]
    public void DomainMemballoonModel()
    {
        var values = Enum.GetValues(typeof(DomainMemballoonModel));
        Assert.HasCount(5, values);
    }

    [TestMethod]
    public void DomainMemballoonStats()
    {
        const string expected = $@"
{XMLDECL}
<DomainMemballoonStats {XMLNS} period=""0"" />
";

        this.AssertXml<DomainMemballoonStats>(expected);
    }

    [TestMethod]
    public void DomainMemory()
    {
        const string expected = $@"
{XMLDECL}
<DomainMemory {XMLNS} />
";

        this.AssertXml<DomainMemory>(expected);
    }

    [TestMethod]
    public void DomainMemoryBacking()
    {
        const string expected = $@"
{XMLDECL}
<DomainMemoryBacking {XMLNS} />
";

        this.AssertXml<DomainMemoryBacking>(expected);
    }

    [TestMethod]
    public void DomainMemoryBackingAccess()
    {
        const string expected = $@"
{XMLDECL}
<DomainMemoryBackingAccess {XMLNS} mode=""private"" />
";

        this.AssertXml<DomainMemoryBackingAccess>(expected);
    }

    [TestMethod]
    public void DomainMemoryBackingAccessMode()
    {
        var values = Enum.GetValues(typeof(DomainMemoryBackingAccessMode));
        Assert.HasCount(2, values);
    }

    [TestMethod]
    public void DomainMemoryBackingAllocation()
    {
        const string expected = $@"
{XMLDECL}
<DomainMemoryBackingAllocation {XMLNS} />
";

        this.AssertXml<DomainMemoryBackingAllocation>(expected);
    }

    [TestMethod]
    public void DomainMemoryBackingAllocationMode()
    {
        var values = Enum.GetValues(typeof(DomainMemoryBackingAllocationMode));
        Assert.HasCount(2, values);
    }

    [TestMethod]
    public void DomainMemoryBackingDiscard()
    {
        const string expected = $@"
{XMLDECL}
<DomainMemoryBackingDiscard {XMLNS} />
";

        this.AssertXml<DomainMemoryBackingDiscard>(expected);
    }

    [TestMethod]
    public void DomainMemoryBackingHugepages()
    {
        const string expected = $@"
{XMLDECL}
<DomainMemoryBackingHugepages {XMLNS} />
";

        this.AssertXml<DomainMemoryBackingHugepages>(expected);
    }

    [TestMethod]
    public void DomainMemoryBackingHugepagesPage()
    {
        const string expected = $@"
{XMLDECL}
<DomainMemoryBackingHugepagesPage {XMLNS} size=""0"" />
";

        this.AssertXml<DomainMemoryBackingHugepagesPage>(expected);
    }

    [TestMethod]
    public void DomainMemoryBackingLocked()
    {
        const string expected = $@"
{XMLDECL}
<DomainMemoryBackingLocked {XMLNS} />
";

        this.AssertXml<DomainMemoryBackingLocked>(expected);
    }

    [TestMethod]
    public void DomainMemoryBackingNosharepages()
    {
        const string expected = $@"
{XMLDECL}
<DomainMemoryBackingNosharepages {XMLNS} />
";

        this.AssertXml<DomainMemoryBackingNosharepages>(expected);
    }

    [TestMethod]
    public void DomainMemoryBackingSource()
    {
        const string expected = $@"
{XMLDECL}
<DomainMemoryBackingSource {XMLNS} type=""anonymous"" />
";

        this.AssertXml<DomainMemoryBackingSource>(expected);
    }

    [TestMethod]
    public void DomainMemoryBackingSourceType()
    {
        var values = Enum.GetValues(typeof(DomainMemoryBackingSourceType));
        Assert.HasCount(3, values);
    }

    [TestMethod]
    public void DomainMemorydev()
    {
        const string expected = $@"
{XMLDECL}
<memory {XMLNS} model=""dimm"" />
";

        this.AssertXml<DomainMemorydev>(expected);
    }

    [TestMethod]
    public void DomainMemorydevAccess()
    {
        var values = Enum.GetValues(typeof(DomainMemorydevAccess));
        Assert.HasCount(2, values);
    }

    [TestMethod]
    public void DomainMemorydevModel()
    {
        var values = Enum.GetValues(typeof(DomainMemorydevModel));
        Assert.HasCount(5, values);
    }

    [TestMethod]
    public void DomainMemorydevDriver()
    {
        const string expected = $@"
{XMLDECL}
<DomainMemorydevDriver {XMLNS} />
";

        this.AssertXml<DomainMemorydevDriver>(expected);
    }

    [TestMethod]
    public void DomainMemorydevSource()
    {
        const string expected = $@"
{XMLDECL}
<DomainMemorydevSource {XMLNS} />
";

        this.AssertXml<DomainMemorydevSource>(expected);
    }

    [TestMethod]
    public void DomainMemorydevSourcePmem()
    {
        const string expected = $@"
{XMLDECL}
<DomainMemorydevSourcePmem {XMLNS} />
";

        this.AssertXml<DomainMemorydevSourcePmem>(expected);
    }

    [TestMethod]
    public void DomainMemorydevTarget()
    {
        const string expected = $@"
{XMLDECL}
<DomainMemorydevTarget {XMLNS} />
";

        this.AssertXml<DomainMemorydevTarget>(expected);
    }

    [TestMethod]
    public void DomainMemorydevTargetLabel()
    {
        const string expected = $@"
{XMLDECL}
<DomainMemorydevTargetLabel {XMLNS} />
";

        this.AssertXml<DomainMemorydevTargetLabel>(expected);
    }

    [TestMethod]
    public void DomainMemorydevTargetReadonly()
    {
        const string expected = $@"
{XMLDECL}
<DomainMemorydevTargetReadonly {XMLNS} />
";

        this.AssertXml<DomainMemorydevTargetReadonly>(expected);
    }

    [TestMethod]
    public void DomainMemtune()
    {
        const string expected = $@"
{XMLDECL}
<memtune {XMLNS} />
";

        this.AssertXml<DomainMemtune>(expected);
    }

    [TestMethod]
    public void DomainMemtuneHardLimit()
    {
        const string expected = $@"
{XMLDECL}
<DomainMemtuneHardLimit {XMLNS} />
";

        this.AssertXml<DomainMemtuneHardLimit>(expected);
    }

    [TestMethod]
    public void DomainMemtuneMinGuarantee()
    {
        const string expected = $@"
{XMLDECL}
<DomainMemtuneMinGuarantee {XMLNS} />
";

        this.AssertXml<DomainMemtuneMinGuarantee>(expected);
    }

    [TestMethod]
    public void DomainMemtuneSoftLimit()
    {
        const string expected = $@"
{XMLDECL}
<DomainMemtuneSoftLimit {XMLNS} />
";

        this.AssertXml<DomainMemtuneSoftLimit>(expected);
    }

    [TestMethod]
    public void DomainMemtuneSwapHardLimit()
    {
        const string expected = $@"
{XMLDECL}
<DomainMemtuneSwapHardLimit {XMLNS} />
";

        this.AssertXml<DomainMemtuneSwapHardLimit>(expected);
    }

    [TestMethod]
    public void DomainMousemode()
    {
        const string expected = $@"
{XMLDECL}
<DomainMousemode {XMLNS} mode=""client"" />
";

        this.AssertXml<DomainMousemode>(expected);
    }

    [TestMethod]
    public void DomainMousemodeMode()
    {
        var values = Enum.GetValues(typeof(DomainMousemodeMode));
        Assert.HasCount(2, values);
    }

    [TestMethod]
    public void DomainMsrs()
    {
        const string expected = $@"
{XMLDECL}
<msrs {XMLNS} unknown=""fault"" />
";

        this.AssertXml<DomainMsrs>(expected);
    }

    [TestMethod]
    public void DomainMsrsUnknown()
    {
        var values = Enum.GetValues(typeof(DomainMsrsUnknown));
        Assert.HasCount(2, values);
    }

    [TestMethod]
    public void DomainNumatune()
    {
        const string expected = $@"
{XMLDECL}
<numatune {XMLNS} />
";

        this.AssertXml<DomainNumatune>(expected);
    }

    [TestMethod]
    public void DomainNumatuneMemnode()
    {
        const string expected = $@"
{XMLDECL}
<DomainNumatuneMemnode {XMLNS} cellid=""0"" mode=""interleave"" />
";

        this.AssertXml<DomainNumatuneMemnode>(expected);
    }

    [TestMethod]
    public void DomainNumatuneMemnodeMode()
    {
        var values = Enum.GetValues(typeof(DomainNumatuneMemnodeMode));
        Assert.HasCount(4, values);
    }

    [TestMethod]
    public void DomainNumatuneMemory()
    {
        const string expected = $@"
{XMLDECL}
<DomainNumatuneMemory {XMLNS} />
";

        this.AssertXml<DomainNumatuneMemory>(expected);
    }

    [TestMethod]
    public void DomainNumatuneMemoryMode()
    {
        var values = Enum.GetValues(typeof(DomainNumatuneMemoryMode));
        Assert.HasCount(4, values);
    }

    [TestMethod]
    public void DomainNumatuneMemoryPlacement()
    {
        var values = Enum.GetValues(typeof(DomainNumatuneMemoryPlacement));
        Assert.HasCount(2, values);
    }

    [TestMethod]
    public void DomainNvram()
    {
        const string expected = $@"
{XMLDECL}
<nvram {XMLNS} />
";

        this.AssertXml<DomainNvram>(expected);
    }

    [TestMethod]
    public void DomainOs()
    {
        const string expected = $@"
{XMLDECL}
<DomainOs {XMLNS} />
";

        this.AssertXml<DomainOs>(expected);
    }

    [TestMethod]
    public void DomainOsAcpiTableTable()
    {
        const string expected = $@"
{XMLDECL}
<DomainOsAcpiTableTable {XMLNS} type=""msdm"" />
";

        this.AssertXml<DomainOsAcpiTableTable>(expected);
    }

    [TestMethod]
    public void DomainOsbootdev()
    {
        const string expected = $@"
{XMLDECL}
<boot {XMLNS} dev=""cdrom"" />
";

        this.AssertXml<DomainOsbootdev>(expected);
    }

    [TestMethod]
    public void DomainOsbootdevDev()
    {
        var values = Enum.GetValues(typeof(DomainOsbootdevDev));
        Assert.HasCount(4, values);
    }

    [TestMethod]
    public void DomainOsBootmenu()
    {
        const string expected = $@"
{XMLDECL}
<DomainOsBootmenu {XMLNS} enable=""no"" />
";

        this.AssertXml<DomainOsBootmenu>(expected);
    }

    [TestMethod]
    public void DomainOsexeInitenv()
    {
        const string expected = $@"
{XMLDECL}
<DomainOsexeInitenv {XMLNS} />
";

        this.AssertXml<DomainOsexeInitenv>(expected);
    }

    [TestMethod]
    public void DomainOsFirmware()
    {
        const string expected = $@"
{XMLDECL}
<DomainOsFirmware {XMLNS} />
";

        this.AssertXml<DomainOsFirmware>(expected);
    }

    [TestMethod]
    public void DomainOsFirmwareAttr()
    {
        var values = Enum.GetValues(typeof(DomainOsFirmwareAttr));
        Assert.HasCount(2, values);
    }

    [TestMethod]
    public void DomainOsFirmwareFeature()
    {
        const string expected = $@"
{XMLDECL}
<DomainOsFirmwareFeature {XMLNS} enabled=""no"" name=""enrolled-keys"" />
";

        this.AssertXml<DomainOsFirmwareFeature>(expected);
    }

    [TestMethod]
    public void DomainOsFirmwareFeatureName()
    {
        var values = Enum.GetValues(typeof(DomainOsFirmwareFeatureName));
        Assert.HasCount(2, values);
    }

    [TestMethod]
    public void DomainOsLoader()
    {
        const string expected = $@"
{XMLDECL}
<DomainOsLoader {XMLNS} />
";

        this.AssertXml<DomainOsLoader>(expected);
    }

    [TestMethod]
    public void DomainOsLoaderType()
    {
        var values = Enum.GetValues(typeof(DomainOsLoaderType));
        Assert.HasCount(2, values);
    }

    [TestMethod]
    public void DomainOsNvram()
    {
        const string expected = $@"
{XMLDECL}
<DomainOsNvram {XMLNS} />
";

        this.AssertXml<DomainOsNvram>(expected);
    }

    [TestMethod]
    public void DomainOsNvramSource()
    {
        const string expected = $@"
{XMLDECL}
<DomainOsNvramSource {XMLNS} />
";

        this.AssertXml<DomainOsNvramSource>(expected);
    }

    [TestMethod]
    public void DomainOsNvramSourceDataStore()
    {
        const string expected = $@"
{XMLDECL}
<DomainOsNvramSourceDataStore {XMLNS} />
";

        this.AssertXml<DomainOsNvramSourceDataStore>(expected);
    }

    [TestMethod]
    public void DomainOsNvramSourceIdentity()
    {
        const string expected = $@"
{XMLDECL}
<DomainOsNvramSourceIdentity {XMLNS} />
";

        this.AssertXml<DomainOsNvramSourceIdentity>(expected);
    }

    [TestMethod]
    public void DomainOsNvramSourceAddress()
    {
        const string expected = $@"
{XMLDECL}
<DomainOsNvramSourceAddress {XMLNS} />
";

        this.AssertXml<DomainOsNvramSourceAddress>(expected);
    }

    [TestMethod]
    public void DomainOsNvramSourceMode()
    {
        var values = Enum.GetValues(typeof(DomainOsNvramSourceMode));
        Assert.HasCount(2, values);
    }

    [TestMethod]
    public void DomainOsNvramSourceProtocol()
    {
        var values = Enum.GetValues(typeof(DomainOsNvramSourceProtocol));
        Assert.HasCount(13, values);
    }

    [TestMethod]
    public void DomainOsNvramSourceSlices()
    {
        const string expected = $@"
{XMLDECL}
<DomainOsNvramSourceSlices {XMLNS} />
";

        this.AssertXml<DomainOsNvramSourceSlices>(expected);
    }

    [TestMethod]
    public void DomainOsNvramSourceSlicesSlice()
    {
        const string expected = $@"
{XMLDECL}
<DomainOsNvramSourceSlicesSlice {XMLNS} type=""storage"" offset=""0"" size=""0"" />
";

        this.AssertXml<DomainOsNvramSourceSlicesSlice>(expected);
    }

    [TestMethod]
    public void DomainOsNvramSourceSlicesSliceType()
    {
        var values = Enum.GetValues(typeof(DomainOsNvramSourceSlicesSliceType));
        Assert.HasCount(1, values);
    }

    [TestMethod]
    public void DomainOsNvramType()
    {
        var values = Enum.GetValues(typeof(DomainOsNvramType));
        Assert.HasCount(8, values);
    }

    [TestMethod]
    public void DomainOsType()
    {
        const string expected = $@"
{XMLDECL}
<DomainOsType {XMLNS} />
";

        this.AssertXml<DomainOsType>(expected);
    }

    [TestMethod]
    public void DomainOsTypeArch()
    {
        var values = Enum.GetValues(typeof(DomainOsTypeArch));
        Assert.HasCount(35, values);
    }

    [TestMethod]
    public void DomainPanic()
    {
        const string expected = $@"
{XMLDECL}
<panic {XMLNS} />
";

        this.AssertXml<DomainPanic>(expected);
    }

    [TestMethod]
    public void DomainPanicModel()
    {
        var values = Enum.GetValues(typeof(DomainPanicModel));
        Assert.HasCount(5, values);
    }

    [TestMethod]
    public void DomainParallel()
    {
        const string expected = $@"
{XMLDECL}
<parallel {XMLNS} type=""dbus"" />
";

        this.AssertXml<DomainParallel>(expected);
    }

    [TestMethod]
    public void DomainPerf()
    {
        const string expected = $@"
{XMLDECL}
<perf {XMLNS} />
";

        this.AssertXml<DomainPerf>(expected);
    }

    [TestMethod]
    public void DomainPerfEvent()
    {
        const string expected = $@"
{XMLDECL}
<DomainPerfEvent {XMLNS} name=""alignment_faults"" enabled=""no"" />
";

        this.AssertXml<DomainPerfEvent>(expected);
    }

    [TestMethod]
    public void DomainPerfEventName()
    {
        var values = Enum.GetValues(typeof(DomainPerfEventName));
        Assert.HasCount(22, values);
    }

    [TestMethod]
    public void DomainPm()
    {
        const string expected = $@"
{XMLDECL}
<pm {XMLNS} />
";

        this.AssertXml<DomainPm>(expected);
    }

    [TestMethod]
    public void DomainPmSuspendToDisk()
    {
        const string expected = $@"
{XMLDECL}
<DomainPmSuspendToDisk {XMLNS} />
";

        this.AssertXml<DomainPmSuspendToDisk>(expected);
    }

    [TestMethod]
    public void DomainPmSuspendToMem()
    {
        const string expected = $@"
{XMLDECL}
<DomainPmSuspendToMem {XMLNS} />
";

        this.AssertXml<DomainPmSuspendToMem>(expected);
    }

    [TestMethod]
    public void DomainPmu()
    {
        const string expected = $@"
{XMLDECL}
<pmu {XMLNS} />
";

        this.AssertXml<DomainPmu>(expected);
    }

    [TestMethod]
    public void DomainPstore()
    {
        const string expected = $@"
{XMLDECL}
<pstore {XMLNS} backend=""acpi-erst"" />
";

        this.AssertXml<DomainPstore>(expected);
    }

    [TestMethod]
    public void DomainPstoreBackend()
    {
        var values = Enum.GetValues(typeof(DomainPstoreBackend));
        Assert.HasCount(1, values);
    }

    [TestMethod]
    public void DomainQemucdevTgtDef()
    {
        const string expected = $@"
{XMLDECL}
<DomainQemucdevTgtDef {XMLNS} />
";

        this.AssertXml<DomainQemucdevTgtDef>(expected);
    }

    [TestMethod]
    public void DomainQemucdevSerialTgtModel()
    {
        const string expected = $@"
{XMLDECL}
<DomainQemucdevSerialTgtModel {XMLNS} name=""16550a"" />
";

        this.AssertXml<DomainQemucdevSerialTgtModel>(expected);
    }

    [TestMethod]
    public void DomainQemucdevSerialTgtModelName()
    {
        var values = Enum.GetValues(typeof(DomainQemucdevSerialTgtModelName));
        Assert.HasCount(9, values);
    }

    [TestMethod]
    public void DomainQemucdevTgtDefType()
    {
        var values = Enum.GetValues(typeof(DomainQemucdevTgtDefType));
        Assert.HasCount(15, values);
    }

    [TestMethod]
    public void DomainQemudeprecationBehavior()
    {
        var values = Enum.GetValues(typeof(DomainQemudeprecationBehavior));
        Assert.HasCount(4, values);
    }

    [TestMethod]
    public void DomainQemuoverridepropertyType()
    {
        var values = Enum.GetValues(typeof(DomainQemuoverridepropertyType));
        Assert.HasCount(5, values);
    }

    [TestMethod]
    public void DomainRedirdev()
    {
        const string expected = $@"
{XMLDECL}
<redirdev {XMLNS} bus=""usb"" type=""dbus"" />
";

        this.AssertXml<DomainRedirdev>(expected);
    }

    [TestMethod]
    public void DomainRedirdevBus()
    {
        var values = Enum.GetValues(typeof(DomainRedirdevBus));
        Assert.HasCount(1, values);
    }

    [TestMethod]
    public void DomainRedirfilter()
    {
        const string expected = $@"
{XMLDECL}
<redirfilter {XMLNS} />
";

        this.AssertXml<DomainRedirfilter>(expected);
    }

    [TestMethod]
    public void DomainRespartition()
    {
        const string expected = $@"
{XMLDECL}
<resource {XMLNS} />
";

        this.AssertXml<DomainRespartition>(expected);
    }

    [TestMethod]
    public void DomainRng()
    {
        const string expected = $@"
{XMLDECL}
<rng {XMLNS} model=""virtio"" />
";

        this.AssertXml<DomainRng>(expected);
    }

    [TestMethod]
    public void DomainRngDriver()
    {
        const string expected = $@"
{XMLDECL}
<DomainRngDriver {XMLNS} />
";

        this.AssertXml<DomainRngDriver>(expected);
    }

    [TestMethod]
    public void DomainRngModel()
    {
        var values = Enum.GetValues(typeof(DomainRngModel));
        Assert.HasCount(3, values);
    }

    [TestMethod]
    public void DomainRngRate()
    {
        const string expected = $@"
{XMLDECL}
<DomainRngRate {XMLNS} bytes=""0"" />
";

        this.AssertXml<DomainRngRate>(expected);
    }

    [TestMethod]
    public void DomainRom()
    {
        const string expected = $@"
{XMLDECL}
<DomainRom {XMLNS} />
";

        this.AssertXml<DomainRom>(expected);
    }

    [TestMethod]
    public void DomainSbbc()
    {
        const string expected = $@"
{XMLDECL}
<sbbc {XMLNS} value=""broken"" />
";

        this.AssertXml<DomainSbbc>(expected);
    }

    [TestMethod]
    public void DomainSbbcValue()
    {
        var values = Enum.GetValues(typeof(DomainSbbcValue));
        Assert.HasCount(3, values);
    }

    [TestMethod]
    public void DomainSeclabel()
    {
        const string expected = $@"
{XMLDECL}
<seclabel {XMLNS} />
";

        this.AssertXml<DomainSeclabel>(expected);
    }

    [TestMethod]
    public void DomainSeclabelType()
    {
        var values = Enum.GetValues(typeof(DomainSeclabelType));
        Assert.HasCount(3, values);
    }

    [TestMethod]
    public void DomainSerial()
    {
        const string expected = $@"
{XMLDECL}
<serial {XMLNS} type=""dbus"" />
";

        this.AssertXml<DomainSerial>(expected);
    }

    [TestMethod]
    public void DomainSerialLog()
    {
        const string expected = $@"
{XMLDECL}
<DomainSerialLog {XMLNS} />
";

        this.AssertXml<DomainSerialLog>(expected);
    }

    [TestMethod]
    public void DomainSerialProtocol()
    {
        const string expected = $@"
{XMLDECL}
<DomainSerialProtocol {XMLNS} />
";

        this.AssertXml<DomainSerialProtocol>(expected);
    }

    [TestMethod]
    public void DomainSerialProtocolType()
    {
        var values = Enum.GetValues(typeof(DomainSerialProtocolType));
        Assert.HasCount(4, values);
    }

    [TestMethod]
    public void DomainSerialSource()
    {
        const string expected = $@"
{XMLDECL}
<DomainSerialSource {XMLNS} />
";

        this.AssertXml<DomainSerialSource>(expected);
    }

    [TestMethod]
    public void DomainSgIo()
    {
        var values = Enum.GetValues(typeof(DomainSgIo));
        Assert.HasCount(2, values);
    }

    [TestMethod]
    public void DomainShmem()
    {
        const string expected = $@"
{XMLDECL}
<shmem {XMLNS} />
";

        this.AssertXml<DomainShmem>(expected);
    }

    [TestMethod]
    public void DomainShmemModel()
    {
        const string expected = $@"
{XMLDECL}
<DomainShmemModel {XMLNS} type=""ivshmem"" />
";

        this.AssertXml<DomainShmemModel>(expected);
    }

    [TestMethod]
    public void DomainShmemMsi()
    {
        const string expected = $@"
{XMLDECL}
<DomainShmemMsi {XMLNS} />
";

        this.AssertXml<DomainShmemMsi>(expected);
    }

    [TestMethod]
    public void DomainShmemModelType()
    {
        var values = Enum.GetValues(typeof(DomainShmemModelType));
        Assert.HasCount(3, values);
    }

    [TestMethod]
    public void DomainShmemRole()
    {
        var values = Enum.GetValues(typeof(DomainShmemRole));
        Assert.HasCount(2, values);
    }

    [TestMethod]
    public void DomainShmemServer()
    {
        const string expected = $@"
{XMLDECL}
<DomainShmemServer {XMLNS} />
";

        this.AssertXml<DomainShmemServer>(expected);
    }

    [TestMethod]
    public void DomainSmartcard()
    {
        const string expected = $@"
{XMLDECL}
<smartcard {XMLNS} mode=""host"" />
";

        this.AssertXml<DomainSmartcard>(expected);
    }

    [TestMethod]
    public void DomainSmartcardMode()
    {
        var values = Enum.GetValues(typeof(DomainSmartcardMode));
        Assert.HasCount(3, values);
    }

    [TestMethod]
    public void DomainSmbios()
    {
        const string expected = $@"
{XMLDECL}
<smbios {XMLNS} mode=""emulate"" />
";

        this.AssertXml<DomainSmbios>(expected);
    }

    [TestMethod]
    public void DomainSmbiosMode()
    {
        var values = Enum.GetValues(typeof(DomainSmbiosMode));
        Assert.HasCount(3, values);
    }

    [TestMethod]
    public void DomainSnapshot()
    {
        var values = Enum.GetValues(typeof(DomainSnapshot));
        Assert.HasCount(4, values);
    }

    [TestMethod]
    public void DomainSound()
    {
        const string expected = $@"
{XMLDECL}
<sound {XMLNS} model=""ac97"" />
";

        this.AssertXml<DomainSound>(expected);
    }

    [TestMethod]
    public void DomainSoundAudio()
    {
        const string expected = $@"
{XMLDECL}
<DomainSoundAudio {XMLNS} />
";

        this.AssertXml<DomainSoundAudio>(expected);
    }

    [TestMethod]
    public void DomainSoundDriver()
    {
        const string expected = $@"
{XMLDECL}
<DomainSoundDriver {XMLNS} />
";

        this.AssertXml<DomainSoundDriver>(expected);
    }

    [TestMethod]
    public void DomainSoundModel()
    {
        var values = Enum.GetValues(typeof(DomainSoundModel));
        Assert.HasCount(9, values);
    }

    [TestMethod]
    public void DomainStartupPolicy()
    {
        var values = Enum.GetValues(typeof(DomainStartupPolicy));
        Assert.HasCount(3, values);
    }

    [TestMethod]
    public void DomainSysinfo()
    {
        const string expected = $@"
{XMLDECL}
<sysinfo {XMLNS} type=""fwcfg"" />
";

        this.AssertXml<DomainSysinfo>(expected);
    }

    [TestMethod]
    public void DomainSysinfoType()
    {
        var values = Enum.GetValues(typeof(DomainSysinfoType));
        Assert.HasCount(2, values);
    }

    [TestMethod]
    public void DomainTcgfeatures()
    {
        const string expected = $@"
{XMLDECL}
<tcg {XMLNS} />
";

        this.AssertXml<DomainTcgfeatures>(expected);
    }

    [TestMethod]
    public void DomainTeaming()
    {
        const string expected = $@"
{XMLDECL}
<DomainTeaming {XMLNS} type=""persistent"" />
";

        this.AssertXml<DomainTeaming>(expected);
    }

    [TestMethod]
    public void DomainTeamingType()
    {
        var values = Enum.GetValues(typeof(DomainTeamingType));
        Assert.HasCount(2, values);
    }

    [TestMethod]
    public void DomainThrottlefilters()
    {
        const string expected = $@"
{XMLDECL}
<DomainThrottlefilters {XMLNS} />
";

        this.AssertXml<DomainThrottlefilters>(expected);
    }

    [TestMethod]
    public void DomainThrottlefiltersThrottlefilter()
    {
        const string expected = $@"
{XMLDECL}
<DomainThrottlefiltersThrottlefilter {XMLNS} />
";

        this.AssertXml<DomainThrottlefiltersThrottlefilter>(expected);
    }

    [TestMethod]
    public void DomainThrottlegroup()
    {
        const string expected = $@"
{XMLDECL}
<throttlegroup {XMLNS} />
";

        this.AssertXml<DomainThrottlegroup>(expected);
    }

    [TestMethod]
    public void DomainThrottlegroups()
    {
        const string expected = $@"
{XMLDECL}
<DomainThrottlegroups {XMLNS} />
";

        this.AssertXml<DomainThrottlegroups>(expected);
    }

    [TestMethod]
    public void DomainTimer()
    {
        const string expected = $@"
{XMLDECL}
<timer {XMLNS} name=""armvtimer"" />
";

        this.AssertXml<DomainTimer>(expected);
    }

    [TestMethod]
    public void DomainTimerCatchup()
    {
        const string expected = $@"
{XMLDECL}
<DomainTimerCatchup {XMLNS} />
";

        this.AssertXml<DomainTimerCatchup>(expected);
    }

    [TestMethod]
    public void DomainTimerTickpolicy()
    {
        var values = Enum.GetValues(typeof(DomainTimerTickpolicy));
        Assert.HasCount(4, values);
    }

    [TestMethod]
    public void DomainTimerMode()
    {
        var values = Enum.GetValues(typeof(DomainTimerMode));
        Assert.HasCount(5, values);
    }

    [TestMethod]
    public void DomainTimerName()
    {
        var values = Enum.GetValues(typeof(DomainTimerName));
        Assert.HasCount(8, values);
    }

    [TestMethod]
    public void DomainTimerTrack()
    {
        var values = Enum.GetValues(typeof(DomainTimerTrack));
        Assert.HasCount(4, values);
    }

    [TestMethod]
    public void DomainTpm()
    {
        const string expected = $@"
{XMLDECL}
<tpm {XMLNS} />
";

        this.AssertXml<DomainTpm>(expected);
    }

    [TestMethod]
    public void DomainTpmBackend()
    {
        const string expected = $@"
{XMLDECL}
<DomainTpmBackend {XMLNS} type=""emulator"" />
";

        this.AssertXml<DomainTpmBackend>(expected);
    }

    [TestMethod]
    public void DomainTpmBackendActivePcrBanks()
    {
        const string expected = $@"
{XMLDECL}
<DomainTpmBackendActivePcrBanks {XMLNS} />
";

        this.AssertXml<DomainTpmBackendActivePcrBanks>(expected);
    }

    [TestMethod]
    public void DomainTpmBackendActivePcrBanksSha1()
    {
        const string expected = $@"
{XMLDECL}
<DomainTpmBackendActivePcrBanksSha1 {XMLNS} />
";

        this.AssertXml<DomainTpmBackendActivePcrBanksSha1>(expected);
    }

    [TestMethod]
    public void DomainTpmBackendActivePcrBanksSha256()
    {
        const string expected = $@"
{XMLDECL}
<DomainTpmBackendActivePcrBanksSha256 {XMLNS} />
";

        this.AssertXml<DomainTpmBackendActivePcrBanksSha256>(expected);
    }

    [TestMethod]
    public void DomainTpmBackendActivePcrBanksSha384()
    {
        const string expected = $@"
{XMLDECL}
<DomainTpmBackendActivePcrBanksSha384 {XMLNS} />
";

        this.AssertXml<DomainTpmBackendActivePcrBanksSha384>(expected);
    }

    [TestMethod]
    public void DomainTpmBackendActivePcrBanksSha512()
    {
        const string expected = $@"
{XMLDECL}
<DomainTpmBackendActivePcrBanksSha512 {XMLNS} />
";

        this.AssertXml<DomainTpmBackendActivePcrBanksSha512>(expected);
    }

    [TestMethod]
    public void DomainTpmBackendDevice()
    {
        const string expected = $@"
{XMLDECL}
<DomainTpmBackendDevice {XMLNS} />
";

        this.AssertXml<DomainTpmBackendDevice>(expected);
    }

    [TestMethod]
    public void DomainTpmBackendEncryption()
    {
        const string expected = $@"
{XMLDECL}
<DomainTpmBackendEncryption {XMLNS} />
";

        this.AssertXml<DomainTpmBackendEncryption>(expected);
    }

    [TestMethod]
    public void DomainTpmBackendProfile()
    {
        const string expected = $@"
{XMLDECL}
<DomainTpmBackendProfile {XMLNS} />
";

        this.AssertXml<DomainTpmBackendProfile>(expected);
    }

    [TestMethod]
    public void DomainTpmBackendSource()
    {
        const string expected = $@"
{XMLDECL}
<DomainTpmBackendSource {XMLNS} type=""dir"" />
";

        this.AssertXml<DomainTpmBackendSource>(expected);
    }

    [TestMethod]
    public void DomainTpmBackendSourceMode()
    {
        var values = Enum.GetValues(typeof(DomainTpmBackendSourceMode));
        Assert.HasCount(1, values);
    }

    [TestMethod]
    public void DomainTpmBackendSourceType()
    {
        var values = Enum.GetValues(typeof(DomainTpmBackendSourceType));
        Assert.HasCount(3, values);
    }

    [TestMethod]
    public void DomainTpmBackendType()
    {
        var values = Enum.GetValues(typeof(DomainTpmBackendType));
        Assert.HasCount(3, values);
    }

    [TestMethod]
    public void DomainTpmBackendVersion()
    {
        var values = Enum.GetValues(typeof(DomainTpmBackendVersion));
        Assert.HasCount(2, values);
    }

    [TestMethod]
    public void DomainTpmModel()
    {
        var values = Enum.GetValues(typeof(DomainTpmModel));
        Assert.HasCount(4, values);
    }

    [TestMethod]
    public void DomainUsbdevfilter()
    {
        const string expected = $@"
{XMLDECL}
<DomainUsbdevfilter {XMLNS} allow=""no"" />
";

        this.AssertXml<DomainUsbdevfilter>(expected);
    }

    [TestMethod]
    public void DomainUsbmaster()
    {
        const string expected = $@"
{XMLDECL}
<DomainUsbmaster {XMLNS} />
";

        this.AssertXml<DomainUsbmaster>(expected);
    }

    [TestMethod]
    public void DomainVcpu()
    {
        const string expected = $@"
{XMLDECL}
<DomainVcpu {XMLNS} />
";

        this.AssertXml<DomainVcpu>(expected);
    }

    [TestMethod]
    public void DomainVcpuPlacement()
    {
        var values = Enum.GetValues(typeof(DomainVcpuPlacement));
        Assert.HasCount(2, values);
    }

    [TestMethod]
    public void DomainVcpus()
    {
        const string expected = $@"
{XMLDECL}
<DomainVcpus {XMLNS} />
";

        this.AssertXml<DomainVcpus>(expected);
    }

    [TestMethod]
    public void DomainVcpusVcpu()
    {
        const string expected = $@"
{XMLDECL}
<DomainVcpusVcpu {XMLNS} id=""0"" enabled=""no"" />
";

        this.AssertXml<DomainVcpusVcpu>(expected);
    }

    [TestMethod]
    public void DomainVideo()
    {
        const string expected = $@"
{XMLDECL}
<video {XMLNS} />
";

        this.AssertXml<DomainVideo>(expected);
    }

    [TestMethod]
    public void DomainVideoDriver()
    {
        const string expected = $@"
{XMLDECL}
<DomainVideoDriver {XMLNS} />
";

        this.AssertXml<DomainVideoDriver>(expected);
    }

    [TestMethod]
    public void DomainVideoDriverName()
    {
        var values = Enum.GetValues(typeof(DomainVideoDriverName));
        Assert.HasCount(2, values);
    }

    [TestMethod]
    public void DomainVideoDriverVgaconf()
    {
        var values = Enum.GetValues(typeof(DomainVideoDriverVgaconf));
        Assert.HasCount(3, values);
    }

    [TestMethod]
    public void DomainVideoModel()
    {
        const string expected = $@"
{XMLDECL}
<DomainVideoModel {XMLNS} type=""bochs"" />
";

        this.AssertXml<DomainVideoModel>(expected);
    }

    [TestMethod]
    public void DomainVideoModelAcceleration()
    {
        const string expected = $@"
{XMLDECL}
<DomainVideoModelAcceleration {XMLNS} />
";

        this.AssertXml<DomainVideoModelAcceleration>(expected);
    }

    [TestMethod]
    public void DomainVideoModelResolution()
    {
        const string expected = $@"
{XMLDECL}
<DomainVideoModelResolution {XMLNS} x=""0"" y=""0"" />
";

        this.AssertXml<DomainVideoModelResolution>(expected);
    }

    [TestMethod]
    public void DomainVideoModelType()
    {
        var values = Enum.GetValues(typeof(DomainVideoModelType));
        Assert.HasCount(11, values);
    }

    [TestMethod]
    public void DomainVirtioTargetState()
    {
        var values = Enum.GetValues(typeof(DomainVirtioTargetState));
        Assert.HasCount(2, values);
    }

    [TestMethod]
    public void DomainVmcoreinfo()
    {
        const string expected = $@"
{XMLDECL}
<vmcoreinfo {XMLNS} />
";

        this.AssertXml<DomainVmcoreinfo>(expected);
    }

    [TestMethod]
    public void DomainVsock()
    {
        const string expected = $@"
{XMLDECL}
<vsock {XMLNS} />
";

        this.AssertXml<DomainVsock>(expected);
    }

    [TestMethod]
    public void DomainVsockCid()
    {
        const string expected = $@"
{XMLDECL}
<DomainVsockCid {XMLNS} />
";

        this.AssertXml<DomainVsockCid>(expected);
    }

    [TestMethod]
    public void DomainVsockDriver()
    {
        const string expected = $@"
{XMLDECL}
<DomainVsockDriver {XMLNS} />
";

        this.AssertXml<DomainVsockDriver>(expected);
    }

    [TestMethod]
    public void DomainVsockModel()
    {
        var values = Enum.GetValues(typeof(DomainVsockModel));
        Assert.HasCount(3, values);
    }

    [TestMethod]
    public void DomainWatchdog()
    {
        const string expected = $@"
{XMLDECL}
<watchdog {XMLNS} model=""diag288"" />
";

        this.AssertXml<DomainWatchdog>(expected);
    }

    [TestMethod]
    public void DomainWatchdogAction()
    {
        var values = Enum.GetValues(typeof(DomainWatchdogAction));
        Assert.HasCount(7, values);
    }

    [TestMethod]
    public void DomainWatchdogModel()
    {
        var values = Enum.GetValues(typeof(DomainWatchdogModel));
        Assert.HasCount(4, values);
    }

    [TestMethod]
    public void DomainXen()
    {
        const string expected = $@"
{XMLDECL}
<xen {XMLNS} />
";

        this.AssertXml<DomainXen>(expected);
    }

    [TestMethod]
    public void DomainXenE820Host()
    {
        const string expected = $@"
{XMLDECL}
<DomainXenE820Host {XMLNS} state=""off"" />
";

        this.AssertXml<DomainXenE820Host>(expected);
    }

    [TestMethod]
    public void DomainXenPassthrough()
    {
        const string expected = $@"
{XMLDECL}
<DomainXenPassthrough {XMLNS} state=""off"" />
";

        this.AssertXml<DomainXenPassthrough>(expected);
    }

    [TestMethod]
    public void LockfailureOptions()
    {
        var values = Enum.GetValues(typeof(LockfailureOptions));
        Assert.HasCount(4, values);
    }

    [TestMethod]
    public void LxcDomainLxcsharens()
    {
        const string expected = $@"
{XMLDECL}
<namespace {XMLNS} />
";

        this.AssertXml<LxcDomainLxcsharens>(expected);
    }

    [TestMethod]
    public void LxcDomainLxcsharensShareipc()
    {
        const string expected = $@"
{XMLDECL}
<LxcDomainLxcsharensShareipc {XMLNS} type=""name"" />
";

        this.AssertXml<LxcDomainLxcsharensShareipc>(expected);
    }

    [TestMethod]
    public void LxcDomainLxcsharensSharenet()
    {
        const string expected = $@"
{XMLDECL}
<LxcDomainLxcsharensSharenet {XMLNS} type=""name"" />
";

        this.AssertXml<LxcDomainLxcsharensSharenet>(expected);
    }

    [TestMethod]
    public void LxcDomainLxcsharensShareuts()
    {
        const string expected = $@"
{XMLDECL}
<LxcDomainLxcsharensShareuts {XMLNS} type=""name"" />
";

        this.AssertXml<LxcDomainLxcsharensShareuts>(expected);
    }

    [TestMethod]
    public void OffOptions()
    {
        var values = Enum.GetValues(typeof(OffOptions));
        Assert.HasCount(4, values);
    }

    [TestMethod]
    public void PflashFormatTypes()
    {
        var values = Enum.GetValues(typeof(PflashFormatTypes));
        Assert.HasCount(2, values);
    }

    [TestMethod]
    public void QemuDomainQemucapabilities()
    {
        const string expected = $@"
{XMLDECL}
<capabilities {XMLNS} />
";

        this.AssertXml<QemuDomainQemucapabilities>(expected);
    }

    [TestMethod]
    public void QemuDomainQemucapabilitiesAdd()
    {
        const string expected = $@"
{XMLDECL}
<QemuDomainQemucapabilitiesAdd {XMLNS} />
";

        this.AssertXml<QemuDomainQemucapabilitiesAdd>(expected);
    }

    [TestMethod]
    public void QemuDomainQemucapabilitiesDel()
    {
        const string expected = $@"
{XMLDECL}
<QemuDomainQemucapabilitiesDel {XMLNS} />
";

        this.AssertXml<QemuDomainQemucapabilitiesDel>(expected);
    }

    [TestMethod]
    public void QemuDomainQemucmdline()
    {
        const string expected = $@"
{XMLDECL}
<commandline {XMLNS} />
";

        this.AssertXml<QemuDomainQemucmdline>(expected);
    }

    [TestMethod]
    public void QemuDomainQemucmdlineArg()
    {
        const string expected = $@"
{XMLDECL}
<QemuDomainQemucmdlineArg {XMLNS} />
";

        this.AssertXml<QemuDomainQemucmdlineArg>(expected);
    }

    [TestMethod]
    public void QemuDomainQemucmdlineEnv()
    {
        const string expected = $@"
{XMLDECL}
<QemuDomainQemucmdlineEnv {XMLNS} />
";

        this.AssertXml<QemuDomainQemucmdlineEnv>(expected);
    }

    [TestMethod]
    public void QemuDomainQemudeprecation()
    {
        const string expected = $@"
{XMLDECL}
<deprecation {XMLNS} behavior=""crash"" />
";

        this.AssertXml<QemuDomainQemudeprecation>(expected);
    }

    [TestMethod]
    public void QemuDomainQemuoverride()
    {
        const string expected = $@"
{XMLDECL}
<override {XMLNS} />
";

        this.AssertXml<QemuDomainQemuoverride>(expected);
    }

    [TestMethod]
    public void QemuDomainQemuoverrideDevice()
    {
        const string expected = $@"
{XMLDECL}
<QemuDomainQemuoverrideDevice {XMLNS} />
";

        this.AssertXml<QemuDomainQemuoverrideDevice>(expected);
    }

    [TestMethod]
    public void QemuDomainQemuoverrideDeviceFrontend()
    {
        const string expected = $@"
{XMLDECL}
<QemuDomainQemuoverrideDeviceFrontend {XMLNS} />
";

        this.AssertXml<QemuDomainQemuoverrideDeviceFrontend>(expected);
    }

    [TestMethod]
    public void QemuDomainQemuoverrideproperty()
    {
        const string expected = $@"
{XMLDECL}
<QemuDomainQemuoverrideproperty {XMLNS} type=""bool"" />
";

        this.AssertXml<QemuDomainQemuoverrideproperty>(expected);
    }

    [TestMethod]
    public void SysinfoBaseBoardName()
    {
        var values = Enum.GetValues(typeof(SysinfoBaseBoardName));
        Assert.HasCount(6, values);
    }

    [TestMethod]
    public void SysinfoBiosName()
    {
        var values = Enum.GetValues(typeof(SysinfoBiosName));
        Assert.HasCount(4, values);
    }

    [TestMethod]
    public void SysinfoChassisName()
    {
        var values = Enum.GetValues(typeof(SysinfoChassisName));
        Assert.HasCount(5, values);
    }

    [TestMethod]
    public void SysinfoMemoryName()
    {
        var values = Enum.GetValues(typeof(SysinfoMemoryName));
        Assert.HasCount(10, values);
    }

    [TestMethod]
    public void SysinfoProcessorName()
    {
        var values = Enum.GetValues(typeof(SysinfoProcessorName));
        Assert.HasCount(11, values);
    }

    [TestMethod]
    public void SysinfoSystemName()
    {
        var values = Enum.GetValues(typeof(SysinfoSystemName));
        Assert.HasCount(7, values);
    }

    [TestMethod]
    public void SysinfoType()
    {
        var values = Enum.GetValues(typeof(SysinfoType));
        Assert.HasCount(2, values);
    }

    [TestMethod]
    public void SysinfoBaseBoard()
    {
        const string expected = $@"
{XMLDECL}
<SysinfoBaseBoard {XMLNS} />
";

        this.AssertXml<SysinfoBaseBoard>(expected);
    }

    [TestMethod]
    public void SysinfoBaseBoardEntry()
    {
        const string expected = $@"
{XMLDECL}
<SysinfoBaseBoardEntry {XMLNS} name=""asset"" />
";

        this.AssertXml<SysinfoBaseBoardEntry>(expected);
    }

    [TestMethod]
    public void SysinfoBios()
    {
        const string expected = $@"
{XMLDECL}
<SysinfoBios {XMLNS} />
";

        this.AssertXml<SysinfoBios>(expected);
    }

    [TestMethod]
    public void SysinfoBiosEntry()
    {
        const string expected = $@"
{XMLDECL}
<SysinfoBiosEntry {XMLNS} name=""date"" />
";

        this.AssertXml<SysinfoBiosEntry>(expected);
    }

    [TestMethod]
    public void SysinfoChassis()
    {
        const string expected = $@"
{XMLDECL}
<SysinfoChassis {XMLNS} />
";

        this.AssertXml<SysinfoChassis>(expected);
    }

    [TestMethod]
    public void SysinfoChassisEntry()
    {
        const string expected = $@"
{XMLDECL}
<SysinfoChassisEntry {XMLNS} name=""asset"" />
";

        this.AssertXml<SysinfoChassisEntry>(expected);
    }

    [TestMethod]
    public void SysinfoMemoryDevice()
    {
        const string expected = $@"
{XMLDECL}
<SysinfoMemoryDevice {XMLNS} />
";

        this.AssertXml<SysinfoMemoryDevice>(expected);
    }

    [TestMethod]
    public void SysinfoMemoryDeviceEntry()
    {
        const string expected = $@"
{XMLDECL}
<SysinfoMemoryDeviceEntry {XMLNS} name=""bank_locator"" />
";

        this.AssertXml<SysinfoMemoryDeviceEntry>(expected);
    }

    [TestMethod]
    public void SysinfoSysinfoFwcfgEntry()
    {
        const string expected = $@"
{XMLDECL}
<entry {XMLNS} />
";

        this.AssertXml<SysinfoSysinfoFwcfgEntry>(expected);
    }

    [TestMethod]
    public void SysinfoOemStrings()
    {
        const string expected = $@"
{XMLDECL}
<SysinfoOemStrings {XMLNS} />
";

        this.AssertXml<SysinfoOemStrings>(expected);
    }

    [TestMethod]
    public void SysinfoProcessor()
    {
        const string expected = $@"
{XMLDECL}
<SysinfoProcessor {XMLNS} />
";

        this.AssertXml<SysinfoProcessor>(expected);
    }

    [TestMethod]
    public void SysinfoProcessorEntry()
    {
        const string expected = $@"
{XMLDECL}
<SysinfoProcessorEntry {XMLNS} name=""external_clock"" />
";

        this.AssertXml<SysinfoProcessorEntry>(expected);
    }

    [TestMethod]
    public void SysinfoSystem()
    {
        const string expected = $@"
{XMLDECL}
<SysinfoSystem {XMLNS} />
";

        this.AssertXml<SysinfoSystem>(expected);
    }

    [TestMethod]
    public void SysinfoSystemEntry()
    {
        const string expected = $@"
{XMLDECL}
<SysinfoSystemEntry {XMLNS} name=""family"" />
";

        this.AssertXml<SysinfoSystemEntry>(expected);
    }

    [TestMethod]
    public void XenDomainXencmdline()
    {
        const string expected = $@"
{XMLDECL}
<commandline {XMLNS} />
";

        this.AssertXml<XenDomainXencmdline>(expected);
    }

    [TestMethod]
    public void XenDomainXencmdlineArg()
    {
        const string expected = $@"
{XMLDECL}
<XenDomainXencmdlineArg {XMLNS} />
";

        this.AssertXml<XenDomainXencmdlineArg>(expected);
    }
}
