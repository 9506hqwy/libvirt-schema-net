namespace LibvirtModel.Test;

[TestClass]
public class DeviceTest
{
    [TestMethod]
    public void CapsystemTest()
    {
        var dev = TestUtility.Deserialize<Device>("capsystem.xml");
        Assert.IsNotNull(dev);
        Assert.AreEqual("name", dev.Name);
        Assert.AreEqual("system", dev.Capability[0].Type);
        Assert.IsNotNull(dev.Capability[0].Hardware);
        Assert.IsNotNull(dev.Capability[0].Firmware);

        var xml = TestUtility.Serialize(dev);
        Assert.IsNotNull(xml);
    }

    [TestMethod]
    public void MinTest()
    {
        var dev = TestUtility.Deserialize<Device>("min.xml");
        Assert.IsNotNull(dev);
        Assert.AreEqual("name", dev.Name);

        var xml = TestUtility.Serialize(dev);
        Assert.IsNotNull(xml);
    }
}
