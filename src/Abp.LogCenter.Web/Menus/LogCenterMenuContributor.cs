using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace Abp.LogCenter.Web.Menus;

public class LogCenterMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        //Add main menu items.
        context.Menu.AddItem(new ApplicationMenuItem(LogCenterMenus.Prefix, displayName: "LogCenter", "~/LogCenter", icon: "fa fa-globe"));

        return Task.CompletedTask;
    }
}
