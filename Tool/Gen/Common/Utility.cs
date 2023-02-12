namespace Gen;

using System.Text.RegularExpressions;

internal static class Utility
{
    internal static string ToClassName(string value)
    {
        return Utility.Replace(Utility.ToUpperCamelCase(Utility.Normalize(value)));
    }

    internal static string ToFieldName(string value)
    {
        return Utility.Replace(Utility.ToLowerCamelCase(Utility.Normalize(value)));
    }

    internal static string ToPropertyName(string value)
    {
        return Utility.Replace(Utility.ToUpperCamelCase(Utility.Normalize(value)));
    }

    private static string Normalize(string value)
    {
        return Regex.IsMatch(value, @"^\d+") ? $"n{value}" : value;
    }

    private static string Replace(string value)
    {
        return value
            .Replace("+", "Plus")
            .Replace(".", "o");
    }

    private static string ToLowerCamelCase(string value)
    {
        var terms = Regex.Replace(value, @"([A-Z]+)", "_$1")
            .Trim('_')
            .Split(new[] { '_', '-' })
            .Select(t => t.ToLowerInvariant())
            .Select((t, i) => i == 0 ? t : Utility.ToCaption(t));
        return string.Join(string.Empty, terms);
    }

    private static string ToUpperCamelCase(string value)
    {
        var terms = Regex.Replace(value, @"([A-Z]+)", "_$1")
            .Trim('_')
            .Split(new[] { '_', '-' })
            .Select(Utility.ToCaption);
        return string.Join(string.Empty, terms);
    }

    private static string ToCaption(string value)
    {
        var caption = value
            .ToCharArray()
            .Select((ch, i) => i == 0 ? char.ToUpper(ch) : char.ToLower(ch))
            .ToArray();
        return new string(caption);
    }
}
