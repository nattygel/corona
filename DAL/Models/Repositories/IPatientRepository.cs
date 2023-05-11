using DAL.Models;

namespace DAL.Repositories;

public interface IPatientRepository
{
    List<Patient> GetPatients();
    Patient? GetPatient(int id);
    bool AddPatient(Patient patient);
    bool UpdatePatient(int id, Patient patient);
    bool DeletePatient(int id);
}
