namespace Common;

public class PatientDTO
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string City { get; set; } = null!;

    public string Street { get; set; } = null!;

    public int HouseNumber { get; set; }

    public DateTime DateOfBirth { get; set; }

    public string PhoneNumber { get; set; } = null!;

    public string? Cellphone { get; set; }

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
