using Microsoft.AspNetCore.Mvc;

namespace Prefinal_Quiz.Controllers
{
    public class AccountController : Controller
    {
        private const string Username = "admin";
        private const string Password = "1234";

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            if (username == Username && password == Password)
            {
                HttpContext.Session.SetString("LoggedIn", "true");

                return RedirectToAction(
                    "Index",
                    "Portfolio");
            }

            ViewBag.Error = "Invalid username or password.";
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
