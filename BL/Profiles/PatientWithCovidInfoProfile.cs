using AutoMapper;
using Common;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Profiles;

public class PatientWithCovidInfoProfile : Profile
{
    public PatientWithCovidInfoProfile()
    {
        CreateMap<Patient, PatientWithCovidInfoDTO>()
            .ForPath(dest => dest.covidInfoDTO.Vaccination1, opt => opt.MapFrom(src => src.Covid19Detail.Vaccination1))
            .ForPath(dest => dest.covidInfoDTO.Vaccination2, opt => opt.MapFrom(src => src.Covid19Detail.Vaccination2))
            .ForPath(dest => dest.covidInfoDTO.Vaccination3, opt => opt.MapFrom(src => src.Covid19Detail.Vaccination3))
            .ForPath(dest => dest.covidInfoDTO.Vaccination4, opt => opt.MapFrom(src => src.Covid19Detail.Vaccination4))
            .ForPath(dest => dest.covidInfoDTO.Vaccine1Manufacturer, opt => opt.MapFrom(src => src.Covid19Detail.Vaccine1Manufacturer))
            .ForPath(dest => dest.covidInfoDTO.Vaccine2Manufacturer, opt => opt.MapFrom(src => src.Covid19Detail.Vaccine2Manufacturer))
            .ForPath(dest => dest.covidInfoDTO.Vaccine3Manufacturer, opt => opt.MapFrom(src => src.Covid19Detail.Vaccine3Manufacturer))
            .ForPath(dest => dest.covidInfoDTO.Vaccine4Manufacturer, opt => opt.MapFrom(src => src.Covid19Detail.Vaccine4Manufacturer))
            .ForPath(dest => dest.covidInfoDTO.PositiveResultDate, opt => opt.MapFrom(src => src.Covid19Detail.PositiveResultDate))
            .ForPath(dest => dest.covidInfoDTO.RecoveryDate, opt => opt.MapFrom(src => src.Covid19Detail.RecoveryDate));        
    }

}
