
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SimpleAuth.Pages
{
    public class LogoutModel : PageModel
    {
        public string Username { get; set; }

        public IActionResult OnGet()
        {
            Username = HttpContext.Session.GetString("User");

            if (Username == null)
            {
                // Login ചെയ്തിട്ടില്ലെങ്കിൽ redirect
                return RedirectToPage("Login");
            }

            return Page();
        }
    }
}