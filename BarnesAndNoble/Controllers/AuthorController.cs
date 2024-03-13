using BarnesAndNoble.Helpers;
using BookStore.Models;
using BookStore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BarnesAndNoble.Controllers
{
    public class AuthorController : Controller
    {
        // GET: AuthorController
        public ActionResult Index()
        {
            return View();
        }

        // GET: AuthorController/Details/5
        public ActionResult Details(int id)
        {
            var author = BookStoreBasicFunctions.GetAuthorById(id);
            return View(author);
        }

        // GET: AuthorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AuthorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Author newAuthor)
        {
            BookStoreAdminFunctions.AddAuthor(newAuthor);
            return RedirectToAction("Authors", "Home");
        }

        // GET: AuthorController/Edit/5
        public ActionResult Edit(int id)
        {
            var Author = BookStoreBasicFunctions.GetAuthorById(id);
            ViewBag.GenreId = DropDownFormatter.FormatGenres();
            ViewBag.AuthorId = DropDownFormatter.FormatAuthors();
            return View(Author);
        }

        // POST: AuthorController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Author Author)
        {
            try
            {
                BookStoreAdminFunctions.EditAuthor(Author);
                return RedirectToAction("Authors", "Home");
            }
            catch
            {
                return View();
            }
        }

        // GET: AuthorController/Delete/5
        public ActionResult Delete(int id)
        {
            var Author = BookStoreBasicFunctions.GetAuthorById(id);
            return View(Author);
        }

        // POST: AuthorController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Author Author)
        {
            try
            {
                BookStoreAdminFunctions.DeleteAuthor(Author.AuthorId);
                return RedirectToAction("Authors", "Home");
            }
            catch
            {
                return View();
            }
        }
    }
}
