using Volo.Abp.AspNetCore.Components.Server.Theming;
using Volo.Abp.Modularity;

namespace Abp.LogCenter.Blazor.Server;

[DependsOn(
    typeof(AbpAspNetCoreComponentsServerThemingModule),
    typeof(LogCenterBlazorModule)
    )]
public class LogCenterBlazorServerModule : AbpModule
{

}
