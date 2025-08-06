using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WelcomeWebpage.Views.Admin
{
    public class IndexModel : PageModel
    {
        public required string Username { get; set; }

       
        public required string Password { get; set; }

        public bool LoginFailed { get; set; }

        public IActionResult OnPost()
        {
            
            if (Username == "admin" && Password == "password123")
            {
                HttpContext.Session.SetString("IsAdmin", "true");
                return RedirectToPage("/Admin/Dashboard");
            }

            LoginFailed = true;
            return Page();
        }
    }
}
    

