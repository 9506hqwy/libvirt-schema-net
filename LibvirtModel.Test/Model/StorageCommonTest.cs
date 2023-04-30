namespace LibvirtModel.Test.Model;

[TestClass]
public class StorageCommonTest : TestBase
{
    [TestMethod]
    public void StorageClusterSize()
    {
        const string expected = $@"
{XMLDECL}
<clusterSize {XMLNS} />
";

        this.AssertXml<StorageClusterSize>(expected);
    }

    [TestMethod]
    public void StorageEncryption()
    {
        const string expected = $@"
{XMLDECL}
<encryption {XMLNS} format=""default"" />
";

        this.AssertXml<StorageEncryption>(expected);
    }

    [TestMethod]
    public void StorageEncryptionCipher()
    {
        const string expected = $@"
{XMLDECL}
<StorageEncryptionCipher {XMLNS} size=""0"" />
";

        this.AssertXml<StorageEncryptionCipher>(expected);
    }

    [TestMethod]
    public void StorageEncryptionEngine()
    {
        var values = Enum.GetValues(typeof(StorageEncryptionEngine));
        Assert.AreEqual(2, values.Length);
    }

    [TestMethod]
    public void StorageEncryptionFormat()
    {
        var values = Enum.GetValues(typeof(StorageEncryptionFormat));
        Assert.AreEqual(5, values.Length);
    }

    [TestMethod]
    public void StorageEncryptionIvgen()
    {
        const string expected = $@"
{XMLDECL}
<StorageEncryptionIvgen {XMLNS} />
";

        this.AssertXml<StorageEncryptionIvgen>(expected);
    }

    [TestMethod]
    public void StorageFileFormatFeatures()
    {
        const string expected = $@"
{XMLDECL}
<features {XMLNS} />
";

        this.AssertXml<StorageFileFormatFeatures>(expected);
    }

    [TestMethod]
    public void StorageFileFormatFeaturesExtendedL2()
    {
        const string expected = $@"
{XMLDECL}
<StorageFileFormatFeaturesExtendedL2 {XMLNS} />
";

        this.AssertXml<StorageFileFormatFeaturesExtendedL2>(expected);
    }

    [TestMethod]
    public void StorageFileFormatFeaturesLazyRefcounts()
    {
        const string expected = $@"
{XMLDECL}
<StorageFileFormatFeaturesLazyRefcounts {XMLNS} />
";

        this.AssertXml<StorageFileFormatFeaturesLazyRefcounts>(expected);
    }

    [TestMethod]
    public void StorageInitiatorinfo()
    {
        const string expected = $@"
{XMLDECL}
<initiator {XMLNS} />
";

        this.AssertXml<StorageInitiatorinfo>(expected);
    }

    [TestMethod]
    public void StorageInitiatorinfoIqn()
    {
        const string expected = $@"
{XMLDECL}
<StorageInitiatorinfoIqn {XMLNS} />
";

        this.AssertXml<StorageInitiatorinfoIqn>(expected);
    }

    [TestMethod]
    public void StoragePermissions()
    {
        const string expected = $@"
{XMLDECL}
<StoragePermissions {XMLNS} />
";

        this.AssertXml<StoragePermissions>(expected);
    }

    [TestMethod]
    public void StorageReconnect()
    {
        const string expected = $@"
{XMLDECL}
<StorageReconnect {XMLNS} />
";

        this.AssertXml<StorageReconnect>(expected);
    }

    [TestMethod]
    public void StorageReservations()
    {
        const string expected = $@"
{XMLDECL}
<StorageReservations {XMLNS} />
";

        this.AssertXml<StorageReservations>(expected);
    }

    [TestMethod]
    public void StorageUnixSocketSource()
    {
        const string expected = $@"
{XMLDECL}
<StorageUnixSocketSource {XMLNS} type=""unix"" mode=""client"" />
";

        this.AssertXml<StorageUnixSocketSource>(expected);
    }

    [TestMethod]
    public void StorageUnixSocketSourceMode()
    {
        var values = Enum.GetValues(typeof(StorageUnixSocketSourceMode));
        Assert.AreEqual(2, values.Length);
    }

    [TestMethod]
    public void StorageUnixSocketSourceType()
    {
        var values = Enum.GetValues(typeof(StorageUnixSocketSourceType));
        Assert.AreEqual(1, values.Length);
    }

    [TestMethod]
    public void StorageSecret()
    {
        const string expected = $@"
{XMLDECL}
<StorageSecret {XMLNS} type=""passphrase"" />
";

        this.AssertXml<StorageSecret>(expected);
    }

    [TestMethod]
    public void StorageSecretType()
    {
        var values = Enum.GetValues(typeof(StorageSecretType));
        Assert.AreEqual(1, values.Length);
    }
}
