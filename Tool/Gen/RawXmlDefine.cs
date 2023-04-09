namespace Gen;

using RelaxNg.Schema;

internal class RawXmlDefine
{
    internal RawXmlDefine(string defineName, string fileName)
    {
        this.DefineName = defineName;
        this.FileName = fileName;
    }

    internal string DefineName { get; }

    internal string FileName { get; }

    internal bool EqualDefine(Define define)
    {
        return
            this.DefineName == define.Name &&
            this.FileName == define.Position.File.Info.Name;
    }
}
