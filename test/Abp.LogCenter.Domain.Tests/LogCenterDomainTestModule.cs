using Abp.LogCenter.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Abp.LogCenter;

/* Domain tests are configured to use the EF Core provider.
 * You can switch to MongoDB, however your domain tests should be
 * database independent anyway.
 */
[DependsOn(
    typeof(LogCenterEntityFrameworkCoreTestModule)
    )]
public class LogCenterDomainTestModule : AbpModule
{

}
