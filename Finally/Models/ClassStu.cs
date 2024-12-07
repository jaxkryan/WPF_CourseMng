using System;
using System.Collections.Generic;

namespace Finally.Models;

public partial class ClassStu
{
    public int ClassId { get; set; }

    public int StudentId { get; set; }

    public int? Course { get; set; }

    public virtual Class Class { get; set; } = null!;

    public virtual Student Student { get; set; } = null!;
}
