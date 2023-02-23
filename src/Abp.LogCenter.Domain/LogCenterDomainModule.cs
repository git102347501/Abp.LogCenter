using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Abp.LogCenter;

[DependsOn(
    typeof(AbpDddDomainModule),
    typeof(LogCenterDomainSharedModule)
)]
public class LogCenterDomainModule : AbpModule
{

}
