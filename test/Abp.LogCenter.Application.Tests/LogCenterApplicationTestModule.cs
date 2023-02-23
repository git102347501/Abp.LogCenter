using Volo.Abp.Modularity;

namespace Abp.LogCenter;

[DependsOn(
    typeof(LogCenterApplicationModule),
    typeof(LogCenterDomainTestModule)
    )]
public class LogCenterApplicationTestModule : AbpModule
{

}
