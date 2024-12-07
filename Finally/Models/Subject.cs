using System;
using System.Collections.Generic;

namespace Finally.Models;

public partial class Subject
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Grade> Grades { get; set; } = new List<Grade>();

    public virtual ICollection<Schedule> Schedules { get; set; } = new List<Schedule>();

    public virtual ICollection<TeachSubject> TeachSubjects { get; set; } = new List<TeachSubject>();
}
