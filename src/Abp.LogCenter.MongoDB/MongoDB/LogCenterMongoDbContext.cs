using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Abp.LogCenter.MongoDB;

[ConnectionStringName(LogCenterDbProperties.ConnectionStringName)]
public class LogCenterMongoDbContext : AbpMongoDbContext, ILogCenterMongoDbContext
{
    /* Add mongo collections here. Example:
     * public IMongoCollection<Question> Questions => Collection<Question>();
     */

    protected override void CreateModel(IMongoModelBuilder modelBuilder)
    {
        base.CreateModel(modelBuilder);

        modelBuilder.ConfigureLogCenter();
    }
}
