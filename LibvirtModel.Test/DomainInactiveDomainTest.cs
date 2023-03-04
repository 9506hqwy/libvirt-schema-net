namespace LibvirtModel.Test;

[TestClass]
public class DomainInactiveDomainTest
{
    [TestMethod]
    public void MinTest()
    {
        var dom = TestUtility.Deserialize<DomainInactiveDomain>("min.xml");
        Assert.IsNotNull(dom);
        Assert.AreEqual(Hvs.Qemu, dom.Type);
        Assert.AreEqual("name", dom.Name);
        Assert.AreEqual("hvm", dom.Os.Type.Value);

        var xml = TestUtility.Serialize(dom);
        Assert.IsNotNull(xml);
    }
}
