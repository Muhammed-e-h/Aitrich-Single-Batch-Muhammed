using NEWJOBPORTAL.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NEWJOBPORTAL.Pages;


namespace NEWJOBPORTAL.Pages
{
    public class LoginModel : PageModel
    {
        private readonly JobManagementportalContext _context;

             
        [BindProperty]

            public string Username { get; set; }
            public string PasswordHash { get; set; } 

            public string Email { get; set; } 

            public bool RememberMe { get; set; }


        public LoginModel(JobManagementportalContext context)
        {
            _context = context;
        }
           public IActionResult OnPost()
        {
            var user = _context.Users.SingleOrDefault(u=> u.UserName == Username && u.PasswordHash== PasswordHash);
            if(user== null)
            {
                ModelState.AddModelError("", "Invalid User name Or Passwrod");
                return Page();
            }

            HttpContext.Session.SetString("User", Username);
            return RedirectToPage("Index");

        }
            
          
        
    }
}
