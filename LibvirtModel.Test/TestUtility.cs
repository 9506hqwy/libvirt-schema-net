namespace LibvirtModel.Test;

using System.Text;

internal static class TestUtility
{
    internal static T Deserialize<T>(string filename)
    {
        var xml = TestUtility.GetTestData(typeof(T), filename);

        var ser = new XmlSerializer(typeof(T));
        return (T)ser.Deserialize(new StringReader(xml))!;
    }

    internal static string GetTestData(Type type, string filename)
    {
        return File.ReadAllText(TestUtility.GetDataFilePath(type, filename));
    }

    internal static string Serialize<T>(T obj)
    {
        var ser = new XmlSerializer(typeof(T));

        using var mem = new MemoryStream();
        ser.Serialize(mem, obj);

        return Encoding.UTF8.GetString(mem.ToArray());
    }

    private static string GetDataFilePath(Type type, string filename)
    {
        return Path.Combine(TestUtility.GetTestDirectory(), "Data", type.Name, filename);
    }

    private static string GetTestDirectory()
    {
        return Path.GetDirectoryName(typeof(Vol).Assembly.Location)!;
    }
}
