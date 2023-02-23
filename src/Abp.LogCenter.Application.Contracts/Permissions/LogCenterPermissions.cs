using Volo.Abp.Reflection;

namespace Abp.LogCenter.Permissions;

public class LogCenterPermissions
{
    public const string GroupName = "LogCenter";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(LogCenterPermissions));
    }
}
