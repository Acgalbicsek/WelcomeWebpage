using Microsoft.AspNetCore.Mvc;

namespace WelcomeWebpage.Controllers
{
    public class AboutYourStay : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
