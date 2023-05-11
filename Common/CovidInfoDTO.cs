using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common;

public class CovidInfoDTO
{
    public int PatientId { get; set; }

    public DateTime? Vaccination1 { get; set; }

    public string? Vaccine1Manufacturer { get; set; }

    public DateTime? Vaccination2 { get; set; }

    public string? Vaccine2Manufacturer { get; set; }

    public DateTime? Vaccination3 { get; set; }

    public string? Vaccine3Manufacturer { get; set; }

    public DateTime? Vaccination4 { get; set; }

    public string? Vaccine4Manufacturer { get; set; }

    public DateTime? PositiveResultDate { get; set; }

    public DateTime? RecoveryDate { get; set; }
}
