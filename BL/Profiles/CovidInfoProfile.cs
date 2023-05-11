using AutoMapper;
using Common;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Profiles;

public class CovidInfoProfile :Profile
{
    public CovidInfoProfile()
    {
        CreateMap<Covid19Detail, CovidInfoDTO>().ReverseMap();
    }
}
