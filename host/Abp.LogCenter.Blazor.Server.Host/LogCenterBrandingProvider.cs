using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Abp.LogCenter.Blazor.Server.Host;

[Dependency(ReplaceServices = true)]
public class LogCenterBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "LogCenter";
}
