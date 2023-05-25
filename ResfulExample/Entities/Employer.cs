using System;
using System.Collections.Generic;

namespace ResfulExample.Entities;

public partial class Employer
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? PhoneNumbre { get; set; }

    public string? Email { get; set; }

    public DateTime BirthDate { get; set; }
}
