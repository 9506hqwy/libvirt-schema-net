namespace LibvirtModel.Test.Model;

[TestClass]
public class NodeDevTest : TestBase
{
    [TestMethod]
    public void Device()
    {
        const string expected = $@"
{XMLDECL}
<device {XMLNS} />
";

        this.AssertXml<Device>(expected);
    }

    [TestMethod]
    public void DeviceCapability()
    {
        const string expected = $@"
{XMLDECL}
<capability {XMLNS} type=""ap_card"" />
";

        this.AssertXml<DeviceCapability>(expected);
    }

    [TestMethod]
    public void DeviceCapabilityAttr()
    {
        const string expected = $@"
{XMLDECL}
<DeviceCapabilityAttr {XMLNS} />
";

        this.AssertXml<DeviceCapabilityAttr>(expected);
    }

    [TestMethod]
    public void DeviceCapabilityCapability()
    {
        const string expected = $@"
{XMLDECL}
<DeviceCapabilityCapability {XMLNS} type=""80203"" />
";

        this.AssertXml<DeviceCapabilityCapability>(expected);
    }

    [TestMethod]
    public void DeviceAddress()
    {
        const string expected = $@"
{XMLDECL}
<DeviceAddress {XMLNS} />
";

        this.AssertXml<DeviceAddress>(expected);
    }

    [TestMethod]
    public void DeviceCapabilityCapabilityFields()
    {
        const string expected = $@"
{XMLDECL}
<DeviceCapabilityCapabilityFields {XMLNS} access=""readonly"" />
";

        this.AssertXml<DeviceCapabilityCapabilityFields>(expected);
    }

    [TestMethod]
    public void DeviceCapabilityCapabilityFieldsAccess()
    {
        var values = Enum.GetValues(typeof(DeviceCapabilityCapabilityFieldsAccess));
        Assert.AreEqual(2, values.Length);
    }

    [TestMethod]
    public void DeviceCapabilityCapabilityFieldsVendorField()
    {
        const string expected = $@"
{XMLDECL}
<DeviceCapabilityCapabilityFieldsVendorField {XMLNS} />
";

        this.AssertXml<DeviceCapabilityCapabilityFieldsVendorField>(expected);
    }

    [TestMethod]
    public void DeviceCapabilityCapabilityTypeAttr()
    {
        var values = Enum.GetValues(typeof(DeviceCapabilityCapabilityTypeAttr));
        Assert.AreEqual(17, values.Length);
    }

    [TestMethod]
    public void DeviceCapstorageremoveableMediaAvailable()
    {
        var values = Enum.GetValues(typeof(DeviceCapstorageremoveableMediaAvailable));
        Assert.AreEqual(2, values.Length);
    }

    [TestMethod]
    public void DeviceCapabilityChannelDevAddr()
    {
        const string expected = $@"
{XMLDECL}
<DeviceCapabilityChannelDevAddr {XMLNS} />
";

        this.AssertXml<DeviceCapabilityChannelDevAddr>(expected);
    }

    [TestMethod]
    public void DeviceCapabilityFeature()
    {
        const string expected = $@"
{XMLDECL}
<DeviceCapabilityFeature {XMLNS} />
";

        this.AssertXml<DeviceCapabilityFeature>(expected);
    }

    [TestMethod]
    public void DeviceCapabilityFirmware()
    {
        const string expected = $@"
{XMLDECL}
<firmware {XMLNS} />
";

        this.AssertXml<DeviceCapabilityFirmware>(expected);
    }

    [TestMethod]
    public void DeviceCapabilityHardware()
    {
        const string expected = $@"
{XMLDECL}
<hardware {XMLNS} />
";

        this.AssertXml<DeviceCapabilityHardware>(expected);
    }

    [TestMethod]
    public void DeviceCapabilityIommuGroup()
    {
        const string expected = $@"
{XMLDECL}
<DeviceCapabilityIommuGroup {XMLNS} number=""0"" />
";

        this.AssertXml<DeviceCapabilityIommuGroup>(expected);
    }

