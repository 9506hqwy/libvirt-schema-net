﻿namespace Gen;

using RelaxNg.Schema;

internal class AstBuilder
{
    private readonly List<AstMergedTypeDeclaration> mergedTypes;

    private readonly Repository repository;

    private readonly Dictionary<RngPosition, AstTypeDeclaration> types;

    internal AstBuilder(Repository repository)
    {
        this.mergedTypes = new List<AstMergedTypeDeclaration>();
        this.types = new Dictionary<RngPosition, AstTypeDeclaration>();

        this.repository = repository;

        this.Init();
    }

    internal AstMergedTypeDeclaration[] MergedTypes => this.mergedTypes.ToArray();

    internal AstTypeDeclaration[] Types => this.types.Values.ToArray();

    private string ByFqdn(AstTypeMember member)
    {
        return $"{member.FindNamespace()}_{member.Name}";
    }

    private string ByFqdn(ParsedChildNode node)
    {
        var ns = node.Value.Node switch
        {
            Element e => e.Namespace,
            _ => null,
        };

        return $"{ns}_{node.Value.Name}";
    }

    private void Init()
    {
        foreach (var type in this.repository.Types)
        {
            this.InitType(type);
        }

        foreach (var type in this.types.Values)
        {
            this.InitFragment(type);
        }

        foreach (var type in this.types.Values)
        {
            this.ParseValueType(type);
        }

        foreach (var type in this.types.Values)
        {
            this.MergeFragment(type);
        }

        foreach (var type in this.types.Values.Where(t => t.Depth == 1))
        {
            this.TraverseType(type);
        }
    }

    private void TraverseType(AstTypeDeclarationBase type)
    {
        if (type.StartReachable)
        {
            return;
        }

        type.StartReachable = true;

        foreach (var member in type.Members)
        {
            if (member.Type?.Declaration is not null)
            {
                this.TraverseType(member.Type!.Declaration!);
            }
        }

        if (type.ValueType?.Declaration is not null)
        {
            this.TraverseType(type.ValueType!.Declaration!);
        }
    }

    private Choice? GetCommonChoice(AstTypeFragment[] values)
    {
        var choice = values[0].Stack.Reverse().FirstOrDefault(n => n is Choice);
        if (choice is null)
        {
            return null;
        }

        foreach (var value in values)
        {
            while (!value.Stack.Reverse().Any(n => n.Position.Equals(choice.Position)))
            {
                choice = values[0].Stack
                    .Reverse()
                    .SkipWhile(n => !n.Position.Equals(choice.Position))
                    .Skip(1)
                    .FirstOrDefault(n => n is Choice);
                if (choice is null)
                {
                    return null;
                }
            }
        }

        return (Choice)choice;
    }

    private AstTypeDeclaration? GetTypeByValue(Value[] values)
    {
        var defines = values.Select(v =>
        {
            return this.types.Values.FirstOrDefault(t => t.Values.Any(r => r.Node.Position == v.Position));
        });

        if (!defines.Any())
        {
            return null;
        }

        var f = defines.First()!;

        return defines.All(d => d is not null && d.Position == f.Position)
            ? f
            : null;
    }

    private void InitFragment(AstTypeDeclaration type)
    {
        foreach (var member in type.Members)
        {
            foreach (var fragment in member.Fragments)
            {
                this.InitFragment(fragment);
            }
        }
    }

    private void InitFragment(AstTypeFragment fragment)
    {
        fragment.Type = this.types[fragment.Node.Position];
    }

    private void MergeFragment(AstTypeDeclarationBase type)
    {
        foreach (var member in type.Members)
        {
            this.MergeFragment(type, member);
        }
    }

    private bool IsMandatoryValue(AstTypeFragment[] values, int maxBranchCount)
    {
        if (maxBranchCount > values.Length)
        {
            return false;
        }

        var root = this.GetCommonChoice(values);
        if (root is null)
        {
            return values.All(v => !v.Optional);
        }

        foreach (var value in values)
        {
            var optional = value.Stack
                .Reverse()
                .TakeWhile(n => n is not Element)
                .TakeWhile(n => !n.Position.Equals(root.Position))
                .FirstOrDefault(n => n is Optional);
            if (optional is not null)
            {
                return false;
            }
        }

        return !values[0].Attributes
            .Reverse()
            .SkipWhile(n => !n.Position.Equals(root.Position))
            .Any(n => n is Optional);
    }

