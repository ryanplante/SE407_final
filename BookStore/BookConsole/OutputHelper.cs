using BookStore.Models;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookConsole
{
    class OutputHelper
    {
        public void WriteToConsole(List<Book> books)
        {
            if (books != null)
            {
                Console.WriteLine("List of movies:");

                foreach (var b in books)
                {
                    Console.WriteLine($"MovieID:{b.BookId}\tTitle:{b.BookTitle}\tGenre:{b.Genre.GenreType}\tAuthor:{b.Author.AuthorFirst} {b.Author.AuthorLast}");
                }
            }
            else
            {
                Console.WriteLine("No books found!");
                return;
            }

        }

        public void WriteToCSV(List<Book> books)
        {
            using (var writer = new StreamWriter(@"..\file.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(books);
            }
        }
    }
}
