using System.Collections.Generic;
using LibrarySystem.Data.Models.Models;

namespace LibrarySystem.Data.Models.Contracts
{
    public interface IPublisher
    {
        int Id { get; set; }

        string Name { get; set; }

        int AuthorId { get; set; }

        ICollection<Author> Authors { get; set; }

        ICollection<Genre> Genres { get; set; }

        ICollection<Book> Books { get; set; }
    }
}