    private void MergeFragment(AstTypeDeclarationBase type, AstTypeMember member)
    {
        if (member.Fragments.Length == 1)
        {
            member.Type = new AstTypeReference(
                member.Fragments[0].Type!,
                member.Fragments[0].Optional,
                member.Fragments[0].IsArray);
            return;
        }

        var values = member.Fragments
            .Where(t => t.Type!.Members.Length == 0 && !t.Type!.IsEmpty)
            .ToArray();
        this.MergeFragmentValue(type, member, values);

        var classes = member.Fragments
            .Where(t => t.Type!.Members.Length != 0 || t.Type!.IsEmpty)
            .ToArray();
        this.MergeFragmentClass(type, member, classes);
    }

    private void MergeFragmentClass(AstTypeDeclarationBase type, AstTypeMember member, AstTypeFragment[] classes)
    {
        if (classes.Length == 0)
        {
            return;
        }

        var optional = classes.Any(v => v.Optional);
        var isArray = classes.Any(v => v.IsArray);

        if (member.Type is null && classes.Length == 1)
        {
            optional = optional || (classes[0].BranchCount > 1);
            member.Type = new AstTypeReference(classes[0].Type!, optional, isArray);
            return;
        }
        else if (
            member.Type is null &&
            classes[0].Type!.Position is not null &&
            classes.All(c => c.Type!.Position is not null && c.Type!.Position.Equals(classes[0].Type!.Position!)))
        {
            var maxBranchCount = classes.Max(v => v.BranchCount);
            optional = optional || (maxBranchCount > classes.Length);
            member.Type = new AstTypeReference(classes[0].Type!, optional, isArray);
            return;
        }
        else
        {
            this.MergeFragmentClassMember(type, member);
            return;
        }
    }

    private void MergeFragmentClassMember(AstTypeDeclarationBase type, AstTypeMember member)
    {
        var maxBranchCount = member.Fragments.Length;

        var optional = member.Fragments.Any(v => v.Optional);
        var isArray = member.Fragments.Any(v => v.IsArray);

        var children = member.Fragments.SelectMany(c => c.Type!.Members).GroupBy(this.ByFqdn);

        var members = new List<AstTypeMember>();
        foreach (var child in children)
        {
            foreach (var nodes in child.GroupBy(c => c.IsAttribute))
            {
                var fragments = nodes.SelectMany(n => n.Fragments).Select(n => n.Copy()).ToArray();

                var isOptional = !this.IsMandatoryValue(fragments, maxBranchCount);
                Array.ForEach(fragments, f => f.SetOptional(isOptional));
                Array.ForEach(fragments, f => f.SetBranchCount(maxBranchCount));

                members.Add(new AstTypeMember(nodes.First().Name, fragments.ToArray(), nodes.Key));
            }
        }

        var values = member.Fragments.SelectMany(c => c.Type!.Values).ToArray();

        var isEmpty = member.Fragments.Any(c => c.Type!.IsEmpty);

        var mergedType = new AstMergedTypeDeclaration(member.Name, members.ToArray(), values, isEmpty, type);
        this.ParseValueType(mergedType);
        this.MergeFragment(mergedType);

        this.mergedTypes.Add(mergedType);

        member.Type = new AstTypeReference(mergedType, optional, isArray);
    }

