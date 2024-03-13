using BookStore.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BookStore
{
    public class BookStoreBasicFunctions
    {

        public static List<Book> GetAllBooks()
        {
            using (var db = new SE407_BookStoreContext())
            {
                return db.Books.Include(b => b.Author).Include(b => b.Genre).ToList();
            }
        }

        public static Book GetBookByTitle(string title)
        {
            using (var db = new SE407_BookStoreContext())
            {
                IQueryable<Book> query = db.Books;
                // Include the Author information in the query

                var book = query.Include(b => b.Genre).Include(b => b.Author).FirstOrDefault(b => b.BookTitle.ToLower() == title.ToLower());

                return book;
            }
        }

        //Create a function that returns a list of books written by a specific author by last name (10 points).

        public static List<Book> GetBooksByAuthor(string lastName)
        {
            using (var db = new SE407_BookStoreContext())
            {
                //IQueryable<Book> query = db.Books;
                // Include the Author and genre information in the query

                var books = db.Books
                               .Where(b => b.Author.AuthorLast.ToLower() == lastName.ToLower())
                               .Include(b => b.Author) // Include director information
                               .Include(b => b.Genre) // Include genre information because why not
                               .ToList();
                return books;
            }
        }

        public static Book GetBookById(int id)
        {
            using (var db = new SE407_BookStoreContext())
            {
                return db.Books
                    .Include(b => b.Genre)
                    .Include(b => b.Author)
                .FirstOrDefault(b => b.BookId == id);
            }
        }

        public static Author GetAuthorById(int id)
        {
            using (var db = new SE407_BookStoreContext())
            {
                return db.Authors.FirstOrDefault(a => a.AuthorId == id);
            }
        }

        public static Genre GetGenreById(int id)
        {
            using (var db = new SE407_BookStoreContext())
            {
                return db.Genres.FirstOrDefault(g => g.GenreId == id);
            }
        }

        public static List<Genre> GetGenres()
        {
            using (var db = new SE407_BookStoreContext())
            {
                return db.Genres.ToList();
            }
        }

        public static List<Author> GetAuthors()
        {
            using (var db = new SE407_BookStoreContext())
            {
                return db.Authors.ToList();
            }
        }

    }
}
