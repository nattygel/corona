using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Patient
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

    public virtual Covid19Detail? Covid19Detail { get; set; }
}
