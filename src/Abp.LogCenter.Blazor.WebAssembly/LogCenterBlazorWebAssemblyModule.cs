using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.Modularity;

namespace Abp.LogCenter.Blazor.WebAssembly;

[DependsOn(
    typeof(LogCenterBlazorModule),
    typeof(LogCenterHttpApiClientModule),
    typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule)
    )]
public class LogCenterBlazorWebAssemblyModule : AbpModule
{

}
