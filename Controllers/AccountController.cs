using Microsoft.AspNetCore.Mvc;

namespace session1.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Register ()
        {
            return View();
        }
        public IActionResult LogIn()
        {
            return View();
        }

    }
}
