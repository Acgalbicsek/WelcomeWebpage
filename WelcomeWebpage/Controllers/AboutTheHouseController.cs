using Microsoft.AspNetCore.Mvc;

namespace WelcomeWebpage.Controllers
{
    public class AboutTheHouseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
