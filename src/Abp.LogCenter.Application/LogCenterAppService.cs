using Abp.LogCenter.Localization;
using Volo.Abp.Application.Services;

namespace Abp.LogCenter;

public abstract class LogCenterAppService : ApplicationService
{
    protected LogCenterAppService()
    {
        LocalizationResource = typeof(LogCenterResource);
        ObjectMapperContext = typeof(LogCenterApplicationModule);
    }
}
