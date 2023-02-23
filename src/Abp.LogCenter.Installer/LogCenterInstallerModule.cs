using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Abp.LogCenter;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class LogCenterInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<LogCenterInstallerModule>();
        });
    }
}
