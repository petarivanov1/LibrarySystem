using System.Collections.Generic;
using LibrarySystem.Data.Models.Models;

namespace LibrarySystem.Data.Models.Contracts
{
    public interface IGenre
    {
        int Id { get; set; }

        string Name { get; set; }

        ICollection<Publisher> Publishers { get; set; }

        ICollection<Author> Authors { get; set; }

        ICollection<Book> Books { get; set; }
    }
}
