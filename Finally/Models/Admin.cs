using System;
using System.Collections.Generic;

namespace Finally.Models;

public partial class Admin
{
    public int Id { get; set; }

    public string? FullName { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    public int? Gender { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Address { get; set; }

    public int? AccountId { get; set; }

    public virtual Account? Account { get; set; }
}
