namespace LibvirtModel.Test.Model;

[TestClass]
public class StoragePoolTest : TestBase
{
    [TestMethod]
    public void FsPoolFsMountOpts()
    {
        const string expected = $@"
{XMLDECL}
<mount_opts {XMLNS} />
";

        this.AssertXml<FsPoolFsMountOpts>(expected);
    }

    [TestMethod]
    public void FsPoolFsMountOptsOption()
    {
        const string expected = $@"
{XMLDECL}
<FsPoolFsMountOptsOption {XMLNS} />
";

        this.AssertXml<FsPoolFsMountOptsOption>(expected);
    }

    [TestMethod]
    public void Pool()
    {
        const string expected = $@"
{XMLDECL}
<pool {XMLNS} type=""dir"" />
";

        this.AssertXml<Pool>(expected);
    }

    [TestMethod]
    public void PoolAllocation()
    {
        const string expected = $@"
{XMLDECL}
<PoolAllocation {XMLNS} />
";

        this.AssertXml<PoolAllocation>(expected);
    }

    [TestMethod]
    public void PoolAvailable()
    {
        const string expected = $@"
{XMLDECL}
<PoolAvailable {XMLNS} />
";

        this.AssertXml<PoolAvailable>(expected);
    }

    [TestMethod]
    public void PoolCapacity()
    {
        const string expected = $@"
{XMLDECL}
<PoolCapacity {XMLNS} />
";

        this.AssertXml<PoolCapacity>(expected);
    }

    [TestMethod]
    public void PoolFeatures()
    {
        const string expected = $@"
{XMLDECL}
<PoolFeatures {XMLNS} />
";

        this.AssertXml<PoolFeatures>(expected);
    }

    [TestMethod]
    public void PoolFeaturesCow()
    {
        const string expected = $@"
{XMLDECL}
<PoolFeaturesCow {XMLNS} state=""no"" />
";

        this.AssertXml<PoolFeaturesCow>(expected);
    }

    [TestMethod]
    public void PoolRefresh()
    {
        const string expected = $@"
{XMLDECL}
<PoolRefresh {XMLNS} />
";

        this.AssertXml<PoolRefresh>(expected);
    }

    [TestMethod]
    public void PoolRefreshVolume()
    {
        const string expected = $@"
{XMLDECL}
<PoolRefreshVolume {XMLNS} />
";

        this.AssertXml<PoolRefreshVolume>(expected);
    }

    [TestMethod]
    public void PoolSource()
    {
        const string expected = $@"
{XMLDECL}
<PoolSource {XMLNS} />
";

        this.AssertXml<PoolSource>(expected);
    }

    [TestMethod]
    public void PoolSourceDevice()
    {
        const string expected = $@"
{XMLDECL}
<PoolSourceDevice {XMLNS} />
";

        this.AssertXml<PoolSourceDevice>(expected);
    }

    [TestMethod]
    public void PoolSourceDir()
    {
        const string expected = $@"
{XMLDECL}
<PoolSourceDir {XMLNS} />
";

        this.AssertXml<PoolSourceDir>(expected);
    }

    [TestMethod]
    public void PoolSourceFormat()
    {
        const string expected = $@"
{XMLDECL}
<PoolSourceFormat {XMLNS} type=""auto"" />
";

        this.AssertXml<PoolSourceFormat>(expected);
    }

    [TestMethod]
    public void PoolSourceFormatType()
    {
        var values = Enum.GetValues(typeof(PoolSourceFormatType));
        Assert.HasCount(26, values);
    }

    [TestMethod]
    public void PoolSourcenetfsHost()
    {
        const string expected = $@"
{XMLDECL}
<PoolSourcenetfsHost {XMLNS} />
";

        this.AssertXml<PoolSourcenetfsHost>(expected);
    }

    [TestMethod]
    public void PoolSourceinfoauth()
    {
        const string expected = $@"
{XMLDECL}
<auth {XMLNS} type=""ceph"" />
";

        this.AssertXml<PoolSourceinfoauth>(expected);
    }

    [TestMethod]
    public void PoolSourceinfoauthsecret()
    {
        const string expected = $@"
{XMLDECL}
<PoolSourceinfoauthsecret {XMLNS} />
";

        this.AssertXml<PoolSourceinfoauthsecret>(expected);
    }

    [TestMethod]
    public void PoolSourceinfodevFreeExtent()
    {
        const string expected = $@"
{XMLDECL}
<PoolSourceinfodevFreeExtent {XMLNS} start=""0"" end=""0"" />
";

        this.AssertXml<PoolSourceinfodevFreeExtent>(expected);
    }

    [TestMethod]
    public void PoolSourcenetfsProtocol()
    {
        const string expected = $@"
{XMLDECL}
<PoolSourcenetfsProtocol {XMLNS} />
";

        this.AssertXml<PoolSourcenetfsProtocol>(expected);
    }

    [TestMethod]
    public void PoolSourceProduct()
    {
        const string expected = $@"
{XMLDECL}
<PoolSourceProduct {XMLNS} />
";

        this.AssertXml<PoolSourceProduct>(expected);
    }

    [TestMethod]
    public void PoolSourceVendor()
    {
        const string expected = $@"
{XMLDECL}
<PoolSourceVendor {XMLNS} />
";

        this.AssertXml<PoolSourceVendor>(expected);
    }

    [TestMethod]
    public void PoolTarget()
    {
        const string expected = $@"
{XMLDECL}
<PoolTarget {XMLNS} />
";

        this.AssertXml<PoolTarget>(expected);
    }

    [TestMethod]
    public void PoolType()
    {
        var values = Enum.GetValues(typeof(PoolType));
        Assert.HasCount(14, values);
    }

    [TestMethod]
    public void RbdPoolRbdConfigOpts()
    {
        const string expected = $@"
{XMLDECL}
<config_opts {XMLNS} />
";

        this.AssertXml<RbdPoolRbdConfigOpts>(expected);
    }

    [TestMethod]
    public void RbdPoolRbdConfigOptsOption()
    {
        const string expected = $@"
{XMLDECL}
<RbdPoolRbdConfigOptsOption {XMLNS} />
";

        this.AssertXml<RbdPoolRbdConfigOptsOption>(expected);
    }
}
