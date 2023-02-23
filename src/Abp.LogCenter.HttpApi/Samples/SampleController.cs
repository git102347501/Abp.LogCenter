using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;

namespace Abp.LogCenter.Samples;

[Area(LogCenterRemoteServiceConsts.ModuleName)]
[RemoteService(Name = LogCenterRemoteServiceConsts.RemoteServiceName)]
[Route("api/LogCenter/sample")]
public class SampleController : LogCenterController, ISampleAppService
{
    private readonly ISampleAppService _sampleAppService;

    public SampleController(ISampleAppService sampleAppService)
    {
        _sampleAppService = sampleAppService;
    }

    [HttpGet]
    public async Task<SampleDto> GetAsync()
    {
        return await _sampleAppService.GetAsync();
    }

    [HttpGet]
    [Route("authorized")]
    [Authorize]
    public async Task<SampleDto> GetAuthorizedAsync()
    {
        return await _sampleAppService.GetAsync();
    }
}
