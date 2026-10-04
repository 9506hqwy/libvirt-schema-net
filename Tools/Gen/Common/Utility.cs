namespace Gen;

using System.Globalization;
using System.Text.RegularExpressions;

internal static class Utility
{
    internal static string ToClassName(string value)
    {
        return Replace(ToUpperCamelCase(Normalize(value)));
    }

    internal static string ToFieldName(string value)
    {
        return Replace(ToLowerCamelCase(Normalize(value)));
    }

    internal static string ToPropertyName(string value)
    {
        return Replace(ToUpperCamelCase(Normalize(value)));
    }

    private static string Normalize(string value)
    {
        return Regex.IsMatch(value, @"^\d+") ? $"n{value}" : value;
    }

    private static string Replace(string value)
    {
        return value
            .Replace("+", "Plus", StringComparison.InvariantCulture)
            .Replace(".", "o", StringComparison.InvariantCulture);
    }

    private static string ToLowerCamelCase(string value)
    {
#pragma warning disable CA1308
        var terms = Regex.Replace(value, @"([A-Z]+)", "_$1")
            .Trim('_')
            .Split(['_', '-'])
            .Select(t => t.ToLowerInvariant())
            .Select((t, i) => i == 0 ? t : ToCaption(t));
        return string.Join(string.Empty, terms);
#pragma warning restore CA1308
    }

    private static string ToUpperCamelCase(string value)
    {
        var terms = Regex.Replace(value, @"([A-Z]+)", "_$1")
            .Trim('_')
            .Split(['_', '-'])
            .Select(ToCaption);
        return string.Join(string.Empty, terms);
    }

    private static string ToCaption(string value)
    {
        var caption = value
            .ToCharArray()
            .Select((ch, i) => i == 0 ? char.ToUpper(ch, CultureInfo.CurrentCulture) : char.ToLower(ch, CultureInfo.CurrentCulture))
            .ToArray();
        return new string(caption);
    }
}
