namespace Gen;

using RelaxNg.Schema;

internal static class StartExtension
{
    internal static void CollectType(this Start self, CodeContext context)
    {
        context.EnterNode(self);
        try
        {
            foreach (var element in self.Child.RetrieveElement(context))
            {
                var className = Utility.ToClassName(context.GetClassName(element, out var xmlModifier));
                context.AddType(className, element, xmlModifier, null, null);
            }
        }
        finally
        {
            context.ExitNode();
        }
    }

    internal static void CollectInheritedType(this Start self, CodeContext context, Define baseDefine)
    {
        context.EnterNode(self);
        try
        {
            context.EnterNode(baseDefine);
            try
            {
                var baseType = baseDefine.AddBaseType(context, out var baseElement);

                foreach (var define in baseElement.Children.SelectMany(c => c.RetrieveDefine(context)))
                {
                    var className = Utility.ToClassName(context.GetClassName(null, out var xmlModifier));
                    var elementName = baseElement.Name.GetName();
                    context.AddType(className, define, xmlModifier, baseType, elementName);
                }
            }
            finally
            {
                context.ExitNode();
            }
        }
        finally
        {
            context.ExitNode();
        }
    }
}
