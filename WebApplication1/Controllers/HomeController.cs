using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
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

        // This method is for displaying the form to add a new movie
        [HttpGet]
        public IActionResult Movies()
        {
            // Populate ViewBag with categories for the drop-down list
            ViewBag.Categories = new SelectList(_context.Categories, "CategoryId", "CategoryName");
            return View(new Movies()); // Passing a new Movies instance to your view for form binding
        }

        [HttpPost]
        public IActionResult Movies(Movies movieToCreate)
        {
            _context.Movies.Add(movieToCreate);
            _context.SaveChanges();
            return View("Confirmation", movieToCreate); // Return the confirmation view
        }

        public IActionResult List()
        {
            var movies = _context.Movies
                .Include(m => m.Category) // Include the Category navigation property
                .OrderBy(x => x.Title)
                .ToList();
            return View(movies);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var movieToDelete = _context.Movies.FirstOrDefault(m => m.MovieId == id);
            if (movieToDelete != null)
            {
                _context.Movies.Remove(movieToDelete);
                _context.SaveChanges();
            }
            return RedirectToAction("List");
        }

        //editing movies
        public async Task<IActionResult> EditMovie(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie = await _context.Movies.FindAsync(id);
            if (movie == null)
            {
                return NotFound();
            }

            ViewBag.Categories = new SelectList(_context.Categories, "CategoryId", "CategoryName", movie.CategoryId);
            return View(movie);
        }

        [HttpPost]
        public async Task<IActionResult> EditMovie(Movies movieToUpdate)
        {
            _context.Movies.Update(movieToUpdate);
            await _context.SaveChangesAsync();
            return View("Confirmation", movieToUpdate); // Return the confirmation view
        }

    }
}
