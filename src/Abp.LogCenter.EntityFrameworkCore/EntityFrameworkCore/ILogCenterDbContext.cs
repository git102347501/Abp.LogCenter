using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Abp.LogCenter.EntityFrameworkCore;

[ConnectionStringName(LogCenterDbProperties.ConnectionStringName)]
public interface ILogCenterDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
