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
        var execludedDefines = new[]
        {
            new ExcludeDefine("customElement", "basictypes.rng"),
            new ExcludeDefine("privateDataStorageSource", "privatedata.rng"),
            new ExcludeDefine("privateDataDeviceDisk", "privatedata.rng"),
            new ExcludeDefine("storageStartupPolicy", "storagecommon.rng"),
            new ExcludeDefine("storageSourceExtra", "storagecommon.rng"),
        };

        var rawDefines = new[]
        {
            new RawXmlDefine("metadata", "basictypes.rng"),
        };

        var exceptTypeAttr = new[]
        {
            "bond-interface_bare-ethernet-interface",
            "capabilities_topology",
            "domaincheckpoint_diskcheckpoint",
            "domainsnapshot_disksnapshot",
        };

        var commonDefines = new Dictionary<string, string?>
        {
            { "basictypes.rng", null },
            { "networkcommon.rng", "network" },
            { "storagecommon.rng", "storage" },
        };

        var dir = new DirectoryInfo(directory);
        var files = dir.GetFiles("*.rng").Select(f => new RngFile(f)).ToDictionary(
            f => f.Info.Name,
            f => f);

        var repository = new Repository(files.Values.ToArray(), execludedDefines);
        var builder = new AstBuilder(repository, rawDefines);
        var types = builder.Types
            .Where(t => !t.FundamentalType)
            .OfType<AstTypeDeclarationBase>()
            .Concat(builder.MergedTypes)
            .Where(t => t.StartReachable)
            .ToArray();

        var gen = new Generator(types, exceptTypeAttr, commonDefines);
        gen.Compile();

        var ns = new CodeNamespace("Libvirt.Model");
        Array.ForEach(gen.Types, t => ns.Types.Add(t));

        Code.WriteFile("Generated.cs", ns);
    }
}
