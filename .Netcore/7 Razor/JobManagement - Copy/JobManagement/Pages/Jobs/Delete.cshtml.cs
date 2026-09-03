using JobManagement.Dto;
using JobManagement.Model;
using JobManagement.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JobManagement.Pages.Jobs
{
  
        public class DeleteModel : PageModel
        {
            private readonly JobService _jobService;

            public DeleteModel(JobService jobService)
            {
                _jobService = jobService;
            }

            [BindProperty]
            public Job? Job { get; set; }

            // Display the selected job
            public async Task<IActionResult> OnGetAsync(int id)
            {
                Job = await _jobService.GetJobByIdAsync(id);

                if (Job == null)
                {
                    return NotFound();
                }

                return Page();
            }

            // Delete the selected job
            public async Task<IActionResult> OnPostAsync(int id)
            {
                await _jobService.DeleteJobAsync(id);

                return RedirectToPage("Index");
            }
        }
    }
