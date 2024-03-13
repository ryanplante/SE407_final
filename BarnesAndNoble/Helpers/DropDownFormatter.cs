using BookStore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BarnesAndNoble.Helpers
{
    public class DropDownFormatter
    {
        public static SelectList FormatAuthors()
        {
            return new SelectList(BookStoreBasicFunctions.GetAuthors()
       .OrderBy(a => a.AuthorLast)
       .ToDictionary(a => a.AuthorId, a => a.AuthorLast + ", " + a.AuthorFirst), "Key", "Value");
        }

        public static SelectList FormatGenres()
        {
            return new SelectList(BookStoreBasicFunctions.GetGenres()
     .OrderBy(g => g.GenreType)
     .ToDictionary(g => g.GenreId, g => g.GenreType), "Key", "Value");
        }
    }
}
