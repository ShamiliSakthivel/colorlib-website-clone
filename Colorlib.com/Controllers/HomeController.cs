using Microsoft.AspNetCore.Mvc;

namespace Colorlib.com.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        
        public IActionResult Aboutus()
        {
            return View(); 
        }
        public IActionResult Services()
        {
            return View();
        }
        public IActionResult Pricing()
        {
            return View();
        }
        public IActionResult Work()
        {
            return View();
        }
        public IActionResult Blog()
        {
            return View();
        }
        public IActionResult Contactus()
        {
            return View();
        }
    }
}
