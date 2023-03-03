namespace Gen;

internal class ExcludeDefine
{
    internal ExcludeDefine(string defineName, string fileName)
    {
        this.DefineName = defineName;
        this.FileName = fileName;
    }

    internal string DefineName { get; }

    internal string FileName { get; }
}
