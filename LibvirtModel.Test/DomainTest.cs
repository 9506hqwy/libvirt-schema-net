namespace LibvirtModel.Test;

[TestClass]
public class DomainTest
{
    [TestMethod]
    public void MinTest()
    {
        var dom = TestUtility.Deserialize<Domain>("min.xml");
        Assert.IsNotNull(dom);
        Assert.AreEqual(Virttype.Qemu, dom.Type);
        Assert.AreEqual("name", dom.Name);
        Assert.AreEqual("hvm", dom.Os.Type.Value);

        var xml = TestUtility.Serialize(dom);
        Assert.IsNotNull(xml);
    }
}
