using System;
using Bytes2you.Validation;
using LibrarySystem.Data.Services.Contracts;
using WebFormsMvp;
using System.Collections.Generic;
using LibrarySystem.Data.Models.Models;
using System.Linq;

namespace LibrarySystem.Mvp.BookDetail
{
    public class BookDetailPresenter : Presenter<IBookDetailView>
    {
        private readonly IBookServices bookService;
        private readonly IPictureServices pictureService;

        public BookDetailPresenter(IBookDetailView view, IBookServices bookService, IPictureServices pictureService) 
            : base(view)
        {
            Guard.WhenArgument(view, "View is null.").IsNull().Throw();
            Guard.WhenArgument(bookService, "Book service is null.").IsNull().Throw();
            Guard.WhenArgument(pictureService, "Picture service is null.").IsNull().Throw();

            this.bookService = bookService;
            this.pictureService = pictureService;

            this.View.OnGetBooksById += View_OnGetBooksById;
            this.View.OnGetPicturesByBookId += View_OnGetPicturesByBookId;
        }

        public void View_OnGetBooksById(object sender, GetBooksByIdEventArgs e)
        {
            Guard.WhenArgument(e.BookId, "Book ID must be positive number.").IsLessThan(1).Throw();

            var book = this.bookService.GetById(e.BookId);
            var bookCollection = new List<Book>();
            bookCollection.Add(book);

            this.View.Model.Books = bookCollection.AsQueryable();
        }

        private void View_OnGetPicturesByBookId(object sender, GetPicturesEventArgs e)
        {
            Guard.WhenArgument(e.BookId, "Book ID must be positive number.").IsLessThan(1).Throw();

            var pictures = this.pictureService.GetPictureByBookId(e.BookId);

            this.View.Model.Pictures = pictures;
        }
    }
}
