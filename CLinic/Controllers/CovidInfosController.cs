using BL.Services;
using Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Clinic.Controllers;

public class CovidInfosController : BaseController
{
    readonly ICovidInfoService covidInfoService;
    public CovidInfosController(ICovidInfoService covidInfoService)
    {
        this.covidInfoService = covidInfoService;
    }

    [HttpGet]
    public async Task<ActionResult<List<CovidInfoDTO>>> GetAll()
    {
        var result = covidInfoService.GetCovidInfo();
        if (result.Count == 0)
        {
            return await Task.FromResult(NoContent());
        }
        return await Task.FromResult(result);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<CovidInfoDTO>> GetByID(int id)
    {
        var result = covidInfoService.GetCovidInfoById(id);
        if (result == null)
        {
            return await Task.FromResult(NoContent());
        }
        return await Task.FromResult(result);
    }

    [HttpPost]
    public async Task<bool> PostCovidInfo(CovidInfoDTO covidInfoDTO)
    {
        return await Task.FromResult(covidInfoService.AddCovidInfo(covidInfoDTO));
    }

    [HttpPut("{id}")]
    public async Task<bool> PutCovidInfo(int id, CovidInfoDTO covidInfoDTO)
    {
        return await Task.FromResult(covidInfoService.UpdateCovidInfo(id, covidInfoDTO));
    }

    [HttpDelete("{id}")]
    public async Task<bool> DeleteCovidInfo(int id)
    {
        return await Task.FromResult(covidInfoService.DeleteCovidInfo(id));
    }
}
