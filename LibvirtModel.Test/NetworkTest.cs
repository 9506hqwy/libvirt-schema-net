namespace LibvirtModel.Test;

[TestClass]
public class NetworkTest
{
    [TestMethod]
    public void MinTest()
    {
        var net = TestUtility.Deserialize<Network>("min.xml");
        Assert.IsNotNull(net);
        Assert.AreEqual("name1", net.Name);
        Assert.AreEqual("name2", net.Portgroup[0].Name);
        Assert.IsNotNull(net.Ip[0]);
        Assert.AreEqual("192.168.0.1", net.Route[0].Address);
        Assert.AreEqual("255.255.255.0", net.Route[0].Gateway);

        var xml = TestUtility.Serialize(net);
        Assert.IsNotNull(xml);
    }
}
