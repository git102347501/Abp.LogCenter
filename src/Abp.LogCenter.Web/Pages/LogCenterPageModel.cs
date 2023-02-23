using Abp.LogCenter.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Abp.LogCenter.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class LogCenterPageModel : AbpPageModel
{
    protected LogCenterPageModel()
    {
        LocalizationResourceType = typeof(LogCenterResource);
        ObjectMapperContext = typeof(LogCenterWebModule);
    }
}
