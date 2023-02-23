using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.DependencyInjection;
using Abp.LogCenter.Localization;
using Abp.LogCenter.Web.Menus;
using Volo.Abp.AspNetCore.Mvc.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.UI.Navigation;
using Volo.Abp.VirtualFileSystem;
using Abp.LogCenter.Permissions;

namespace Abp.LogCenter.Web;

[DependsOn(
    typeof(LogCenterApplicationContractsModule),
    typeof(AbpAspNetCoreMvcUiThemeSharedModule),
    typeof(AbpAutoMapperModule)
    )]
public class LogCenterWebModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.PreConfigure<AbpMvcDataAnnotationsLocalizationOptions>(options =>
        {
            options.AddAssemblyResource(typeof(LogCenterResource), typeof(LogCenterWebModule).Assembly);
        });

        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(LogCenterWebModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpNavigationOptions>(options =>
        {
            options.MenuContributors.Add(new LogCenterMenuContributor());
        });

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<LogCenterWebModule>();
        });

        context.Services.AddAutoMapperObjectMapper<LogCenterWebModule>();
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<LogCenterWebModule>(validate: true);
        });

        Configure<RazorPagesOptions>(options =>
        {
                //Configure authorization.
            });
    }
}
