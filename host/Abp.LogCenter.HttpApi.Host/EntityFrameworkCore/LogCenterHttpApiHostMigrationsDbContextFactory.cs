using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Abp.LogCenter.EntityFrameworkCore;

public class LogCenterHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<LogCenterHttpApiHostMigrationsDbContext>
{
    public LogCenterHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<LogCenterHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("LogCenter"));

        return new LogCenterHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
