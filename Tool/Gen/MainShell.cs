﻿namespace Gen;

using RelaxNg.Schema;
using System;
using System.IO;

internal class MainShell
{
    internal static void Main(string[] args)
    {
        try
        {
            Work(args);
        }
        catch (Exception e)
        {
            Console.Error.WriteLine("{0}", e);
        }
    }

    internal static void Work(string[] args)
    {
        WriteGenerated(args[0]);
    }

    internal static void WriteGenerated(string directory)
    {
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

        var repository = new Repository([.. files.Values]);
        var builder = new AstBuilder(repository);
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
