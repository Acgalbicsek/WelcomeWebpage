using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WelcomeWebpage.Views.Admin
{
    public class DashboardModel : PageModel
    {
        public IActionResult OnGet()
        {
            if (HttpContext.Session.GetString("IsAdmin") != "true")
            {
                return RedirectToPage("/Admin/Index"); 
            }

            return Page();
        }
    }
}