    private void MergeFragmentPrimitive(AstTypeMember member, AstTypeReference[] primitives, bool optional, bool isArray)
    {
        optional = optional || primitives.Any(v => v.Optional);
        isArray = isArray || primitives[0].IsArray;

        if (primitives.Any(p => p.Type == typeof(double)))
        {
            member.Type = new AstTypeReference(typeof(double), optional, isArray);
            return;
        }

        if (primitives.Any(p => p.Type == typeof(float)))
        {
            member.Type = new AstTypeReference(typeof(float), optional, isArray);
            return;
        }

        if (primitives.Any(p => p.Type == typeof(long)))
        {
            member.Type = new AstTypeReference(typeof(long), optional, isArray);
            return;
        }

        if (primitives.Any(p => p.Type == typeof(int)))
        {
            member.Type = new AstTypeReference(typeof(int), optional, isArray);
            return;
        }

        if (primitives.Any(p => p.Type == typeof(short)))
        {
            member.Type = new AstTypeReference(typeof(short), optional, isArray);
            return;
        }

        if (primitives.Any(p => p.Type == typeof(ulong)))
        {
            member.Type = new AstTypeReference(typeof(ulong), optional, isArray);
            return;
        }

        if (primitives.Any(p => p.Type == typeof(uint)))
        {
            member.Type = new AstTypeReference(typeof(uint), optional, isArray);
            return;
        }

        if (primitives.Any(p => p.Type == typeof(ushort)))
        {
            member.Type = new AstTypeReference(typeof(ushort), optional, isArray);
            return;
        }

        throw new Exception($"Not supported. Unexpected member type in `{primitives[0].Type}`.");
    }

    private void MergeFragmentValue(AstTypeDeclarationBase type, AstTypeMember member, AstTypeFragment[] values)
    {
        if (values.Length == 0)
        {
            return;
        }

        var maxBranchCount = values.Max(v => v.BranchCount);

        var optional = !this.IsMandatoryValue(values, maxBranchCount);
        var isArray = values.Any(v => v.IsArray);

        if (values.Any(v => v.Type!.ValueType!.IsString))
        {
            member.Type = new AstTypeReference(typeof(string), optional, isArray);
            return;
        }

        if (values.All(v => v.Type!.ValueType!.IsDatetime))
        {
            member.Type = new AstTypeReference(typeof(DateTime), optional, isArray);
            return;
        }

        if (values.All(v => v.Type!.ValueType!.IsEnum))
        {
            var mergedValus = values.SelectMany(v => v.Type!.ValueType!.Values!).ToArray();
            var refType = this.GetTypeByValue(mergedValus);
            if (refType is null)
            {
                member.Type = new AstTypeReference(mergedValus, optional, isArray, type);
            }
            else
            {
                member.Type = new AstTypeReference(refType, optional, isArray);
            }

            return;
        }

        if (values.All(v => v.Type!.ValueType!.IsPrimitive))
        {
            this.MergeFragmentPrimitive(member, values.Select(v => v.Type!.ValueType!).ToArray(), optional, isArray);
            return;
        }

        throw new Exception($"Not supported. Mixed primitive and enum type in `{values[0].Node.Position}`.");
    }

    private void InitType(ParsedNode parsed)
    {
        var node = parsed.Node;

        var children = parsed.Children.Where(c => !c.Value.IsRawXml).GroupBy(this.ByFqdn);

        var members = new List<AstTypeMember>();
        foreach (var child in children)
        {
            foreach (var nodes in child.GroupBy(c => c.Value.IsAttribute))
            {
                var fragments = new List<AstTypeFragment>();
                foreach (var frag in nodes)
                {
                    var attributes = frag!.Value.Stack!.GetFrom(node);
                    fragments.Add(new AstTypeFragment(frag.Value.Node, attributes, frag.Value.Stack!.Inner, frag.BranchCount, frag.BranchId));
                }

                foreach (var memGroup in fragments.GroupBy(f => f.BranchId))
                {
                    foreach (var frag in memGroup)
                    {
                        frag.SetIsArray(memGroup.Count() > 1);
                    }
                }

                members.Add(new AstTypeMember(nodes.First().Value.Name, fragments.ToArray(), nodes.Key));
            }
        }

        var values = new List<AstTypeFragment>();
        foreach (var value in parsed.Values)
        {
            var attributes = value!.Stack!.GetFrom(node);
            values.Add(new AstTypeFragment(value.Node, attributes, value.Stack.Inner, value.BranchCount, value.BranchId));
        }

        var type = new AstTypeDeclaration(
            node,
            members.ToArray(),
            values.ToArray(),
            parsed.HasNotAllowed || parsed.IsEmpty,
            parsed.HasRawXml,
            parsed.Stack!.Inner);
        this.types.Add(node.Position, type);
    }

