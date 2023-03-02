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
        context.ClassNamePrefix.Add("domaincommon.rng", "domain");
        context.ClassNamePrefix.Add("storagecommon.rng", "storage");
        context.ExcludeDefines.Add("customElement");
        context.ExcludeDefines.Add("privateDataStorageSource");
        context.ExcludeDefines.Add("privateDataDeviceDisk");
        context.ExcludeDefines.Add("diskBackingChain"); // 再帰的参照
        context.ExcludeDefines.Add("oshvm"); // string と enum の choice
        context.ExcludeDefines.Add("rng-backend"); // string と enum の choice
        context.ExcludeTypeAttrs.Add("CapabilitiesCpu");
        context.ExcludeTypeAttrs.Add("CapabilitiesTopology");
        context.ExcludeTypeAttrs.Add("DomainDevSeclabel");
        context.ExcludeTypeAttrs.Add("DomainDiskAuthSecret");
        context.ExcludeTypeAttrs.Add("DomainDiskSourceBlock");
        context.ExcludeTypeAttrs.Add("DomainDiskSourceDir");
        context.ExcludeTypeAttrs.Add("DomainDiskSourceFile");
        context.ExcludeTypeAttrs.Add("DomainDiskSourceNetworkProtocolFtps");
        context.ExcludeTypeAttrs.Add("DomainDiskSourceNetworkProtocolGluster");
        context.ExcludeTypeAttrs.Add("DomainDiskSourceNetworkProtocolHttp");
        context.ExcludeTypeAttrs.Add("DomainDiskSourceNetworkProtocolHttps");
        context.ExcludeTypeAttrs.Add("DomainDiskSourceNetworkProtocolIscsi");
        context.ExcludeTypeAttrs.Add("DomainDiskSourceNetworkProtocolNbd");
        context.ExcludeTypeAttrs.Add("DomainDiskSourceNetworkProtocolNfs");
        context.ExcludeTypeAttrs.Add("DomainDiskSourceNetworkProtocolRbd");
        context.ExcludeTypeAttrs.Add("DomainDiskSourceNetworkProtocolSimple");
        context.ExcludeTypeAttrs.Add("DomainDiskSourceNetworkProtocolVxHs");
        context.ExcludeTypeAttrs.Add("DomainDiskSourceNvme");
        context.ExcludeTypeAttrs.Add("DomainDiskSourceVhostUser");
        context.ExcludeTypeAttrs.Add("DomainDiskSourceVolume");
        context.ExcludeTypeAttrs.Add("DomainFsDriver");
        context.ExcludeTypeAttrs.Add("DomainGuestfwdTarget");
        context.ExcludeTypeAttrs.Add("DomainHostdevcapsmisc");
        context.ExcludeTypeAttrs.Add("DomainHostdevcapsstorage");
        context.ExcludeTypeAttrs.Add("DomainHostdevsubsyshost");
        context.ExcludeTypeAttrs.Add("DomainHostdevsubsysmdev");
        context.ExcludeTypeAttrs.Add("DomainHostdevsubsysscsi");
        context.ExcludeTypeAttrs.Add("DomainHostdevsubsysusb");
        context.ExcludeTypeAttrs.Add("DomainMemorydevSource");
        context.ExcludeTypeAttrs.Add("DomainMemorydevTarget");
        context.ExcludeTypeAttrs.Add("DomainQemucdevTgtDef");
        context.ExcludeTypeAttrs.Add("DomainQemucdevSerialTgtModel");
        context.ExcludeTypeAttrs.Add("DomainTpmBackendEmulatorEncryption");
        context.ExcludeTypeAttrs.Add("DomainTpmExternalSource");
        context.ExcludeTypeAttrs.Add("DomainVirtioTarget");
        context.ExcludeTypeAttrs.Add("DomainXenTarget");
        context.ExcludeTypeAttrs.Add("NumaCache");
        context.PropertyAliases.Add(new PropertyAlias("capscsi", "type", true, "type_ex"));
        context.PropertyAliases.Add(new PropertyAlias("capdrm", "type", true, "type_ex"));
        context.PropertyAliases.Add(new PropertyAlias("capmdev", "type", true, "type_ex"));
        context.PropertyAliases.Add(new PropertyAlias("mdev_types", "type", true, "type_ex"));

        var schema = new Schema();

        // capability.rng
        this.Parse(schema, files["capability.rng"]).CollectType(context);

        // cpu.rng
        this.Parse(schema, files["cpu.rng"]).CollectType(context);

        // domain.rng
        this.Parse(schema, files["domain.rng"]).CollectType(context);

        // domainbackup.rng
        this.Parse(schema, files["domainbackup.rng"]).CollectType(context);

        // domaincheckpoint.rng
        this.Parse(schema, files["domaincheckpoint.rng"]).CollectType(context);

        // network.rng
        this.Parse(schema, files["network.rng"]).CollectType(context);

        // networkport.rng
        this.Parse(schema, files["networkport.rng"]).CollectType(context);

        // nodedev.rng
        this.Parse(schema, files["nodedev.rng"]).CollectType(context);

        // nwfilter.rng
        this.Parse(schema, files["nwfilter.rng"]).CollectType(context);

        // nwfilterbinding.rng
        this.Parse(schema, files["nwfilterbinding.rng"]).CollectType(context);

        // secret.rng
        this.Parse(schema, files["secret.rng"]).CollectType(context);

        // storagepool.rng
        files["storagepool.rng"].Parse(schema);
        this.Parse(schema, files["storagepool.rng"]).CollectInheritedType(context, schema.GetDefine("pool"));

        // storagepoolcaps.rng
        this.Parse(schema, files["storagepoolcaps.rng"]).CollectType(context);

        // storagevol.rng
        this.Parse(schema, files["storagevol.rng"]).CollectType(context);

        context.Gen();

        var ns = new CodeNamespace("Libvirt.Model");
        foreach (var cls in context.EnumerateTypes())
        {
            ns.Types.Add(cls.Type!);
        }

        foreach (var warning in context.Warnings)
        {
            Console.Error.WriteLine("{0}", warning);
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
