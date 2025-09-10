using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace session1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //viewResult
            //return view("~/Views/Movies/Index.cshtml");
            return View();
            
        }
        public IActionResult Privacy()
        {
            
            return View();

        }
        public IActionResult AboutUS()
        {
            
            return View();

        }
        public IActionResult ContactUs()
        {
            
            return View();

        }
    }
}
