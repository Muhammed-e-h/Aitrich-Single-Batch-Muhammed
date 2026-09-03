using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NEWJOBPORTAL.Models;



namespace NEWJOBPORTAL.Pages
{
    public class RegisterModel : PageModel
    {
        //private readonly UserManager<User> _user;
        private readonly JobManagementportalContext _context;

        [BindProperty]
        public User NewUser { get; set; }
        public RegisterModel(JobManagementportalContext context)
        {
            _context = context;
        }

        public IActionResult OnPost()
        {
            if (string.IsNullOrEmpty(NewUser.UserName) || string.IsNullOrEmpty(NewUser.PasswordHash))
            {
                ModelState.AddModelError("", "Username and Password are required");
                return Page();
            }
            if (_context.Users.Any(u => u.UserName == NewUser.UserName))
            {
                ModelState.AddModelError("", "User Name Already Exist");
            }

            _context.Users.Add(NewUser);
            _context.SaveChanges();
            return RedirectToPage("Login");
        }
    }
}









