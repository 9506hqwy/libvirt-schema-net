namespace LibvirtModel.Test;

[TestClass]
public class PoolTest
{
    [TestMethod]
    public void DirTest()
    {
        var pool = TestUtility.Deserialize<Pool, Pooldir>("dir.xml");
        Assert.IsNotNull(pool);
        Assert.AreEqual("dir", pool.Type);
        Assert.AreEqual("dir", pool.Name);
        Assert.AreEqual("DC7578D2-DC84-4ABE-8C12-1B05F683F82B", pool.Uuid);
        Assert.AreEqual("bytes", pool.Capacity.Unit);
        Assert.AreEqual("43536580608", pool.Capacity.Value);
        Assert.AreEqual("bytes", pool.Allocation.Unit);
        Assert.AreEqual("4425232384", pool.Allocation.Value);
        Assert.AreEqual("bytes", pool.Available.Unit);
        Assert.AreEqual("39111348224", pool.Available.Value);
        Assert.IsNull(pool.Features);
        Assert.IsNotNull(pool.Source);
        Assert.IsNull(pool.Source.Product);
        Assert.IsNotNull(pool.Target);
        Assert.AreEqual("/var/lib/libvirt/images", pool.Target.Path);
        Assert.AreEqual(711u, pool.Target.Permissions.Mode);
        Assert.IsTrue(pool.Target.Permissions.ModeSpecified);
        Assert.AreEqual(0L, pool.Target.Permissions.Owner);
        Assert.IsTrue(pool.Target.Permissions.OwnerSpecified);
        Assert.AreEqual(0L, pool.Target.Permissions.Group);
        Assert.IsTrue(pool.Target.Permissions.GroupSpecified);
        Assert.AreEqual("system_u:object_r:virt_image_t:s0", pool.Target.Permissions.Label);

        var xml = TestUtility.Serialize(pool);
        Assert.IsNotNull(xml);
    }

    [TestMethod]
    public void DiskTest()
    {
        var pool = TestUtility.Deserialize<Pool, Pooldisk>("disk.xml");
        Assert.IsNotNull(pool);
        Assert.AreEqual("disk", pool.Type);
        Assert.AreEqual("physical", pool.Name);
        Assert.AreEqual("5F762D24-A648-43DB-BB4A-B1FE9770BD6B", pool.Uuid);
        Assert.AreEqual("bytes", pool.Capacity.Unit);
        Assert.AreEqual("21474819584", pool.Capacity.Value);
        Assert.AreEqual("bytes", pool.Allocation.Unit);
        Assert.AreEqual("0", pool.Allocation.Value);
        Assert.AreEqual("bytes", pool.Available.Unit);
        Assert.AreEqual("21474802176", pool.Available.Value);
        Assert.IsNull(pool.Features);
        Assert.IsNotNull(pool.Source);
        Assert.AreEqual("/dev/nvme0n1", pool.Source.Device.Path);
        Assert.IsFalse(pool.Source.Device.PartSeparatorSpecified);
        Assert.AreEqual(17408UL, pool.Source.Device.FreeExtent[0].Start);
        Assert.AreEqual(21474819584UL, pool.Source.Device.FreeExtent[0].End);
        Assert.AreEqual(PoolSourcefmtdiskType.Gpt, pool.Source.Format.Type);
        Assert.IsNotNull(pool.Target);
        Assert.AreEqual("/mnt/physical", pool.Target.Path);
        Assert.IsNull(pool.Target.Permissions);

        var xml = TestUtility.Serialize(pool);
        Assert.IsNotNull(xml);
    }

    [TestMethod]
    public void LogicalTest()
    {
        var pool = TestUtility.Deserialize<Pool, Poollogical>("logical.xml");
        Assert.IsNotNull(pool);
        Assert.AreEqual("logical", pool.Type);
        Assert.AreEqual("lvm", pool.Name);
        Assert.AreEqual("1F675256-55F9-4799-A4F2-214331BC1E3F", pool.Uuid);
        Assert.AreEqual("bytes", pool.Capacity.Unit);
        Assert.AreEqual("32208060416", pool.Capacity.Value);
        Assert.AreEqual("bytes", pool.Allocation.Unit);
        Assert.AreEqual("0", pool.Allocation.Value);
        Assert.AreEqual("bytes", pool.Available.Unit);
        Assert.AreEqual("32208060416", pool.Available.Value);
        Assert.IsNull(pool.Features);
        Assert.IsNotNull(pool.Source);
        Assert.AreEqual("vgpool", pool.Source.Name[0]);
        Assert.AreEqual(PoolSourcefmtlogicalType.Lvm2, pool.Source.Format.Type);
        Assert.IsNotNull(pool.Target);
        Assert.AreEqual("/dev/vgpool", pool.Target.Path);
        Assert.IsNull(pool.Target.Permissions);

        var xml = TestUtility.Serialize(pool);
        Assert.IsNotNull(xml);
    }

    [TestMethod]
    public void NetfsTest()
    {
        var pool = TestUtility.Deserialize<Pool, Poolnetfs>("netfs.xml");
        Assert.IsNotNull(pool);
        Assert.AreEqual("netfs", pool.Type);
        Assert.AreEqual("nfs", pool.Name);
        Assert.AreEqual("52956CC1-310A-42DD-AB29-DD5EA69DF6F8", pool.Uuid);
        Assert.AreEqual("bytes", pool.Capacity.Unit);
        Assert.AreEqual("63909658624", pool.Capacity.Value);
        Assert.AreEqual("bytes", pool.Allocation.Unit);
        Assert.AreEqual("1047920640", pool.Allocation.Value);
        Assert.AreEqual("bytes", pool.Available.Unit);
        Assert.AreEqual("62861737984", pool.Available.Value);
        Assert.IsNull(pool.Features);
        Assert.IsNotNull(pool.Source);
        Assert.AreEqual("192.168.0.1", pool.Source.Host[0].Name);
        Assert.AreEqual("/mnt/exports", pool.Source.Dir.Path);
        Assert.AreEqual(PoolSourcefmtnetfsType.Auto, pool.Source.Format.Type);
        Assert.IsNotNull(pool.Target);
        Assert.AreEqual("/mnt/exports", pool.Target.Path);
        Assert.AreEqual(777u, pool.Target.Permissions.Mode);
        Assert.IsTrue(pool.Target.Permissions.ModeSpecified);
        Assert.AreEqual(0L, pool.Target.Permissions.Owner);
        Assert.IsTrue(pool.Target.Permissions.OwnerSpecified);
        Assert.AreEqual(0L, pool.Target.Permissions.Group);
        Assert.IsTrue(pool.Target.Permissions.GroupSpecified);
        Assert.AreEqual("system_u:object_r:nfs_t:s0", pool.Target.Permissions.Label);

        var xml = TestUtility.Serialize(pool);
        Assert.IsNotNull(xml);
    }
}
