namespace LibvirtModel.Test.Model;

[TestClass]
public class StoragePoolCapsTest : TestBase
{
    [TestMethod]
    public void StoragepoolCapabilities()
    {
        const string expected = $@"
{XMLDECL}
<storagepoolCapabilities {XMLNS} />
";

        this.AssertXml<StoragepoolCapabilities>(expected);
    }

    [TestMethod]
    public void StoragepoolCapabilitiesPoolCapsType()
    {
        const string expected = $@"
{XMLDECL}
<pool {XMLNS} supported=""no"" />
";

        this.AssertXml<StoragepoolCapabilitiesPoolCapsType>(expected);
    }

    [TestMethod]
    public void StoragepoolCapabilitiesPoolCapsPoolOptions()
    {
        const string expected = $@"
{XMLDECL}
<poolOptions {XMLNS} />
";

        this.AssertXml<StoragepoolCapabilitiesPoolCapsPoolOptions>(expected);
    }

    [TestMethod]
    public void StoragepoolCapabilitiesPoolCapsVolOptions()
    {
        const string expected = $@"
{XMLDECL}
<volOptions {XMLNS} />
";

        this.AssertXml<StoragepoolCapabilitiesPoolCapsVolOptions>(expected);
    }

    [TestMethod]
    public void StoragepoolCapabilitiesPoolCapsVolOptionsEnum()
    {
        const string expected = $@"
{XMLDECL}
<StoragepoolCapabilitiesPoolCapsVolOptionsEnum {XMLNS} />
";

        this.AssertXml<StoragepoolCapabilitiesPoolCapsVolOptionsEnum>(expected);
    }

    [TestMethod]
    public void StoragepoolCapabilitiesPoolDefaultFormat()
    {
        const string expected = $@"
{XMLDECL}
<StoragepoolCapabilitiesPoolDefaultFormat {XMLNS} />
";

        this.AssertXml<StoragepoolCapabilitiesPoolDefaultFormat>(expected);
    }
}
