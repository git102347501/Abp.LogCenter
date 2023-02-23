using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Sqlite;
using Volo.Abp.Modularity;

namespace Abp.LogCenter.EntityFrameworkCore;

[DependsOn(
    typeof(LogCenterTestBaseModule),
    typeof(LogCenterEntityFrameworkCoreModule),
    typeof(AbpEntityFrameworkCoreSqliteModule)
    )]
public class LogCenterEntityFrameworkCoreTestModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        var sqliteConnection = CreateDatabaseAndGetConnection();

        Configure<AbpDbContextOptions>(options =>
        {
            options.Configure(abpDbContextConfigurationContext =>
            {
                abpDbContextConfigurationContext.DbContextOptions.UseSqlite(sqliteConnection);
            });
        });
    }

    private static SqliteConnection CreateDatabaseAndGetConnection()
    {
        var connection = new SqliteConnection("Data Source=:memory:");
        connection.Open();

        new LogCenterDbContext(
            new DbContextOptionsBuilder<LogCenterDbContext>().UseSqlite(connection).Options
        ).GetService<IRelationalDatabaseCreator>().CreateTables();

        return connection;
    }
}
