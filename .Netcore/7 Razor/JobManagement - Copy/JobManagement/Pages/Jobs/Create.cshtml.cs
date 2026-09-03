using JobManagement.Dto;
using JobManagement.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JobManagement.Pages.Jobs
{
    public class CreateModel : PageModel
    {
        private readonly JobService _service;
  
        public CreateModel(JobService service)
        {
            _service = service;
        }
        [BindProperty]
        public JobDto Job { get; set; } = new();

        public void OnGet()
        {

        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _service.CreateJobAsync(Job);

            return RedirectToPage("Index");
        }
    }
}

