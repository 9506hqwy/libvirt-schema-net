namespace Gen;

using Microsoft.CSharp;
using System.CodeDom.Compiler;
using System.Reflection;
using System.Xml.Serialization;

internal static class Code
{
    private const string DefaultNs = "";

    internal static void ConvertForAttribute(
        CodeTypeReference type,
        string propertyName,
        string attrName,
        out CodeMemberField field,
        out CodeMemberProperty prop)
    {
        Code.ToProperty(type, propertyName, out field, out prop);

        prop.CustomAttributes.Add(new CodeAttributeDeclaration(
            new CodeTypeReference(typeof(XmlAttributeAttribute)),
            new CodeAttributeArgument(new CodePrimitiveExpression(attrName))));
    }

    internal static void ConvertForElement(
        CodeTypeReference type,
        string propertyName,
        string elementName,
        string? ns,
        out CodeMemberField field,
        out CodeMemberProperty prop)
    {
        Code.ToProperty(type, propertyName, out field, out prop);

        var attrArgs = new List<CodeAttributeArgument>
        {
            new CodeAttributeArgument(new CodePrimitiveExpression(elementName)),
            new CodeAttributeArgument("Namespace", new CodePrimitiveExpression(ns ?? Code.DefaultNs)),
        };

        prop.CustomAttributes.Add(new CodeAttributeDeclaration(
            new CodeTypeReference(typeof(XmlElementAttribute)),
            attrArgs.ToArray()));
    }

    internal static void ConvertForEnum(string enumName, out CodeMemberField field)
    {
        field = new CodeMemberField(typeof(int), Utility.ToPropertyName(enumName));
        field.CustomAttributes.Add(
            new CodeAttributeDeclaration(
                new CodeTypeReference(typeof(XmlEnumAttribute)),
                new CodeAttributeArgument("Name", new CodePrimitiveExpression(enumName))));
    }

    internal static void ConvertForExtension(
        out CodeMemberField field,
        out CodeMemberProperty prop)
    {
        Code.ToProperty(new CodeTypeReference(typeof(string)), "value", out field, out prop);

        prop.CustomAttributes.Add(new CodeAttributeDeclaration(
            new CodeTypeReference(typeof(XmlTextAttribute))));
    }

    internal static void ConvertForSpecified(
        string targetName,
        out CodeMemberField field,
        out CodeMemberProperty prop)
    {
        Code.ToProperty(new CodeTypeReference(typeof(bool)), $"{targetName}_Specified", out field, out prop);

        prop.CustomAttributes.Add(new CodeAttributeDeclaration(
            new CodeTypeReference(typeof(XmlIgnoreAttribute))));
    }

    internal static bool ConvertForType(string className, string elementName, string? ns, bool xmlModifier, bool isAbstract, out CodeTypeDeclaration type)
    {
        var cls = new CodeTypeDeclaration(Utility.ToClassName(className))
        {
            IsPartial = true,
        };

        if (isAbstract)
        {
            cls.TypeAttributes = TypeAttributes.Public | TypeAttributes.Abstract;
        }

        if (xmlModifier)
        {
            var attrArgs = new List<CodeAttributeArgument>
            {
                new CodeAttributeArgument(new CodePrimitiveExpression(elementName)),
                new CodeAttributeArgument("Namespace", new CodePrimitiveExpression(ns ?? Code.DefaultNs)),
            };

            cls.CustomAttributes.Add(new CodeAttributeDeclaration(
                new CodeTypeReference(typeof(XmlTypeAttribute)),
                attrArgs.ToArray()));
        }

        type = cls;
        return true;
    }

    internal static CodeTypeReference ToArray(CodeTypeReference type)
    {
        return new CodeTypeReference
        {
            ArrayElementType = type,
            ArrayRank = 1,
        };
    }

    internal static void WriteFile(string path, CodeNamespace ns)
    {
        var compileUnit = new CodeCompileUnit();
        compileUnit.Namespaces.Add(ns);

        var provider = new CSharpCodeProvider();

        using var stream = File.OpenWrite(path);
        using var writer = new StreamWriter(stream, leaveOpen: true);
        provider.GenerateCodeFromCompileUnit(compileUnit, writer, new CodeGeneratorOptions());
        writer.Flush();
    }

    private static void ToProperty(
        CodeTypeReference type,
        string ideintifier,
        out CodeMemberField field,
        out CodeMemberProperty prop)
    {
        var fieldName = Utility.ToFieldName(ideintifier);
        field = new CodeMemberField(type, fieldName);

        prop = new CodeMemberProperty();
        prop.Type = type;
        prop.Attributes &= ~MemberAttributes.AccessMask & ~MemberAttributes.ScopeMask;
        prop.Attributes |= MemberAttributes.Public | MemberAttributes.Final;
        prop.Name = Utility.ToPropertyName(ideintifier);
        prop.GetStatements.Add(
            new CodeMethodReturnStatement(
                new CodeFieldReferenceExpression(
                    new CodeThisReferenceExpression(), fieldName)));
        prop.SetStatements.Add(
            new CodeAssignStatement(
                new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), fieldName),
                new CodePropertySetValueReferenceExpression()));
    }
}
