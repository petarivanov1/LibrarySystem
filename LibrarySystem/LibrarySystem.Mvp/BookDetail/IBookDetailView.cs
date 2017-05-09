using System;
using WebFormsMvp;

namespace LibrarySystem.Mvp.BookDetail
{
    public interface IBookDetailView : IView<BookDetailViewModel>
    {
        event EventHandler<GetPicturesEventArgs> OnGetPicturesByBookId;

        event EventHandler<GetBooksByIdEventArgs> OnGetBooksById;
    }
}
