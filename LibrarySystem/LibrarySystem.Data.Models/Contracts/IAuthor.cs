using System.Collections.Generic;
using LibrarySystem.Data.Models.Models;

namespace LibrarySystem.Data.Models.Contracts
{
    public interface IAuthor
    {
        int Id { get; set; }

        string FirstName { get; set; }

        string LastName { get; set; }

        int PublisherId { get; set; }

        Publisher Publisher { get; set; }

        Genre Genre { get; set; }

        ICollection<Book> Books { get; set; }
    }
}
