namespace LibvirtModel.Test;

[TestClass]
public class DomainsnapshotTest
{
    [TestMethod]
    public void MinTest()
    {
        var snapshot = TestUtility.Deserialize<Domainsnapshot>("min.xml");
        Assert.IsNotNull(snapshot);

        var xml = TestUtility.Serialize(snapshot);
        Assert.IsNotNull(xml);
    }
}
