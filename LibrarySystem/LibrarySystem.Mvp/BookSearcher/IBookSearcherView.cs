using System;
using WebFormsMvp;

namespace LibrarySystem.Mvp.BookSearcher
{
    public interface IBookSearcherView : IView<BookSearcherViewModel>
    {
        event EventHandler OnAuthorsGetData;

        event EventHandler OnGenresGetData;

        event EventHandler OnPublishersGetData;
    }
}
