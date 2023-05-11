using AutoMapper;
using Common;
using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Services;

public class CovidInfoService : ICovidInfoService
{
    readonly ICovidInfoRepository covidInfoRepository;
    readonly IMapper mapper;
    public CovidInfoService(ICovidInfoRepository covidInfoRepository, IMapper mapper)
    {
        this.covidInfoRepository = covidInfoRepository;
        this.mapper = mapper;
    }

    public bool AddCovidInfo(CovidInfoDTO covidInfoDTO)
    {
        Covid19Detail covid19Detail  = mapper.Map<Covid19Detail>(covidInfoDTO);
        return covidInfoRepository.AddCovid19Details(covid19Detail);
    }

    public bool DeleteCovidInfo(int id)
    {
        return covidInfoRepository.DeleteCovid19Details(id);
    }

    public CovidInfoDTO GetCovidInfoById(int id)
    {
        Covid19Detail? covid19Detail = covidInfoRepository.GetCovid19DetailsById(id);
        CovidInfoDTO covidInfoDTO = mapper.Map<CovidInfoDTO>(covid19Detail);
        return covidInfoDTO;
    }

    public List<CovidInfoDTO> GetCovidInfo()
    {
        List<Covid19Detail> covid19Details = covidInfoRepository.GetCovid19Details();
        List<CovidInfoDTO> covidInfoDTOs = mapper.Map<List<CovidInfoDTO>>(covid19Details);
        return covidInfoDTOs;
    }

    public bool UpdateCovidInfo(int id, CovidInfoDTO covidInfoDTO)
    {
        Covid19Detail covid19Detail = mapper.Map<Covid19Detail>(covidInfoDTO);
        return covidInfoRepository.UpdateCovid19Details(id, covid19Detail);
    }
}
