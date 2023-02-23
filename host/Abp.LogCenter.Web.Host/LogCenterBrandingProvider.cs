using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Abp.LogCenter;

[Dependency(ReplaceServices = true)]
public class LogCenterBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "LogCenter";
}
