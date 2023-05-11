using Common;

namespace BL.Services;

public interface IPatientService
{
    List<PatientWithCovidInfoDTO> GetPatients();
    PatientWithCovidInfoDTO GetPatient(int id);
    bool AddPatient(PatientDTO patient);
    bool UpdatePatient(int id, PatientDTO patient);
    bool DeletePatient(int id);
}
