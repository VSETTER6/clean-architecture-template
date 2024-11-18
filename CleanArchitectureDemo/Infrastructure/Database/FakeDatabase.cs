using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Database
{
    public class FakeDatabase
    {
        public List<Book> Books { get { return allBooksFromDb; } set { allBooksFromDb = value; } }

        private static List<Book> allBooksFromDb = new List<Book>
        {
            new Book (1, "Book 1", "Description 1"),
            new Book (2, "Book 2", "Description 2"),
            new Book (3, "Book 3", "Description 3"),
            new Book (4, "Book 4", "Description 4"),
            new Book (5, "Book 5", "Description 5")
        };

        // My CRUD methods.
        public Book AddNewBook(Book book)
        {
            allBooksFromDb.Add(book);
            return book;
        }
    }
}
