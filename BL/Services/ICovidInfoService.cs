using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Services;

public interface ICovidInfoService
{
    List<CovidInfoDTO> GetCovidInfo();
    CovidInfoDTO GetCovidInfoById(int id);
    bool AddCovidInfo(CovidInfoDTO covidInfoDTO);
    bool UpdateCovidInfo(int id, CovidInfoDTO covidInfoDTO);
    bool DeleteCovidInfo(int id);
}
