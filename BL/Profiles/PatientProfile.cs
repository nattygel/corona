using AutoMapper;
using Common;
using DAL.Models;

namespace BL.Profiles;

public class PatientProfile : Profile
{
    public PatientProfile()
    {
        CreateMap<Patient, PatientDTO>().ReverseMap();
    }
}
