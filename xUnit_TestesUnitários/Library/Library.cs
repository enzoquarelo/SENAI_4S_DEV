using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public static class Library
    {
        public static List<string> books = new List<string>();
        public static void AddBook(string bookName)
        {
            if (bookName is not null)
            {
                books.Add(bookName);
            }
        }

    }
}
