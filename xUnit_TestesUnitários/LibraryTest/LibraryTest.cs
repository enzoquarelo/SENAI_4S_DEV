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
            string bookName = "Vingadores: Guerra Infinita";

            Library.AddBook(bookName);

        }
    }
}
