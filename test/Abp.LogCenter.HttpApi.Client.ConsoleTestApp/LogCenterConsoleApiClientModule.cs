using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Abp.LogCenter;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(LogCenterHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class LogCenterConsoleApiClientModule : AbpModule
{

}
