using Abp.LogCenter.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Abp.LogCenter;

public abstract class LogCenterController : AbpControllerBase
{
    protected LogCenterController()
    {
        LocalizationResource = typeof(LogCenterResource);
    }
}
