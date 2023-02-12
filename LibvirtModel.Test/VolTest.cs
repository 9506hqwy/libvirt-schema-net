namespace LibvirtModel.Test;

[TestClass]
public class VolTest
{
    [TestMethod]
    public void InputTest()
    {
        var vol = TestUtility.Deserialize<Vol>("input.xml");
        Assert.IsNotNull(vol);
        Assert.IsFalse(vol.TypeSpecified);
        Assert.AreEqual("test.qcow2", vol.Name);
        Assert.IsNull(vol.Key);
        Assert.IsNull(vol.Source);
        Assert.IsNotNull(vol.Capacity);
        Assert.AreEqual("1", vol.Capacity.Value);
        Assert.IsNotNull(vol.Allocation);
        Assert.AreEqual("2", vol.Allocation.Value);
        Assert.IsNull(vol.Physical);
        Assert.IsNotNull(vol.Target);
        Assert.IsNull(vol.Target.Path);
        Assert.IsNotNull(vol.Target.Format);
        Assert.AreEqual(VolFormatType.Raw, vol.Target.Format.Type);
        Assert.IsNull(vol.Target.Permissions);
        Assert.IsNull(vol.Target.Encryption);
        Assert.IsNull(vol.Target.Compat);
        Assert.IsNull(vol.Target.Nocow);
        Assert.IsNull(vol.Target.ClusterSize);
        Assert.IsNull(vol.Target.Features);
        Assert.IsNotNull(vol.BackingStore);
        Assert.AreEqual("backing.qcow2", vol.BackingStore.Path);
        Assert.IsNotNull(vol.BackingStore.Format);
        Assert.AreEqual(VolFormatType.Raw, vol.BackingStore.Format.Type);
        Assert.IsNull(vol.BackingStore.Permissions);
        Assert.IsNull(vol.BackingStore.Timestamps);

        var xml = TestUtility.Serialize(vol);
        Assert.IsNotNull(xml);
    }

    [TestMethod]
    public void MinTest()
    {
        var vol = TestUtility.Deserialize<Vol>("min.xml");
        Assert.IsNotNull(vol);
        Assert.IsFalse(vol.TypeSpecified);
        Assert.AreEqual("test.qcow2", vol.Name);
        Assert.IsNull(vol.Key);
        Assert.IsNull(vol.Source);
        Assert.IsNull(vol.Capacity);
        Assert.IsNull(vol.Allocation);
        Assert.IsNull(vol.Physical);
        Assert.IsNotNull(vol.Target);
        Assert.IsNull(vol.Target.Path);
        Assert.IsNull(vol.Target.Format);
        Assert.IsNull(vol.Target.Permissions);
        Assert.IsNull(vol.Target.Encryption);
        Assert.IsNull(vol.Target.Compat);
        Assert.IsNull(vol.Target.Nocow);
        Assert.IsNull(vol.Target.ClusterSize);
        Assert.IsNull(vol.Target.Features);
        Assert.IsNull(vol.BackingStore);

        var xml = TestUtility.Serialize(vol);
        Assert.IsNotNull(xml);
    }
}
