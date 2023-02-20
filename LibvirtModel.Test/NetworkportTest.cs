namespace LibvirtModel.Test;

[TestClass]
public class NetworkportTest
{
    [TestMethod]
    public void MinTest()
    {
        var port = TestUtility.Deserialize<Networkport>("min.xml");
        Assert.IsNotNull(port);
        Assert.AreEqual("uuid1", port.Uuid);
        Assert.AreEqual("name", port.Owner.Name);
        Assert.AreEqual("uuid2", port.Owner.Uuid);
        Assert.AreEqual("00:11:22:33:44:55", port.Mac.Address);

        var xml = TestUtility.Serialize(port);
        Assert.IsNotNull(xml);
    }
}