    private void ParseValueType(AstTypeDeclarationBase type)
    {
        if (type.Members.Length == 0 && type.Values.Length == 0)
        {
            if (!type.IsEmpty && !type.IsRawXml)
            {
                type.ValueType = new AstTypeReference(typeof(string), true, false);
            }

            return;
        }
        else if (type.Values.Length == 0)
        {
            return;
        }

        if (type.Values.Any(v => v.IsArray != type.Values[0].IsArray))
        {
            throw new Exception($"Not supported. Mixed unit and array type in `{type.Values[0].Node.Position}`.");
        }

        var text = type.Values.FirstOrDefault(v => v.Node is Text);
        if (text is not null)
        {
            type.ValueType = new AstTypeReference(typeof(string), true, text.IsArray);
            return;
        }

        var datum = type.Values.Where(v => v.Node is Data).ToArray();
        var values = type.Values.Where(v => v.Node is Value).ToArray();

        if (datum.Length != 0)
        {
            this.ParseValueType(type, datum, values);
            return;
        }

        type.ValueType = new AstTypeReference(
            values.Select(v => v.Node).OfType<Value>().ToArray(),
            values.Any(v => v.Optional),
            values[0].IsArray,
            type);
        return;
    }

    private void ParseValueType(AstTypeDeclarationBase type, AstTypeFragment[] datum, AstTypeFragment[] values)
    {
        var optional = datum.Any(v => v.Optional);
        var isArray = datum[0].IsArray;
        var types = datum.Select(d => d.Node).OfType<Data>().Select(d => DataType.Get(d.Type)).ToArray();

        if (types.Contains(typeof(string)))
        {
            type.ValueType = new AstTypeReference(typeof(string), optional, isArray);
        }
        else if (types.Contains(typeof(DateTime)))
        {
            type.ValueType = new AstTypeReference(typeof(DateTime), optional, isArray);

            // TODO: values is not datetime.
        }
        else
        {
            if (types.Contains(typeof(double)))
            {
                type.ValueType = new AstTypeReference(typeof(double), optional, isArray);
            }
            else if (types.Contains(typeof(float)))
            {
                type.ValueType = new AstTypeReference(typeof(float), optional, isArray);
            }
            else if (types.Contains(typeof(ulong)))
            {
                if (values.Any(v => !ulong.TryParse((v.Node as Value)!.Val, out var _)))
                {
                    type.ValueType = new AstTypeReference(typeof(long), optional, isArray);
                }
                else
                {
                    type.ValueType = new AstTypeReference(typeof(ulong), optional, isArray);
                }
            }
            else if (types.Contains(typeof(uint)))
            {
                if (values.Any(v => !uint.TryParse((v.Node as Value)!.Val, out var _)))
                {
                    type.ValueType = new AstTypeReference(typeof(long), optional, isArray);
                }
                else
                {
                    type.ValueType = new AstTypeReference(typeof(uint), optional, isArray);
                }
            }
            else if (types.Contains(typeof(ushort)))
            {
                if (values.Any(v => !ushort.TryParse((v.Node as Value)!.Val, out var _)))
                {
                    type.ValueType = new AstTypeReference(typeof(int), optional, isArray);
                }
                else
                {
                    type.ValueType = new AstTypeReference(typeof(ushort), optional, isArray);
                }
            }
            else if (types.Contains(typeof(long)))
            {
                type.ValueType = new AstTypeReference(typeof(long), optional, isArray);
            }
            else if (types.Contains(typeof(int)))
            {
                type.ValueType = new AstTypeReference(typeof(int), optional, isArray);
            }
            else if (types.Contains(typeof(short)))
            {
                type.ValueType = new AstTypeReference(typeof(short), optional, isArray);
            }
            else
            {
                throw new Exception($"Not supported. Data type in `{datum[0].Node.Position}`.");
            }

            // TODO: values is not number.
        }
    }
}
