using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Abp.LogCenter;

[DependsOn(
    typeof(LogCenterApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class LogCenterHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(LogCenterApplicationContractsModule).Assembly,
            LogCenterRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<LogCenterHttpApiClientModule>();
        });

    }
}
