using System.Linq;
using LibrarySystem.Data.Models.Models;

namespace LibrarySystem.Mvp.BookDetail
{
    public class BookDetailViewModel
    {
        public IQueryable<Book> Books { get; set; }

        public IQueryable<Picture> Pictures { get; set; }
    }
}
