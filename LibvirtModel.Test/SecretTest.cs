namespace LibvirtModel.Test;

[TestClass]
public class SecretTest
{
    [TestMethod]
    public void MinTest()
    {
        var sec = TestUtility.Deserialize<Secret>("min.xml");
        Assert.IsNotNull(sec);
        Assert.IsFalse(sec.EphemeralSpecified);
        Assert.IsFalse(sec.PrivateSpecified);
        Assert.IsNull(sec.Uuid);
        Assert.IsNull(sec.Description);
        Assert.IsNull(sec.Usage);

        var xml = TestUtility.Serialize(sec);
        Assert.IsNotNull(xml);
    }
}
