using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;

namespace Abp.LogCenter;

[DependsOn(
    typeof(LogCenterDomainModule),
    typeof(LogCenterApplicationContractsModule),
    typeof(AbpDddApplicationModule),
    typeof(AbpAutoMapperModule)
    )]
public class LogCenterApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<LogCenterApplicationModule>();
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<LogCenterApplicationModule>(validate: true);
        });
    }
}
