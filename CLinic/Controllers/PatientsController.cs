using BL.Services;
using Common;
using Microsoft.AspNetCore.Mvc;

namespace Clinic.Controllers;

public class PatientsController : BaseController
{
    readonly IPatientService patientService;
    public PatientsController(IPatientService patientService)
    {
        this.patientService = patientService;
    }

    [HttpGet]
    public async Task<ActionResult<List<PatientWithCovidInfoDTO>>> GetAll()
    {
        var result = patientService.GetPatients();
        if (result.Count == 0)
        {
            return await Task.FromResult(NoContent());
        }
        return await Task.FromResult(result);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<PatientWithCovidInfoDTO>> GetById(int id)
    {
        var result = patientService.GetPatient(id);
        if (result == null)
        {
            return await Task.FromResult(NoContent());
        }
        return await Task.FromResult(result);
    }

    [HttpPost]
    public async Task<bool> PostPatient(PatientDTO patientDTO)
    {
        return await Task.FromResult(patientService.AddPatient(patientDTO));
    }

    [HttpPut("{id}")]
    public async Task<bool> PutPatient(int id, PatientDTO patientDTO)
    {
        return await Task.FromResult(patientService.UpdatePatient(id, patientDTO));
    }

    [HttpDelete("{id}")]
    public async Task<bool> DeletePatient(int id)
    {
        return await Task.FromResult(patientService.DeletePatient(id));
    }
}

