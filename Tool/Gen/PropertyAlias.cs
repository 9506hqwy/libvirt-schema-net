namespace Gen;

internal class PropertyAlias
{
    internal PropertyAlias(string className, string propertyName, bool isElement, string newPropertyName)
    {
        this.ClassName = className;
        this.PropertyName = propertyName;
        this.IsElement = isElement;
        this.NewPropertyName = newPropertyName;
    }

    internal string ClassName { get; }

    internal string PropertyName { get; }

    internal bool IsElement { get; }

    internal string NewPropertyName { get; }
}
