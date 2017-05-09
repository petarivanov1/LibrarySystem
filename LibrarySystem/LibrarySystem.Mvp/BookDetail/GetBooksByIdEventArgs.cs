using System;

namespace LibrarySystem.Mvp.BookDetail
{
    public class GetBooksByIdEventArgs : EventArgs
    {
        public int BookId { get; set; }

        public GetBooksByIdEventArgs(int bookId)
        {
            this.BookId = bookId;
        }
    }
}