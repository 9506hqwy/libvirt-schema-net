namespace Gen;

using RelaxNg.Schema;

internal class CodeContext
{
    private readonly Stack<INode> callerNode;

    private readonly Stack<IHasName> callerProperty;

    private readonly Stack<CodeContextItem> callerType;

    private readonly List<CodeContextItem> items;

    private readonly List<Start> starts;

    private readonly List<string> warnings;

    internal CodeContext()
    {
        this.callerNode = new Stack<INode>();
        this.callerProperty = new Stack<IHasName>();
        this.callerType = new Stack<CodeContextItem>();
        this.items = new List<CodeContextItem>();
        this.starts = new List<Start>();
        this.warnings = new List<string>();

        this.ClassNamePrefix = new Dictionary<string, string>();
        this.ExcludeDefines = new List<ExcludeDefine>();
        this.ExcludeTypeAttrs = new List<string>();
        this.PropertyAliases = new List<PropertyAlias>();
    }

    internal Dictionary<string, string> ClassNamePrefix { get; }

    internal Define CurrentDefile => this.callerNode.OfType<Define>().First();

    internal RngFile CurrentFile => this.CurrentDefile.File;

    internal IHasName CurrentProperty => this.callerProperty.First();

    internal Define EntryDefine => this.callerNode.OfType<Define>().Last();

    internal RngFile EntryFile => this.callerNode.Last().File;

    internal List<ExcludeDefine> ExcludeDefines { get; }

    internal List<string> ExcludeTypeAttrs { get; }

    internal List<PropertyAlias> PropertyAliases { get; }

    internal string[] Warnings => this.warnings.ToArray();

    internal void Add(GenTypeDeclaration type)
    {
        var item = new CodeContextItem(this.CurrentDefile, type);
        this.items.Add(item);
    }

    internal void Add(Start start)
    {
        this.starts.Add(start);
    }

    internal void AddExtensionType(string className, Element element, bool xmlModifier)
    {
        var cls = new GenTypeDeclaration(className, element.Name.GetName(), null, xmlModifier, false);

        if (!this.IsParsed(cls.Name))
        {
            this.Add(cls);
        }

        this.EnterType(cls);
        try
        {
            cls.Add(new GenTypeMember());

            foreach (var property in element.Children.Where(this.FilterForAttribute))
            {
                property.AddProperty(this, cls, this.FilterForAttribute, new PropertyState());
            }
        }
        finally
        {
            this.ExitType();
        }
    }

    internal void AddType(string className, IHasChildren hasChildren, bool xmlModifier, GenTypeDeclaration? baseType, string? elementName)
    {
        var tagName = hasChildren switch
        {
            _ when hasChildren is IHasName hasName => hasName.Name.GetName(),
            _ when elementName is not null => elementName,
            _ => throw new NotSupportedException(),
        };

        var ns = hasChildren switch
        {
            _ when hasChildren is Element element => element.Namespace,
            _ => null,
        };

        var cls = new GenTypeDeclaration(className, tagName, ns, xmlModifier, false);

        if (baseType is not null)
        {
            cls.BaseType = new CodeTypeReference(baseType.Name);
        }

        if (!this.IsParsed(cls.Name))
        {
            this.Add(cls);
        }

        this.EnterType(baseType ?? cls);
        try
        {
            foreach (var property in hasChildren.Children.Where(this.FilterForProperty))
            {
                property.AddProperty(this, cls, this.FilterForProperty, new PropertyState());
            }
        }
        finally
        {
            this.ExitType();
        }
    }

    internal void AddWarning(string message)
    {
        this.warnings.Add(message);
    }

    internal IEnumerable<GenTypeDeclaration> EnumerateTypes()
    {
        return this.items.Select(c => c.Type!).OrderBy(t => t.Name);
    }

