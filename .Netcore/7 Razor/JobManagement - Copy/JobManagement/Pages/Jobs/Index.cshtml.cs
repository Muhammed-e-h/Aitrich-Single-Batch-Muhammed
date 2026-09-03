using JobManagement.Dto;
using JobManagement.Model;
using JobManagement.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JobManagement.Pages.Jobs
{
    public class IndexModel : PageModel
    {
        private readonly JobService _service;
       

        public IndexModel(JobService service)
        {
            _service = service;
        }
        public List<Job> Jobs { get; set; } = new();

        public async Task OnGetAsync()
        {
            Jobs = await _service.GetAllJobsAsync();
        }
    }
}
    

