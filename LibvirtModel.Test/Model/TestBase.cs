namespace LibvirtModel.Test.Model;

public class TestBase
{
    internal const string XMLDECL = "<?xml version=\"1.0\" encoding=\"utf-8\"?>";

    internal const string XMLNS = "xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"";

#pragma warning disable CA1822
    internal void AssertXml<T>(string expected)
        where T : class, new()
    {
        var e = expected
            .Replace("\r", string.Empty, StringComparison.InvariantCulture)
            .Replace("\n", string.Empty, StringComparison.InvariantCulture);

        var m = new T();
        var xml = TestUtility
            .Serialize(m)
            .Replace(Environment.NewLine, string.Empty, StringComparison.InvariantCulture);

        Assert.AreEqual(e, xml);
    }
#pragma warning restore CA1822
}
