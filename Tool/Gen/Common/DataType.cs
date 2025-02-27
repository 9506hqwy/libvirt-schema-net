﻿namespace Gen;

internal static class DataType
{
    // https://www.w3.org/TR/xmlschema-2/
    private static readonly Dictionary<string, Type> Mapping = new()
    {
        // Primitive
        { "string", typeof(string) },
        { "boolean", typeof(bool) },
        { "decimal", typeof(double) },
        { "float", typeof(float) },
        { "double", typeof(double) },
        { "dateTime", typeof(DateTime) },
        { "time", typeof(DateTime) },
        { "date", typeof(DateTime) },
        { "base64Binary", typeof(byte[]) },
        { "anyURI", typeof(Uri) },

        // Derived
        { "normalizedString", typeof(string) },
        { "token", typeof(string) },
        { "Name", typeof(string) },
        { "NCName", typeof(string) },
        { "integer", typeof(long) },
        { "nonPositiveInteger", typeof(long) },
        { "negativeInteger", typeof(long) },
        { "long", typeof(long) },
        { "int", typeof(int) },
        { "short", typeof(short) },
        { "byte", typeof(sbyte) },
        { "nonNegativeInteger", typeof(ulong) },
        { "unsignedLong", typeof(ulong) },
        { "unsignedInt", typeof(uint) },
        { "unsignedShort", typeof(ushort) },
        { "unsignedByte", typeof(byte) },
        { "positiveInteger", typeof(ulong) },
    };

    internal static Type? Get(string? name)
    {
        return name is null
            ? null
            : DataType.Mapping.TryGetValue(name, out var type) ? type : throw new NotSupportedException($"Not suppored type `{name}`.");
    }
}
