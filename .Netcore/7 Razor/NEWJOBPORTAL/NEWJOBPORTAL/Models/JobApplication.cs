using System;
using System.Collections.Generic;

namespace NEWJOBPORTAL.Models;

public partial class JobApplication
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int JobId { get; set; }

    public DateTime AppliedDate { get; set; }

    public string Status { get; set; } = null!;

    public virtual Job Job { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
