using System;
using System.Collections.Generic;

namespace NEWJOBPORTAL.Models;

public partial class Job
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public string Company { get; set; } = null!;

    public string? Location { get; set; }

    public decimal? Salary { get; set; }

    public DateTime PostedDate { get; set; }

    public bool IsActive { get; set; }

    public virtual ICollection<JobApplication> JobApplications { get; set; } = new List<JobApplication>();
}
