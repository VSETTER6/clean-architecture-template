using Application;
using Domain;
using Infrastructure.Database;

namespace TestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void When_Method_AddNewBook_isCalled_Then_BookAddedToList()
        {
            // Arrange
            Book bookToTest = new Book(1, "VilleBook", "Funny book");
            FakeDatabase fakeDatabase = new FakeDatabase();
            BookMethods bookMethods = new BookMethods(fakeDatabase);

            // Act
            Book bookCreated = bookMethods.AddNewBook();

            // Assert
            Assert.That(bookCreated, Is.Not.Null);
            Assert.That(bookCreated.Description, Is.EqualTo(bookToTest.Description));
        }
    }
}