namespace LibvirtModel.Test;

[TestClass]
public class FilterbindingTest
{
    [TestMethod]
    public void MinTest()
    {
        var filter = TestUtility.Deserialize<Filterbinding>("min.xml");
        Assert.IsNotNull(filter);
        Assert.AreEqual("name", filter.Owner.Name);
        Assert.AreEqual("uuid", filter.Owner.Uuid);
        Assert.AreEqual("portdev", filter.Portdev.Name);
        Assert.AreEqual("mac", filter.Mac.Address);
        Assert.AreEqual("filter", filter.Filterref.Filter);
        Assert.AreEqual("name", filter.Filterref.Parameter[0].Name);
        Assert.AreEqual("value", filter.Filterref.Parameter[0].Value);

        var xml = TestUtility.Serialize(filter);
        Assert.IsNotNull(xml);
    }
}
