using Localization.Resources.AbpUi;
using Abp.LogCenter.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Abp.LogCenter;

[DependsOn(
    typeof(LogCenterApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class LogCenterHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(LogCenterHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<LogCenterResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
