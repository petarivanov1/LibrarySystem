using LibrarySystem.Data.Models.Models;
using System.Collections.Generic;

namespace LibrarySystem.Data.Models.Contracts
{
    public interface IPublisher
    {
        int Id { get; set; }

        string Name { get; set; }

        ICollection<Author> Author { get; set; }
    }
}
