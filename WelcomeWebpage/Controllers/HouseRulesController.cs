using Microsoft.AspNetCore.Mvc;

namespace WelcomeWebpage.Controllers
{
    public class HouseRulesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
