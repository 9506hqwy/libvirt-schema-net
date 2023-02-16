namespace Gen;

using RelaxNg.Schema;
using System;
using System.IO;

internal class MainShell
{
    internal static void Main(string[] args)
    {
        try
        {
            var shell = new MainShell();
            shell.Work(args);
        }
        catch (Exception e)
        {
            Console.Error.WriteLine("{0}", e);
        }
    }

    internal void Work(string[] args)
    {
        this.WriteGenerated(args[0]);
    }

    internal void WriteGenerated(string directory)
    {
        var dir = new DirectoryInfo(directory);
        var files = dir.GetFiles("*.rng").Select(f => new RngFile(f)).ToDictionary(
            f => f.Info.Name,
            f => f);

        var context = new CodeContext();
        context.ClassNamePrefix.Add("storagecommon.rng", "storage");

        var schema = new Schema();

        // secret.rng
        this.Parse(schema, files["secret.rng"]).CollectType(context);

        // storagepool.rng
        files["storagepool.rng"].Parse(schema);
        this.Parse(schema, files["storagepool.rng"]).CollectInheritedType(context, schema.GetDefine("pool"));

        // storagepoolcaps.rng
        this.Parse(schema, files["storagepoolcaps.rng"]).CollectType(context);

        // storagevol.rng
        this.Parse(schema, files["storagevol.rng"]).CollectType(context);

        foreach (var warning in context.Warnings)
        {
            Console.Error.WriteLine("{0}", warning);
        }

        var ns = new CodeNamespace("Libvirt.Model");
        foreach (var cls in context.EnumerateTypes())
        {
            ns.Types.Add(cls.Type);
        }

        Code.WriteFile("Generated.cs", ns);
    }

    private Start Parse(Schema schema, RngFile file)
    {
        file.Parse(schema);
        return file
            .Enumerate(schema)!
            .SelectMany(p => p.DescendantNodesAndSelf)
            .OfType<Start>()
            .Single();
    }
}
