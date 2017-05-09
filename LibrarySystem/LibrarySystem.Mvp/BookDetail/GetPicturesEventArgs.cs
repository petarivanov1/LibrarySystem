using System;

namespace LibrarySystem.Mvp.BookDetail
{
    public class GetPicturesEventArgs : EventArgs
    {
        public int BookId { get; set; }

        public GetPicturesEventArgs(int bookId)
        {
            this.BookId = bookId;
        }
    }
}