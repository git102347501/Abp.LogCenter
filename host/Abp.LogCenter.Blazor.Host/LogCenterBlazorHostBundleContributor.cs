using Volo.Abp.Bundling;

namespace Abp.LogCenter.Blazor.Host;

public class LogCenterBlazorHostBundleContributor : IBundleContributor
{
    public void AddScripts(BundleContext context)
    {

    }

    public void AddStyles(BundleContext context)
    {
        context.Add("main.css", true);
    }
}
