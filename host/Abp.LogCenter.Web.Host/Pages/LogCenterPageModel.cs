using Abp.LogCenter.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Abp.LogCenter.Pages;

public abstract class LogCenterPageModel : AbpPageModel
{
    protected LogCenterPageModel()
    {
        LocalizationResourceType = typeof(LogCenterResource);
    }
}
