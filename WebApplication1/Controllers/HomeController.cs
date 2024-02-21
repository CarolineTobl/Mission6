using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Mission6.Models;

namespace Mission6.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext _context;
        public HomeController(MovieContext movieName) 
        {
            _context = movieName;
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
        public IActionResult Movies(Application response) //I want to recieve an instance of the data. Response is an instance of the application class
        {
            _context.Applications.Add(response); //Adding the record to the database
            _context.SaveChanges();

            return View("Confirmation", response);
        }

        public IActionResult List()
        {
            //ling
            var applications = _context.Applications
                .OrderBy(x => x.Title).ToList();//Applications is the name of the table (when I change dataBases, I will need to change the table name 
            return View(applications);
        }
    }
}
