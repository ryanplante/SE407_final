using BarnesAndNoble.Models;
using BookStore;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BarnesAndNoble.Controllers
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

        public IActionResult Books()
        {
            var books = BookStoreBasicFunctions.GetAllBooks();
            return View(books);
        }

        public IActionResult Authors()
        {
            var authors = BookStoreBasicFunctions.GetAuthors();
            return View(authors);
        }

        public IActionResult Genres()
        {
            var genres = BookStoreBasicFunctions.GetGenres();
            return View(genres);
        }
    }
}
