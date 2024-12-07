using System;
using System.Collections.Generic;

namespace Finally.Models;

public partial class TeachSubject
{
    public int TeacherId { get; set; }

    public int SubjectId { get; set; }

    public string Course { get; set; } = null!;

    public virtual Subject Subject { get; set; } = null!;

    public virtual Teacher Teacher { get; set; } = null!;
}
