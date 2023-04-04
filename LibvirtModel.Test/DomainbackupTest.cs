namespace LibvirtModel.Test;

[TestClass]
public class DomainbackupTest
{
    [TestMethod]
    public void MinTest()
    {
        var backup = TestUtility.Deserialize<Domainbackup>("min.xml");
        Assert.IsNotNull(backup);
        Assert.AreEqual(DomainbackupMode.Pull, backup.Mode);
        Assert.AreEqual(DomainbackupServerTransport.Unix, backup.Server.Transport);
        Assert.AreEqual("/path/to/backup", backup.Server.Socket);

        var xml = TestUtility.Serialize(backup);
        Assert.IsNotNull(xml);
    }
}
