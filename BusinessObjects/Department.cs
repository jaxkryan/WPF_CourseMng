using System;
using System.Collections.Generic;

namespace BusinessObjects;

public partial class Department
{
    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int Status { get; set; }

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
