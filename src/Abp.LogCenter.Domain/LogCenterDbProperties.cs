namespace Abp.LogCenter;

public static class LogCenterDbProperties
{
    public static string DbTablePrefix { get; set; } = "LogCenter";

    public static string DbSchema { get; set; } = null;

    public const string ConnectionStringName = "LogCenter";
}
