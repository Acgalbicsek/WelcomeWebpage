using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using WelcomeWebpage.Models;

namespace WelcomeWebpage.Controllers
{
    public class AdminController : Controller
    {
       
        public IActionResult Index(AdminLoginModel model)
        {
            if (model.Username == "admin" && model.Password == "password123")
            {
                HttpContext.Session.SetString("AdminLoggedIn", "true");
                return RedirectToAction("Dashboard");
            }

            ViewBag.Error = "Invalid username or password.";
            return View();
        }

        public IActionResult Dashboard()
        {
            if (HttpContext.Session.GetString("AdminLoggedIn") != "true")
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();

            return RedirectToPage("/Admin/Index");
        }
    }
}
