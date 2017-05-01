using System;
using System.Linq;
using LibrarySystem.Data.Models.Models;
using LibrarySystem.Data.Services.Contracts;
using LibrarySystem.Data.Contracts;
using Bytes2you.Validation;

namespace LibrarySystem.Data.Services.Models
{
    public class BookServices : IBookServices
    {
        private readonly IRepository<Book> bookRepository;
        private readonly IUnitOfWork unitOfWork;

        public BookServices(IRepository<Book> bookRepository, IUnitOfWork unitOfWork)
        {
            Guard.WhenArgument(bookRepository, "Book repository is null.").IsNull().Throw();
            Guard.WhenArgument(unitOfWork, "Unit of work is null.").IsNull().Throw();

            this.bookRepository = bookRepository;
            this.unitOfWork = unitOfWork;
        }

        public void AddBook(Book bookToAdd)
        {
            Guard.WhenArgument(bookToAdd, "Book to add is null.").IsNull().Throw();

            using (var unitOfWork = this.unitOfWork)
            {
                this.bookRepository.Add(bookToAdd);

                unitOfWork.SaveChanges();
            }
        }

        public void DeleteBook(Book bookToDelete)
        {
            Guard.WhenArgument(bookToDelete, "Book to delete is null.").IsNull().Throw();

            using (var unitOfWork = this.unitOfWork)
            {
                this.bookRepository.Delete(bookToDelete);

                unitOfWork.SaveChanges();
            }
        }

        public void DeleteBookById(object bookId)
        {
            Guard.WhenArgument(bookId, "Book ID cannot be null.").IsNull().Throw();

            using (var unitOfWork = this.unitOfWork)
            {
                this.bookRepository.Delete((int)bookId);

                unitOfWork.SaveChanges();
            }
        }

        public int Count()
        {
            return this.bookRepository.All().Count();
        }

        public IQueryable<Book> GetAllBooks()
        {
            return this.bookRepository.All();
        }

        public Book GetById(int id)
        {
            return this.bookRepository.GetById(id);
        }

        public IQueryable<Book> GetAllBooksByUserId(string userId)
        {
            var books = this.bookRepository
                .All()
                .Where(b => b.UserId == userId);

            return books;
        }

        public IQueryable<Book> GetBookByMultipleParameters(int authorId, int publisherId, decimal price)
        {
            var books = this.bookRepository.All()
                .Where(b => b.AuthorId == authorId &&
                            b.PublisherId == publisherId &&
                            b.Price == price);

            return books;
        }

        public void UpdateBook(Book book)
        {
            using (var unitOfWork = this.unitOfWork)
            {
                this.bookRepository.Update(book);

                unitOfWork.SaveChanges();
            }
        }
    }
}
