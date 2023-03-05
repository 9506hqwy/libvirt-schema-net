namespace LibvirtModel.Test;

[TestClass]
public class BondInterfaceTest
{
    [TestMethod]
    public void MinTest()
    {
        var intf = TestUtility.Deserialize<BondInterface>("min.xml");
        Assert.IsNotNull(intf);
        Assert.AreEqual("bond", intf.Type);
        Assert.AreEqual("name1", intf.Name);
        Assert.AreEqual("bond", intf.Bond.Interface[0].Type);
        Assert.AreEqual("name2", intf.Bond.Interface[0].Name);

        var xml = TestUtility.Serialize(intf);
        Assert.IsNotNull(xml);
    }
}
