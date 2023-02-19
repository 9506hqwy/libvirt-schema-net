namespace LibvirtModel.Test;

[TestClass]
public class FilterTest
{
    [TestMethod]
    public void MinTest()
    {
        var filter = TestUtility.Deserialize<Filter>("min.xml");
        Assert.IsNotNull(filter);
        Assert.AreEqual("name", filter.Name);
        Assert.IsNull(filter.Rule);

        var xml = TestUtility.Serialize(filter);
        Assert.IsNotNull(xml);
    }
}
