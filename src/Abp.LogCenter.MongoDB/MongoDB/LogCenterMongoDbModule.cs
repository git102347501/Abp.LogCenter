using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;
using Volo.Abp.MongoDB;

namespace Abp.LogCenter.MongoDB;

[DependsOn(
    typeof(LogCenterDomainModule),
    typeof(AbpMongoDbModule)
    )]
public class LogCenterMongoDbModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddMongoDbContext<LogCenterMongoDbContext>(options =>
        {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, MongoQuestionRepository>();
                 */
        });
    }
}
