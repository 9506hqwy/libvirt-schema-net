namespace LibvirtModel.Test;

[TestClass]
public class GuestcpuTest
{
    [TestMethod]
    public void MinTest()
    {
        var cpu = TestUtility.Deserialize<Guestcpu>("min.xml");
        Assert.IsNotNull(cpu);
        Assert.AreEqual(GuestcpuCpuFeaturePolicy.Force, cpu.Feature[0].Policy);
        Assert.AreEqual("name", cpu.Feature[0].Name);

        var xml = TestUtility.Serialize(cpu);
        Assert.IsNotNull(xml);
    }
}
