namespace Gen;

internal class RecursiveDefineException : Exception
{
    internal RecursiveDefineException()
        : base()
    {
    }

    internal RecursiveDefineException(string name, string fileName)
        : base($"Detect recursive reference `{name}` in `{fileName}`.")
    {
    }
}