    [TestMethod]
    public void DeviceMdevTypesType()
    {
        const string expected = $@"
{XMLDECL}
<DeviceMdevTypesType {XMLNS}>
  <deviceAPI>vfio-ap</deviceAPI>
  <availableInstances>0</availableInstances>
</DeviceMdevTypesType>
";

        this.AssertXml<DeviceMdevTypesType>(expected);
    }

    [TestMethod]
    public void DeviceCapabilityMembers()
    {
        const string expected = $@"
{XMLDECL}
<DeviceCapabilityMembers {XMLNS} />
";

        this.AssertXml<DeviceCapabilityMembers>(expected);
    }

    [TestMethod]
    public void DeviceCapabilityMembersCcwDevice()
    {
        const string expected = $@"
{XMLDECL}
<DeviceCapabilityMembersCcwDevice {XMLNS} />
";

        this.AssertXml<DeviceCapabilityMembersCcwDevice>(expected);
    }

    [TestMethod]
    public void DeviceCapabilityNuma()
    {
        const string expected = $@"
{XMLDECL}
<DeviceCapabilityNuma {XMLNS} />
";

        this.AssertXml<DeviceCapabilityNuma>(expected);
    }

    [TestMethod]
    public void DeviceCapabilityPciExpress()
    {
        const string expected = $@"
{XMLDECL}
<DeviceCapabilityPciExpress {XMLNS} />
";

        this.AssertXml<DeviceCapabilityPciExpress>(expected);
    }

    [TestMethod]
    public void DeviceCapabilityPciExpressLink()
    {
        const string expected = $@"
{XMLDECL}
<DeviceCapabilityPciExpressLink {XMLNS} validity=""cap"" width=""0"" />
";

        this.AssertXml<DeviceCapabilityPciExpressLink>(expected);
    }

    [TestMethod]
    public void DeviceCapabilityPciExpressLinkValidity()
    {
        var values = Enum.GetValues(typeof(DeviceCapabilityPciExpressLinkValidity));
        Assert.AreEqual(2, values.Length);
    }

    [TestMethod]
    public void DeviceCapabilityProduct()
    {
        const string expected = $@"
{XMLDECL}
<DeviceCapabilityProduct {XMLNS} />
";

        this.AssertXml<DeviceCapabilityProduct>(expected);
    }

    [TestMethod]
    public void DeviceCapabilityType()
    {
        const string expected = $@"
{XMLDECL}
<DeviceCapabilityType {XMLNS} />
";

        this.AssertXml<DeviceCapabilityType>(expected);
    }

    [TestMethod]
    public void DeviceCapabilityTypeAttr()
    {
        var values = Enum.GetValues(typeof(DeviceCapabilityTypeAttr));
        Assert.AreEqual(19, values.Length);
    }

    [TestMethod]
    public void DeviceCapabilityVendor()
    {
        const string expected = $@"
{XMLDECL}
<DeviceCapabilityVendor {XMLNS} />
";

        this.AssertXml<DeviceCapabilityVendor>(expected);
    }

    [TestMethod]
    public void DeviceCapabilityVpdFieldsSystemField()
    {
        const string expected = $@"
{XMLDECL}
<DeviceCapabilityVpdFieldsSystemField {XMLNS} />
";

        this.AssertXml<DeviceCapabilityVpdFieldsSystemField>(expected);
    }

    [TestMethod]
    public void DeviceDevnode()
    {
        const string expected = $@"
{XMLDECL}
<DeviceDevnode {XMLNS} type=""dev"" />
";

        this.AssertXml<DeviceDevnode>(expected);
    }

    [TestMethod]
    public void DeviceDevnodeType()
    {
        var values = Enum.GetValues(typeof(DeviceDevnodeType));
        Assert.AreEqual(2, values.Length);
    }

    [TestMethod]
    public void DeviceDriver()
    {
        const string expected = $@"
{XMLDECL}
<DeviceDriver {XMLNS} />
";

        this.AssertXml<DeviceDriver>(expected);
    }

    [TestMethod]
    public void DeviceParent()
    {
        const string expected = $@"
{XMLDECL}
<parent {XMLNS} />
";

        this.AssertXml<DeviceParent>(expected);
    }
}
