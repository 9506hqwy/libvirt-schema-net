namespace LibvirtModel.Test;

[TestClass]
public class CapabilitiesTest
{
    [TestMethod]
    public void MinTest()
    {
        var cap = TestUtility.Deserialize<Capabilities>("min.xml");
        Assert.IsNotNull(cap);
        Assert.AreEqual(Archnames.Aarch64, cap.Host.Cpu.Arch);
        Assert.AreEqual("name", cap.Host.Cpu.Feature[0].Name);
        Assert.AreEqual(1u, cap.Host.Cpu.Pages[0].Size);
        Assert.AreEqual("model", cap.Host.Secmodel[0].Model);
        Assert.AreEqual("doi", cap.Host.Secmodel[0].Doi);
        Assert.AreEqual("type", cap.Host.Secmodel[0].Baselabel[0].Type);
        Assert.AreEqual("label", cap.Host.Secmodel[0].Baselabel[0].Value);
        Assert.AreEqual(CapabilitiesGuestcapsOstype.Linux, cap.Guest[0].OsType);
        Assert.AreEqual(Archnames.Aarch64, cap.Guest[0].Arch.Name);
        Assert.AreEqual(CapabilitiesGuestcapsArchWordsize.N32, cap.Guest[0].Arch.Wordsize);
        Assert.AreEqual("machine1", cap.Guest[0].Arch.Machine[0].Value);
        Assert.AreEqual(CapabilitiesGuestcapsArchDomainType.Qemu, cap.Guest[0].Arch.Domain[0].Type);
        Assert.AreEqual("machine2", cap.Guest[0].Arch.Domain[0].Machine[0].Value);

        var xml = TestUtility.Serialize(cap);
        Assert.IsNotNull(xml);
    }
}
