namespace LibvirtModel.Test;

[TestClass]
public class DomaincheckpointTest
{
    [TestMethod]
    public void MinTest()
    {
        var point = TestUtility.Deserialize<Domaincheckpoint>("min.xml");
        Assert.IsNotNull(point);

        var xml = TestUtility.Serialize(point);
        Assert.IsNotNull(xml);
    }
}
