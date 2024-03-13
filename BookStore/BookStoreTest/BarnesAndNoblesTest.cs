using BookStore;
using System;
using Xunit;

namespace BookStoreTest
{
    public class BarnesAndNoblesTest
    {
        [Fact]
        public void GetAllBooksTest()
        {
            var result = BookStoreBasicFunctions.GetAllBooks();
            Assert.True(result.Count == 4);
        }

        [Fact]
        public void GetTitleTest()
        {
            var result = BookStoreBasicFunctions.GetBookByTitle("Cthulu Mythos");
            Assert.True(result.BookId == 129);
        }

        [Fact]
        public void GetBooksByAuthorTest()
        {
            var result = BookStoreBasicFunctions.GetBooksByAuthor("The Coast");
            Assert.True(result.Count == 1);
        }
    }
}
