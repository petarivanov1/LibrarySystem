using System;
using WebFormsMvp;

namespace LibrarySystem.Mvp.BookCreator
{
    public interface IBookCreatorView : IView<BookCreatorViewModel>
    {
        event EventHandler OnAuthorsGetData;

        event EventHandler OnPublishersGetData;

        event EventHandler OnGenresGetData;

        event EventHandler<CreateBookEventArgs> OnCreateBook;
    }
}
