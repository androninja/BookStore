using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.Title = "Testing ViewBag title";

            ViewData["message"]= "Sample message stored in ViewData variable";

            var cities = new List<string> { "Mumbai", "Delhi", "Pune", "Indore" };

            ViewData["cities"] = cities;
            ViewBag.Cities = cities;

            TempData["name"] = "Agrim Jain";
            TempData["PrivacyTitle"] = "Privacy Policy from Index Action method using TempData";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
