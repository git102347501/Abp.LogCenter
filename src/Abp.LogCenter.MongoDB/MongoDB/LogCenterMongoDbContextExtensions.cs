using Volo.Abp;
using Volo.Abp.MongoDB;

namespace Abp.LogCenter.MongoDB;

public static class LogCenterMongoDbContextExtensions
{
    public static void ConfigureLogCenter(
        this IMongoModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));
    }
}
