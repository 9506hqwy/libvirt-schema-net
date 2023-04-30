namespace LibvirtModel.Test.Model;

[TestClass]
public class SecretTest : TestBase
{
    [TestMethod]
    public void Secret()
    {
        const string expected = $@"
{XMLDECL}
<secret {XMLNS} />
";

        this.AssertXml<Secret>(expected);
    }

    [TestMethod]
    public void SecretUsage()
    {
        const string expected = $@"
{XMLDECL}
<SecretUsage {XMLNS} type=""ceph"" />
";

        this.AssertXml<SecretUsage>(expected);
    }
}
