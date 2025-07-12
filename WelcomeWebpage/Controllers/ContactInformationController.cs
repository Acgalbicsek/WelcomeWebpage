using Microsoft.AspNetCore.Mvc;

namespace WelcomeWebpage.Controllers
{
    public class ContactInformationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
