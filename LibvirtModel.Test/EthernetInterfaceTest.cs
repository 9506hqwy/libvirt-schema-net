namespace LibvirtModel.Test;

[TestClass]
public class EthernetInterfaceTest
{
    [TestMethod]
    public void MinTest()
    {
        var intf = TestUtility.Deserialize<EthernetInterface>("min.xml");
        Assert.IsNotNull(intf);
        Assert.AreEqual(EthernetInterfaceType.Ethernet, intf.Type);
        Assert.AreEqual("name", intf.Name);

        var xml = TestUtility.Serialize(intf);
        Assert.IsNotNull(xml);
    }
}
