using System;
using System.Collections.Generic;

namespace Finally.Models;

public partial class ScheduleStu
{
    public int ScheduleStuId { get; set; }

    public int ScheduleId { get; set; }

    public int StudentId { get; set; }

    public int Status { get; set; }

    public virtual Schedule Schedule { get; set; } = null!;

    public virtual Student Student { get; set; } = null!;
}
