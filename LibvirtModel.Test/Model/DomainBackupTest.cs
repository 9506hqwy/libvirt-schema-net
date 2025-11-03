namespace LibvirtModel.Test.Model;

[TestClass]
public class DomainBackupTest : TestBase
{
    [TestMethod]
    public void Domainbackup()
    {
        const string expected = $@"
{XMLDECL}
<domainbackup {XMLNS} />
";

        this.AssertXml<Domainbackup>(expected);
    }

    [TestMethod]
    public void DomainbackupDisks()
    {
        const string expected = $@"
{XMLDECL}
<DomainbackupDisks {XMLNS} />
";

        this.AssertXml<DomainbackupDisks>(expected);
    }

    [TestMethod]
    public void DomainbackupDisksDisk()
    {
        const string expected = $@"
{XMLDECL}
<DomainbackupDisksDisk {XMLNS} />
";

        this.AssertXml<DomainbackupDisksDisk>(expected);
    }

    [TestMethod]
    public void DomainbackupDisksDiskBackup()
    {
        var values = Enum.GetValues(typeof(DomainbackupDisksDiskBackup));
        Assert.HasCount(2, values);
    }

    [TestMethod]
    public void DomainbackupDisksDiskBackupmode()
    {
        var values = Enum.GetValues(typeof(DomainbackupDisksDiskBackupmode));
        Assert.HasCount(2, values);
    }

    [TestMethod]
    public void DomainbackupDisksDiskDriver()
    {
        const string expected = $@"
{XMLDECL}
<DomainbackupDisksDiskDriver {XMLNS} type=""bochs"" />
";

        this.AssertXml<DomainbackupDisksDiskDriver>(expected);
    }

    [TestMethod]
    public void DomainbackupDisksDiskDriverType()
    {
        var values = Enum.GetValues(typeof(DomainbackupDisksDiskDriverType));
        Assert.HasCount(17, values);
    }

    [TestMethod]
    public void DomainbackupDisksDiskScratch()
    {
        const string expected = $@"
{XMLDECL}
<DomainbackupDisksDiskScratch {XMLNS} />
";

        this.AssertXml<DomainbackupDisksDiskScratch>(expected);
    }

    [TestMethod]
    public void DomainbackupDisksDiskTarget()
    {
        const string expected = $@"
{XMLDECL}
<DomainbackupDisksDiskTarget {XMLNS} />
";

        this.AssertXml<DomainbackupDisksDiskTarget>(expected);
    }

    [TestMethod]
    public void DomainbackupBackupEncryption()
    {
        const string expected = $@"
{XMLDECL}
<DomainbackupBackupEncryption {XMLNS} format=""luks"" />
";

        this.AssertXml<DomainbackupBackupEncryption>(expected);
    }

    [TestMethod]
    public void DomainbackupBackupEncryptionCipher()
    {
        const string expected = $@"
{XMLDECL}
<DomainbackupBackupEncryptionCipher {XMLNS} size=""0"" />
";

        this.AssertXml<DomainbackupBackupEncryptionCipher>(expected);
    }

    [TestMethod]
    public void DomainbackupBackupEncryptionEngine()
    {
        var values = Enum.GetValues(typeof(DomainbackupBackupEncryptionEngine));
        Assert.HasCount(1, values);
    }

    [TestMethod]
    public void DomainbackupBackupEncryptionFormat()
    {
        var values = Enum.GetValues(typeof(DomainbackupBackupEncryptionFormat));
        Assert.HasCount(1, values);
    }

    [TestMethod]
    public void DomainbackupBackupEncryptionIvgen()
    {
        const string expected = $@"
{XMLDECL}
<DomainbackupBackupEncryptionIvgen {XMLNS} />
";

        this.AssertXml<DomainbackupBackupEncryptionIvgen>(expected);
    }

    [TestMethod]
    public void DomainbackupDisksDiskType()
    {
        var values = Enum.GetValues(typeof(DomainbackupDisksDiskType));
        Assert.HasCount(2, values);
    }

    [TestMethod]
    public void DomainbackupMode()
    {
        var values = Enum.GetValues(typeof(DomainbackupMode));
        Assert.HasCount(2, values);
    }

    [TestMethod]
    public void DomainbackupServer()
    {
        const string expected = $@"
{XMLDECL}
<DomainbackupServer {XMLNS} />
";

        this.AssertXml<DomainbackupServer>(expected);
    }

    [TestMethod]
    public void DomainbackupServerTransport()
    {
        var values = Enum.GetValues(typeof(DomainbackupServerTransport));
        Assert.HasCount(3, values);
    }
}
