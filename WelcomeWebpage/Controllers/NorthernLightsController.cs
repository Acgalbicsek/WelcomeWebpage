using Microsoft.AspNetCore.Mvc;

namespace WelcomeWebpage.Controllers
{
    public class NorthernLightsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
