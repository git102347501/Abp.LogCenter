using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Abp.LogCenter.EntityFrameworkCore;

[ConnectionStringName(LogCenterDbProperties.ConnectionStringName)]
public class LogCenterDbContext : AbpDbContext<LogCenterDbContext>, ILogCenterDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public LogCenterDbContext(DbContextOptions<LogCenterDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureLogCenter();
    }
}
