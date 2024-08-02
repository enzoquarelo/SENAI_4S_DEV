using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Test
{
    public class LibraryTest
    {
        [Fact]
        public void AddBookTest()
        {
            var newBook = "Harry Potter";
            int initialCount = Library.books.Count;

            Library.AddBook(newBook);

            Assert.True(Library.books.Contains(newBook));
            Assert.Equal(initialCount + 1, Library.books.Count);
        }
    }
}
