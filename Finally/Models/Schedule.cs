using System;
using System.Collections.Generic;

namespace Finally.Models;

public partial class Schedule
{
    public string? DayOfWeeks { get; set; }

    public int? Slot { get; set; }

    public int ClassId { get; set; }

    public int TeacherId { get; set; }

    public int SubjectId { get; set; }

    public int ScheduleId { get; set; }

    public virtual Class? Class { get; set; }

    public virtual ICollection<ScheduleStu> ScheduleStus { get; set; } = new List<ScheduleStu>();

    public virtual Subject? Subject { get; set; }

    public virtual Teacher? Teacher { get; set; }
}
