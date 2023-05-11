using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories;

public interface ICovidInfoRepository
{
    List<Covid19Detail> GetCovid19Details();
    Covid19Detail? GetCovid19DetailsById(int id);
    bool AddCovid19Details(Covid19Detail detail);
    bool UpdateCovid19Details(int id, Covid19Detail detail);
    bool DeleteCovid19Details(int id);
}
