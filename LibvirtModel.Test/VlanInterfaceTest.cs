namespace LibvirtModel.Test;

[TestClass]
public class VlanInterfaceTest
{
    [TestMethod]
    public void MinTest()
    {
        var intf = TestUtility.Deserialize<VlanInterface>("min.xml");
        Assert.IsNotNull(intf);
        Assert.AreEqual("vlan", intf.Type);
        Assert.AreEqual(1u, intf.Vlan.Tag);
        Assert.AreEqual("name", intf.Vlan.Interface.Name);

        var xml = TestUtility.Serialize(intf);
        Assert.IsNotNull(xml);
    }
}
