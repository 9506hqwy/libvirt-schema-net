namespace LibvirtModel.Test;

[TestClass]
public class StoragepoolCapabilitiesTest
{
    [TestMethod]
    public void FullTest()
    {
        var cap = TestUtility.Deserialize<StoragepoolCapabilities>("full.xml");
        Assert.IsNotNull(cap);
        Assert.IsNotNull(cap.Pool);
        Assert.AreEqual(14, cap.Pool.Length);

        var xml = TestUtility.Serialize(cap);
        Assert.IsNotNull(xml);
    }

    [TestMethod]
    public void MinTest()
    {
        var cap = TestUtility.Deserialize<StoragepoolCapabilities>("min.xml");
        Assert.IsNotNull(cap);
        Assert.IsNotNull(cap.Pool);
        Assert.AreEqual("cap", cap.Pool[0].Type);
        Assert.AreEqual(VirYesNo.Yes, cap.Pool[0].Supported);
        Assert.IsNull(cap.Pool[0].PoolOptions);
        Assert.IsNull(cap.Pool[0].VolOptions);

        var xml = TestUtility.Serialize(cap);
        Assert.IsNotNull(xml);
    }
}
