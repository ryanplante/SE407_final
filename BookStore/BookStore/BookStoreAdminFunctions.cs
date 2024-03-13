using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class BookStoreAdminFunctions
    {
        public static void AddBook(Book book)
        {
            try
            {
                using (var db = new SE407_BookStoreContext())
                {
                    db.Books.Add(book);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void DeleteBook(int id)
        {
            try
            {
                using (var db = new SE407_BookStoreContext())
                {
                    var trash = db.Books.Find(id);
                    db.Books.Remove(trash);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void EditBook(Book book)
        {
            try
            {
                using (var db = new SE407_BookStoreContext())
                {
                    db.Books.Update(book);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void AddGenre(Genre genre)
        {
            try
            {
                using (var db = new SE407_BookStoreContext())
                {
                    db.Genres.Add(genre);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void DeleteGenre(int id)
        {
            try
            {
                using (var db = new SE407_BookStoreContext())
                {
                    var genreToDelete = db.Genres.Find(id);
                    if (genreToDelete != null)
                    {
                        db.Genres.Remove(genreToDelete);
                        db.SaveChanges();
                    }
                    else
                    {
                        Console.WriteLine("Genre not found");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void EditGenre(Genre genre)
        {
            try
            {
                using (var db = new SE407_BookStoreContext())
                {
                    db.Genres.Update(genre);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void AddAuthor(Author author)
        {
            try
            {
                using (var db = new SE407_BookStoreContext())
                {
                    db.Authors.Add(author);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void DeleteAuthor(int id)
        {
            try
            {
                using (var db = new SE407_BookStoreContext())
                {
                    var authorToDelete = db.Authors.Find(id);
                    if (authorToDelete != null)
                    {
                        db.Authors.Remove(authorToDelete);
                        db.SaveChanges();
                    }
                    else
                    {
                        Console.WriteLine("Author not found");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void EditAuthor(Author author)
        {
            try
            {
                using (var db = new SE407_BookStoreContext())
                {
                    db.Authors.Update(author);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
