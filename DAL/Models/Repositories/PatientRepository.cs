using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DAL.Repositories;

public class PatientRepository : IPatientRepository
{
    readonly ClinicContext context;
    public PatientRepository(ClinicContext context)
    {
        this.context = context;
    }
    public bool AddPatient(Patient patient)
    {
        context.Patients.AddAsync(patient);
        context.SaveChanges();
        return true;
    }

    public bool DeletePatient(int id)
    {
        Patient? patient = context.Patients.FirstOrDefault(x => x.Id == id);
        if (patient != null)
        {
            context.Patients.Remove(patient);
            context.SaveChanges();
            return true;
        }
        return false;
    }

    public Patient? GetPatient(int id)
    {
        return context.Patients.Find(id);//.Include(p => p.Covid19Detail).FirstOrDefault(x => x.Id == id);
    }

    public List<Patient> GetPatients()
    {
        return context.Patients.Include(patient => patient.Covid19Detail).ToList();
    }

    public bool UpdatePatient(int id, Patient patient)
    {
        if (context.Patients.Find(id) != null)
        {
            context.Patients.Find(id).FirstName = patient.FirstName;
            context.Patients.Find(id).LastName = patient.LastName;
            context.Patients.Find(id).City = patient.City;
            context.Patients.Find(id).Street = patient.Street;
            context.Patients.Find(id).HouseNumber = patient.HouseNumber;
            context.Patients.Find(id).DateOfBirth = patient.DateOfBirth;
            context.Patients.Find(id).Cellphone = patient.Cellphone;
            context.Patients.Find(id).PhoneNumber = patient.PhoneNumber;
            context.SaveChanges();
            return true;
        }
        return false;
    }
}
