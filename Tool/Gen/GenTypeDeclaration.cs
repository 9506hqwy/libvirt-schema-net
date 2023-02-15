namespace Gen;

internal class GenTypeDeclaration
{
    private readonly List<GenTypeMember> members;

    internal GenTypeDeclaration(CodeTypeDeclaration type)
    {
        this.members = new List<GenTypeMember>();

        this.Type = type;
    }

    internal CodeTypeReferenceCollection BaseTypes => this.Type.BaseTypes;

    internal string Name => this.Type.Name;

    internal CodeTypeDeclaration Type { get; }

    internal void Add(GenTypeMember member)
    {
        this.members.Add(member);
    }

    internal void GenProperty(CodeContext context)
    {
        var addedNames = new List<string>();

        foreach (var member in this.members)
        {
            if (addedNames.Contains(member.Name))
            {
                continue;
            }

            addedNames.Add(member.Name);

            var targets = this.members.Where(m => m.Name == member.Name).ToArray();

            if (targets.Length == 1 || targets.All(t => t.Type.BaseType == targets[0].Type.BaseType))
            {
                foreach (var property in targets[0].Gen())
                {
                    this.Type.Members.Add(property);
                }
            }
            else if (this.TryMergeProperty(context, targets, out var merged))
            {
                foreach (var property in merged!.Gen())
                {
                    this.Type.Members.Add(property);
                }
            }
            else
            {
                context.AddWarning($"Not supported. Differenct type at {this.Type.Name}.{member.Name}");
            }
        }
    }

    private bool TryMergeProperty(CodeContext context, GenTypeMember[] members, out GenTypeMember? merged)
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

        foreach (var member in members)
        {
            if (member == merged)
            {
                continue;
            }

            context.AddWarning($"Not supported. Differenct type at {this.Type.Name}.{member.Name} ({member.Type.BaseType})");
        }

        return true;
    }
}
