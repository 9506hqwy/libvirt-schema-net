namespace LibvirtModel.Test;

[TestClass]
public class BridgeInterfaceTest
{
    [TestMethod]
    public void MinTest()
    {
        var intf = TestUtility.Deserialize<BridgeInterface>("min.xml");
        Assert.IsNotNull(intf);
        Assert.AreEqual(BridgeInterfaceType.Bridge, intf.Type);
        Assert.AreEqual("name1", intf.Name);
        Assert.AreEqual(BridgeInterfaceBridgeInterfaceType.Ethernet, intf.Bridge.Interface[0].Type);
        Assert.AreEqual("name2", intf.Bridge.Interface[0].Name);

        var xml = TestUtility.Serialize(intf);
        Assert.IsNotNull(xml);
    }
}
