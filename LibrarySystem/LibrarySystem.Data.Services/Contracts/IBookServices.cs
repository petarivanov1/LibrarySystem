using LibrarySystem.Data.Models.Models;
using System.Linq;

namespace LibrarySystem.Data.Services.Contracts
{
    public interface IBookServices
    {
        void AddBook(Book bookToAdd);
        int Count();
        void DeleteBookById(object bookId);
        IQueryable<Book> GetAllBooks();
        Book GetById(int id);

        void UpdateBook(Book book);

        IQueryable<Book> GetBookByMultipleParameters(int authorId, int publisherId, decimal price);

        IQueryable<Book> GetAllBooksByUserId(int userId);
    }
}
