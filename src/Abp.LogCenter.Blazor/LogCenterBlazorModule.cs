using Microsoft.Extensions.DependencyInjection;
using Abp.LogCenter.Blazor.Menus;
using Volo.Abp.AspNetCore.Components.Web.Theming;
using Volo.Abp.AspNetCore.Components.Web.Theming.Routing;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.UI.Navigation;

namespace Abp.LogCenter.Blazor;

[DependsOn(
    typeof(LogCenterApplicationContractsModule),
    typeof(AbpAspNetCoreComponentsWebThemingModule),
    typeof(AbpAutoMapperModule)
    )]
public class LogCenterBlazorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<LogCenterBlazorModule>();

        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddProfile<LogCenterBlazorAutoMapperProfile>(validate: true);
        });

        Configure<AbpNavigationOptions>(options =>
        {
            options.MenuContributors.Add(new LogCenterMenuContributor());
        });

        Configure<AbpRouterOptions>(options =>
        {
            options.AdditionalAssemblies.Add(typeof(LogCenterBlazorModule).Assembly);
        });
    }
}
