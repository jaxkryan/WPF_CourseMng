using System;
using System.Collections.Generic;

namespace Finally.Models;

public partial class GradeDetail
{
    public int GradeId { get; set; }

    public decimal? PresentScore { get; set; }

    public decimal? LabScore { get; set; }

    public decimal? Ptscore { get; set; }

    public decimal? Fescore { get; set; }

    public decimal? OverallScore { get; set; }

    public virtual ICollection<Grade> Grades { get; set; } = new List<Grade>();
}
