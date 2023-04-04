namespace LibvirtModel.Test;

[TestClass]
public class HostcpuTest
{
    [TestMethod]
    public void MinTest()
    {
        var cpu = TestUtility.Deserialize<Hostcpu>("min.xml");
        Assert.IsNotNull(cpu);
        Assert.AreEqual(Archnames.Aarch64, cpu.Arch);
        Assert.AreEqual("name", cpu.Feature[0].Name);
        Assert.AreEqual(1u, cpu.Pages[0].Size);

        var xml = TestUtility.Serialize(cpu);
        Assert.IsNotNull(xml);
    }
}
