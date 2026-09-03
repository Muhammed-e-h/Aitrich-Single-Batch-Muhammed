using NEWJOBPORTAL.Interfaces;
using NEWJOBPORTAL.Models;
using NEWJOBPORTAL.Pages;
using JobPortal.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NEWJOBPORTAL.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IJobService _jobService;
        public List<Job> JobPosts { get; set; }

        public IndexModel(IJobService jobService)
        {
            _jobService = jobService;
        }
       
        public async Task OnGetAsync()
        {
            JobPosts = await _jobService.GetAllJobsAsync();
        }
    }
}
