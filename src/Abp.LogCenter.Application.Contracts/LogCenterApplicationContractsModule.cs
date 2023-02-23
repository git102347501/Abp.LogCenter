using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace Abp.LogCenter;

[DependsOn(
    typeof(LogCenterDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class LogCenterApplicationContractsModule : AbpModule
{

}
