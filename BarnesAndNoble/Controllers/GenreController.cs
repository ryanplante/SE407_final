using BarnesAndNoble.Helpers;
using BookStore.Models;
using BookStore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BarnesAndNoble.Controllers
{
    public class GenreController : Controller
    {
        // GET: GenreController
        public ActionResult Index()
        {
            return View();
        }

        // GET: GenreController/Details/5
        public ActionResult Details(int id)
        {
            var genre = BookStoreBasicFunctions.GetGenreById(id);
            return View(genre);
        }

        // GET: GenreController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GenreController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Genre genre)
        {
            BookStoreAdminFunctions.AddGenre(genre);
            return RedirectToAction("Genres", "Home");
        }

        // GET: GenreController/Edit/5
        public ActionResult Edit(int id)
        {
            var genre = BookStoreBasicFunctions.GetGenreById(id);
            return View(genre);
        }

        // POST: GenreController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Genre genre)
        {
            try
            {
                BookStoreAdminFunctions.EditGenre(genre);
                return RedirectToAction("Genres", "Home");
            }
            catch
            {
                return View();
            }
        }

        // GET: GenreController/Delete/5
        public ActionResult Delete(int id)
        {
            var genre = BookStoreBasicFunctions.GetGenreById(id);
            return View(genre);
        }

        // POST: GenreController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Genre genre)
        {
            try
            {
                BookStoreAdminFunctions.DeleteGenre(genre.GenreId);
                return RedirectToAction("Genres", "Home");
            }
            catch
            {
                return View();
            }
        }
    }
}
