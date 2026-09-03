using JobManagement.Dto;
using JobManagement.Model;
using JobManagement.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JobManagement.Pages.Jobs
{
    public class EditModel : PageModel
    {
        private readonly JobService _service;

        public EditModel(JobService service)
        {
            _service = service;
        }

           [BindProperty]
            public JobDto Job { get; set; } = new();

            [BindProperty]
            public DateTime ExpirationDate { get; set; }
        public async Task<IActionResult> OnGetAsync(int id)
            {
                var job = await _service.GetJobDtoByIdAsync(id);

                if (job == null)
                {
                    return NotFound();
                }

                Job = job;

                return Page();
            }

            public async Task<IActionResult> OnPostAsync(int id)
            {
                if (!ModelState.IsValid)
                {
                    return Page();
                }

                await _service.UpdateJobAsync(id, Job);

                return RedirectToPage("Index");
            }
        }
    }
