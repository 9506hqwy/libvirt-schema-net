namespace Gen;

using RelaxNg.Schema;

internal static class INameExtension
{
    internal static string GetName(this INameBase self)
    {
        return self switch
        {
            _ when self is Name n => n.Val,
            _ => throw new NotSupportedException($"Not supported tag `{self.GetType().Name}` at {self.Position}."),
        };
    }

    internal static int GetNameLength(this INameBase self)
    {
        return self switch
        {
            _ when self is Name n => n.Val.Length,
            _ => 1,
        };
    }

    internal static bool IsAnyName(this INameBase self)
    {
        return self is AnyName;
    }
}
