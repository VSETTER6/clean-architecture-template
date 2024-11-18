using Domain;
using Infrastructure.Database;

namespace Application
{
    public class BookMethods
    {
        private readonly FakeDatabase _fakeDatabase;

        public BookMethods(FakeDatabase fakeDatabase)
        {
            _fakeDatabase = fakeDatabase;
        }

        public Book AddNewBook()
        {
            // This is how we process data in Application.
            Book newBookToAdd = new Book(1, "VilleBook", "Funny book");
            return _fakeDatabase.AddNewBook(newBookToAdd);
        }
    }
}
