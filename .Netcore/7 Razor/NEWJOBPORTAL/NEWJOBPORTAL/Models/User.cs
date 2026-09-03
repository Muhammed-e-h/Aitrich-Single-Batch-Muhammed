using System;
using System.Collections.Generic;

namespace NEWJOBPORTAL.Models;

public partial class User
{
    public int Id { get; set; }

    public string UserName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public virtual ICollection<JobApplication> JobApplications { get; set; } = new List<JobApplication>();
}
