using AutoMapper;
using Common;
using DAL.Models;
using DAL.Repositories;

namespace BL.Services;

public class PatientService : IPatientService
{
    readonly IPatientRepository patientRepository;
    readonly IMapper mapper;

    public PatientService(IPatientRepository patientRepository, IMapper mapper)
    {
        this.patientRepository = patientRepository;
        this.mapper = mapper;
    }

    public bool AddPatient(PatientDTO patientDTO)
    {
        Patient patient = mapper.Map<Patient>(patientDTO);
        return patientRepository.AddPatient(patient);
    }

    public bool DeletePatient(int id)
    {
        return patientRepository.DeletePatient(id);
    }

    public PatientWithCovidInfoDTO GetPatient(int id)
    {
        Patient? patient = patientRepository.GetPatient(id);
        PatientWithCovidInfoDTO patientWithCovidInfoDTO = mapper.Map<PatientWithCovidInfoDTO>(patient);
        return patientWithCovidInfoDTO;
    }

    public List<PatientWithCovidInfoDTO> GetPatients()
    {
        List<Patient> patients = patientRepository.GetPatients();
        List<PatientWithCovidInfoDTO> patientWithCovidInfoDTO = mapper.Map<List<PatientWithCovidInfoDTO>>(patients);
        return patientWithCovidInfoDTO;
    }

    public bool UpdatePatient(int id, PatientDTO patientDTO)
    {
        Patient patient = mapper.Map<Patient>(patientDTO);
        return patientRepository.UpdatePatient(id, patient);
    }
}
