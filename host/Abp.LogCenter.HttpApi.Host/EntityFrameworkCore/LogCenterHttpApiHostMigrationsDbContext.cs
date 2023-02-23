using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Abp.LogCenter.EntityFrameworkCore;

public class LogCenterHttpApiHostMigrationsDbContext : AbpDbContext<LogCenterHttpApiHostMigrationsDbContext>
{
    public LogCenterHttpApiHostMigrationsDbContext(DbContextOptions<LogCenterHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureLogCenter();
    }
}
