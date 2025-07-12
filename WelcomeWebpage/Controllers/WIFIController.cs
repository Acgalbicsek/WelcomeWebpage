using Microsoft.AspNetCore.Mvc;

namespace WelcomeWebpage.Controllers
{
    public class WIFIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
