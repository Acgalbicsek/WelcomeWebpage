using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WelcomeWebpage.Views.Admin
{
    public class LogoutModel : PageModel
    {
        public IActionResult OnGet()
        {

            HttpContext.Session.Clear();
            return RedirectToPage("/Admin/Index");
        }
    }
}
