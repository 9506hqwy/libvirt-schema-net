namespace LibvirtModel.Test;

[TestClass]
public class DomainCapabilitiesTest
{
    [TestMethod]
    public void MinTest()
    {
        var caps = TestUtility.Deserialize<DomainCapabilities>("min.xml");
        Assert.IsNotNull(caps);
        Assert.AreEqual("path", caps.Path);
        Assert.AreEqual("domain", caps.Domain);
        Assert.AreEqual("arch", caps.Arch);

        var xml = TestUtility.Serialize(caps);
        Assert.IsNotNull(xml);
    }
}
