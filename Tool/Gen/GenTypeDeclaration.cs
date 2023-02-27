namespace Gen;

internal class GenTypeDeclaration
{
    private readonly string className;

    private readonly string? elementName;

    private readonly bool isAbstract;

    private readonly bool isClass;

    private readonly bool isEnum;

    private readonly List<GenTypeMember> members;

    private readonly string? ns;

    private readonly bool xmlModifier;

    internal GenTypeDeclaration(string className)
        : this(className, null, null, false, false, false, true)
    {
    }

    internal GenTypeDeclaration(string className, string? elementName, string? ns, bool xmlModifier, bool isAbstract)
        : this(className, elementName, ns, xmlModifier, isAbstract, true, false)
    {
    }

    private GenTypeDeclaration(string className, string? elementName, string? ns, bool xmlModifier, bool isAbstract, bool isClass, bool isEnum)
    {
        this.className = className;
        this.elementName = elementName;
        this.ns = ns;
        this.xmlModifier = xmlModifier;
        this.isAbstract = isAbstract;
        this.isClass = isClass;
        this.isEnum = isEnum;

        this.members = new List<GenTypeMember>();
    }

    internal CodeTypeReference? BaseType { get; set; }

    internal string Name => this.className;

    internal CodeTypeDeclaration? Type { get; private set; }

    internal void Add(GenTypeMember member)
    {
        this.members.Add(member);
    }

    internal void Gen(CodeContext context)
    {
        var cls = this.GenClass(context);
        this.GenProperty(context, cls);
        this.Type = cls;
    }

    private CodeTypeDeclaration GenClass(CodeContext context)
    {
        if (this.isClass)
        {
            var xmlModifier = this.xmlModifier && !context.ExcludeTypeAttrs.Contains(this.className);
            Code.ConvertForType(this.className, this.elementName!, this.ns, xmlModifier, this.isAbstract, out var type);

            if (this.BaseType is not null)
            {
                type.BaseTypes.Add(this.BaseType);
            }

            return type;
        }
        else if (this.isEnum)
        {
            return new CodeTypeDeclaration(this.className)
            {
                IsEnum = true,
            };
        }
        else
        {
            throw new InvalidProgramException();
        }
    }

    private void GenProperty(CodeContext context, CodeTypeDeclaration cls)
    {
        var addedNames = new List<string>();

        var names = this.members.GroupBy(m => m.Name).ToDictionary(
            g => g.Key,
            g => g.ToArray());
        var needMerge = names.Any(n => this.NeedMerge(n.Value));

        foreach (var member in this.members)
        {
            if (addedNames.Contains(member.Name))
            {
                continue;
            }

            addedNames.Add(member.Name);

            var targets = this.members.Where(m => m.Name == member.Name).ToArray();

            if (needMerge)
            {
                Array.ForEach(targets, t => t.SetOptional());
            }

            if (targets.Length == 1 || targets.All(t => t.Type.BaseType == targets[0].Type.BaseType))
            {
                foreach (var property in targets[0].Gen())
                {
                    cls.Members.Add(property);
                }
            }
            else if (this.TryMergeProperty(context, cls, targets, out var merged))
            {
                foreach (var property in merged!.Gen())
                {
                    cls.Members.Add(property);
                }
            }
            else
            {
                context.AddWarning($"Not supported. Differenct type at {cls.Name}.{member.Name}");
            }
        }
    }

    private bool NeedMerge(GenTypeMember[] members)
    {
        if (members.Length == 1)
        {
            return false;
        }

        return members.Any(t => t.Type.BaseType != members[0].Type.BaseType);
    }

    private bool TryMergeProperty(CodeContext context, CodeTypeDeclaration cls, GenTypeMember[] members, out GenTypeMember? merged)
    {
        // TODO: more flexible
        merged = members[0];
        var mergedType = merged.GetMemberType(context);

        if (members.Any(m => !GenTypeMember.SameKind(m, members[0])))
        {
            return false;
        }

        foreach (var member in members)
        {
            var type = member.GetMemberType(context);
            if (mergedType.members.Count < type.members.Count)
            {
                merged = member;
                mergedType = type;
            }
        }

        foreach (var member in mergedType.members)
        {
            member.SetOptional();
        }

        foreach (var member in members)
        {
            if (merged == member)
            {
                continue;
            }

            var type = member.GetMemberType(context);
            if (mergedType.isEnum && type.Name == "System.String")
            {
                merged = merged.ToStringType();
                mergedType = merged.GetMemberType(context);
            }

            foreach (var memMember in type.members)
            {
                var found = mergedType.members.FirstOrDefault(m => m.Name == memMember.Name);
                if (found is null)
                {
                    memMember.SetOptional();
                    mergedType.Add(memMember);
                    continue;
                }

                if (found.Type.BaseType == memMember.Type.BaseType)
                {
                    continue;
                }

                var memMemberType = memMember.GetMemberType(context);
                var foundType = found.GetMemberType(context);

                if (memMemberType.isEnum && foundType.isEnum)
                {
                    foreach (var f in memMemberType.members)
                    {
                        foundType.Add(f);
                    }

                    continue;
                }

                context.AddWarning($"Not supported. Differenct type at {member.Type.BaseType}.{memMember.Name} ({cls.Name})");
                return true;
            }
        }

        return true;
    }
}
