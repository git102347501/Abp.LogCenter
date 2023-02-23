using Abp.LogCenter.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Abp.LogCenter.Blazor.Server.Host;

public abstract class LogCenterComponentBase : AbpComponentBase
{
    protected LogCenterComponentBase()
    {
        LocalizationResource = typeof(LogCenterResource);
    }
}
