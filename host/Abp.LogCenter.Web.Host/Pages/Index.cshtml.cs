using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace Abp.LogCenter.Pages;

public class IndexModel : LogCenterPageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