    internal void EnterNode(INode node)
    {
        if (node is Define define &&
            this.callerNode.OfType<Define>().Any(d => d.Name == define.Name && d.File.Info.Name == define.File.Info.Name))
        {
            foreach (var caller in this.callerNode.OfType<Define>())
            {
                Console.Error.WriteLine($"{caller.Name} in {caller.File.Info.Name}");
            }

            throw new InvalidOperationException($"Detect recursive reference `{define.Name}` in `{node.File.Info.Name}`.");
        }

        this.callerNode.Push(node);
    }

    internal void EnterProperty(IHasName property)
    {
        this.callerProperty.Push(property);
    }

    internal void EnterType(GenTypeDeclaration type)
    {
        var item = new CodeContextItem(this.CurrentDefile, type);
        this.callerType.Push(item);
    }

    internal INode ExitNode()
    {
        return this.callerNode.Pop();
    }

    internal IHasName ExitProperty()
    {
        return this.callerProperty.Pop();
    }

    internal GenTypeDeclaration ExitType()
    {
        return this.callerType.Pop().Type;
    }

    internal Start GetStart(string fileName)
    {
        return this.starts.First(s => s.File.Info.Name == fileName);
    }

    internal void Gen()
    {
        this.items.ForEach(i => i.Type.Gen(this));
    }

    internal string GetClassName(IHasName? hasName, out bool defineLevel)
    {
        defineLevel = false;

        var prefix = string.Empty;
        if (hasName is not Attribute)
        {
            if (this.ClassNamePrefix.TryGetValue(this.CurrentFile.Info.Name, out var tmp))
            {
                prefix = tmp;
            }
            else if (this.CurrentFile.Info.FullName == this.EntryFile.Info.FullName)
            {
                prefix = this.EntryDefine.Name;
            }
        }

        var item = this.callerType.FirstOrDefault();
        if (item is not null && item.Define.Name == this.CurrentDefile.Name)
        {
            return this.CreateUnderscoredText(prefix, item.Type.Name, hasName!.Name.GetName());
        }

        if (hasName is Element && this.CurrentDefile.RetrieveElement(this).Count() != 1)
        {
            return this.CreateUnderscoredText(prefix, this.CurrentDefile.Name, hasName.Name.GetName());
        }

        // TODO: add nested enum support.
        defineLevel = true;
        return this.CreateUnderscoredText(prefix, this.CurrentDefile.Name);
    }

    internal string GetPropertyName(string name, bool isElement)
    {
        foreach (var alias in this.PropertyAliases)
        {
            if (this.CurrentDefile.Name != alias.ClassName)
            {
                continue;
            }

            if (name != alias.PropertyName)
            {
                continue;
            }

            if (isElement != alias.IsElement)
            {
                continue;
            }

            return alias.NewPropertyName;
        }

        return name;
    }

    internal bool IsParsed(string className)
    {
        return this.items.Any(c => this.MatchItem(c, className));
    }

    internal Define Resolve(Ref r)
    {
        return r.Resolve(this.EntryFile);
    }

    internal bool Skip(Define define)
    {
        return this.ExcludeDefines
            .Any(d => d.DefineName == define.Name && d.FileName == define.File.Info.Name);
    }

    private string CreateUnderscoredText(string prefix, params string[] args)
    {
        var first = args.First().ToLower();
        return string.Join('_', first.StartsWith(prefix.ToLower()) ? args : new[] { prefix }.Concat(args));
    }

    private bool FilterForAttribute(IPattern pattern)
    {
        return
            pattern is not Data &&
            pattern is not Element &&
            pattern is not Empty &&
            pattern is not Text &&
            pattern is not Value;
    }

    private bool FilterForProperty(IPattern pattern)
    {
        return pattern is not Empty;
    }

    private bool MatchItem(CodeContextItem item, string className)
    {
        return
            item.Type.Name == className &&
            item.Define.File.Info.FullName == this.CurrentFile.Info.FullName;
    }

    private class CodeContextItem
    {
        internal CodeContextItem(Define define, GenTypeDeclaration type)
        {
            this.Define = define;
            this.Type = type;
        }

        internal Define Define { get; }

        internal GenTypeDeclaration Type { get; set; }
    }
}
