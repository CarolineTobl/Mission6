using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Mission6.Models;

namespace Mission6.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger) ///Constructor, recieveing information of type logger. that can be seen throughout the class.
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Movies()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Movies(Application response) //I want to recieve an instance of the data
        {
            return View("Confirmation", response);
        }
    }
}
