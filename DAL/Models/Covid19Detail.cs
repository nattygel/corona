using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Covid19Detail
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

    public virtual Patient Patient { get; set; } = null!;
}
