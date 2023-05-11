using BL.Profiles;
using DAL.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Services;

public static class IServiceCollectionExtention
{
    public static void AddServices(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IPatientService, PatientService>();
        serviceCollection.AddScoped<ICovidInfoService, CovidInfoService>();
        serviceCollection.AddAutoMapper(config => config.AddProfile<PatientProfile>());
        serviceCollection.AddAutoMapper(config => config.AddProfile<PatientWithCovidInfoProfile>());
        serviceCollection.AddAutoMapper(config => config.AddProfile<CovidInfoProfile>());

        serviceCollection.AddRepositories();
    }
}
