using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories;

public class CovidInfoRepository : ICovidInfoRepository
{
    readonly ClinicContext context;
    public CovidInfoRepository(ClinicContext context)
    {
        this.context = context;
    }
    public bool AddCovid19Details(Covid19Detail detail)
    {
        context.Covid19Details.Add(detail);
        context.SaveChanges();
        return true;
    }

    public bool DeleteCovid19Details(int id)
    {
        Covid19Detail? covid19Detail = context.Covid19Details.Find(id);
        if (covid19Detail != null)
        {
            context.Covid19Details.Remove(covid19Detail);
            context.SaveChanges();
            return true;
        }
        return false;
    }

    public List<Covid19Detail> GetCovid19Details()
    {
        return context.Covid19Details.ToList();
    }

    public Covid19Detail? GetCovid19DetailsById(int id)
    {
        return context.Covid19Details.Find(id);
    }

    public bool UpdateCovid19Details(int id, Covid19Detail detail)
    {
        if (context.Covid19Details.Find(id) != null)
        {
            context.Covid19Details.Find(id).Vaccination1 = detail.Vaccination1;
            context.Covid19Details.Find(id).Vaccine1Manufacturer = detail.Vaccine1Manufacturer;
            context.Covid19Details.Find(id).Vaccination2 = detail.Vaccination2;
            context.Covid19Details.Find(id).Vaccine2Manufacturer = detail.Vaccine2Manufacturer;
            context.Covid19Details.Find(id).Vaccination3 = detail.Vaccination3;
            context.Covid19Details.Find(id).Vaccine3Manufacturer = detail.Vaccine3Manufacturer;
            context.Covid19Details.Find(id).Vaccination4 = detail.Vaccination4;
            context.Covid19Details.Find(id).Vaccine4Manufacturer = detail.Vaccine4Manufacturer;
            context.Covid19Details.Find(id).PositiveResultDate = detail.PositiveResultDate;
            context.Covid19Details.Find(id).RecoveryDate = detail.RecoveryDate;
            context.Covid19Details.Find(id).Patient = detail.Patient;
            return true;
        }
        return false;
    }
}
