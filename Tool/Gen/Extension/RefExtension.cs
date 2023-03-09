namespace Gen;

using RelaxNg.Schema;

internal static class RefExtension
{
    internal static IEnumerable<INode> RetrieveNode(this Ref self, CodeContext context)
    {
        var define = context.Resolve(self);
        if (!context.Skip(define))
        {
            try
            {
                context.EnterNode(define);
            }
            catch (RecursiveDefineException)
            {
                yield break;
            }

            try
            {
                // finally 句を実行させないため yield return で返却する。
                yield return define;
            }
            finally
            {
                context.ExitNode();
            }
        }
    }

    internal static IEnumerable<IPattern> RetrievePattern(this Ref self, CodeContext context, bool flattenChoice)
    {
        var define = context.Resolve(self);
        if (!context.Skip(define))
        {
            try
            {
                context.EnterNode(define);
            }
            catch (RecursiveDefineException)
            {
                yield break;
            }

            try
            {
                foreach (var item in define.Children.SelectMany(c => c.RetrievePattern(context, flattenChoice)))
                {
                    // finally 句を実行させないため yield return で返却する。
                    yield return item;
                }
            }
            finally
            {
                context.ExitNode();
            }
        }
    }

    internal static bool TryParseSimpleType(this Ref self, CodeContext context, bool ignoreAttribute, out TypeSpec? type)
    {
        var define = context.Resolve(self);
        if (context.Skip(define))
        {
            type = null;
            return false;
        }

        context.EnterNode(define);
        try
        {
            return define.TryParseSimpleType(context, ignoreAttribute, out type);
        }
        finally
        {
            context.ExitNode();
        }
    }
}
