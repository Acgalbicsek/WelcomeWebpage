using Microsoft.AspNetCore.Mvc;

namespace WelcomeWebpage.Controllers
{
    public class LocalInformationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
