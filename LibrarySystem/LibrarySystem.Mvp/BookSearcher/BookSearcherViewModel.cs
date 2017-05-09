using LibrarySystem.Data.Models.Models;
using System.Linq;

namespace LibrarySystem.Mvp.BookSearcher
{
    public class BookSearcherViewModel
    {
        public IQueryable<Author> Authors { get; set; }

        public IQueryable<Genre> Genres { get; set; }

        public IQueryable<Publisher> Publishers { get; set; }

    }
}