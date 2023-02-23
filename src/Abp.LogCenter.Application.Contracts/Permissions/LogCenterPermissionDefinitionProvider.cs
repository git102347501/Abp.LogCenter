using Abp.LogCenter.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Abp.LogCenter.Permissions;

public class LogCenterPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(LogCenterPermissions.GroupName, L("Permission:LogCenter"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<LogCenterResource>(name);
    }
}
