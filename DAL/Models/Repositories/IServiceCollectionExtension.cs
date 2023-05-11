using DAL.Models;
using Microsoft.Extensions.DependencyInjection;

namespace DAL.Repositories;
public static class IServiceCollectionExtension
{
    public static void AddRepositories(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IPatientRepository, PatientRepository>();
        serviceCollection.AddScoped<ICovidInfoRepository, CovidInfoRepository>();
        serviceCollection.AddDbContext<ClinicContext>();
    }
}
