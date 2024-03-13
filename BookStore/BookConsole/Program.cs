using BookStore;
using System;
using System.Collections.Generic;

namespace BookConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            if (ParseCommand(args))
            {
                Console.WriteLine("Process completed with result code 0");
            }
            else
            {
                Console.WriteLine("Error occured! Please try again");
            }
            Console.ReadLine();
        }

        public static bool ParseCommand(string[] args)
        {
            if (args.Length > 1)
            {
                var oh = new OutputHelper();
                var output = args[0].ToLower();
                var command = args[1].ToLower();
                bool isCsv = string.Equals(output, "csv");
                bool isConsole = string.Equals(output, "console");
                List<BookStore.Models.Book> books = new List<BookStore.Models.Book>();
                if (isCsv || isConsole)
                {
                    if (args.Length == 3)
                    {
                        // Command with one parameter
                        string parameter = args[2];

                        switch (command.ToLower())
                        {
                            case "getbookbytitle":
                                books.Add(BookStoreBasicFunctions.GetBookByTitle(parameter));
                                break;
                            case "getbooksbyauthor":
                                books = BookStoreBasicFunctions.GetBooksByAuthor(parameter);
                                break;
                            default:
                                Console.WriteLine("Unknown command or incorrect number of arguments.");
                                return false;
                        }
                    }
                    else if (args.Length == 2)
                    {
                        // Command without parameters
                        switch (command.ToLower())
                        {
                            case "getallbooks":
                                books = BookStore.BookStoreBasicFunctions.GetAllBooks();
                                break;
                            default:
                                Console.WriteLine("Unknown command or incorrect number of arguments.");
                                return false;
                        }
                    }
                    else
                    {
                        // Incorrect number of arguments
                        if (args.Length < 2)
                        {
                            Console.WriteLine("Expected at least one argument.");
                        }
                        else
                        {
                            Console.WriteLine("Too many arguments.");
                        }
                    }
                }
                if (isCsv)
                {
                    oh.WriteToCSV(books);
                    return true;
                }
                else
                {
                    oh.WriteToConsole(books);
                    return true;
                }
            }
            else
            {
                Console.WriteLine("Expected at least one argument.");
                return false;
            }

        }
    }
}
