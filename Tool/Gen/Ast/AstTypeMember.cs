namespace Gen;

internal class AstTypeMember
{
    internal AstTypeMember(string name, AstTypeFragment[] fragments, bool isAttribute)
    {
        this.Name = name;
        this.Fragments = fragments;
        this.IsAttribute = isAttribute;
    }

    internal AstTypeFragment[] Fragments { get; }

    internal bool IsAttribute { get; }

    internal string Name { get; }

    internal AstTypeReference? Type { get; set; }

    internal string? FindNamespace()
    {
        var namespaces = this.Fragments.Select(f => f.Type!.FindNamespace()).ToArray();

        if (namespaces.Any(n => n != namespaces[0]))
        {
            // TODO:
            return null;
        }

        return namespaces[0];
    }
}
