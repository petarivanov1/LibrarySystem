using LibrarySystem.Data.Models.Models;

namespace LibrarySystem.Data.Models.Contracts
{
    public interface IAuthor
    {
        int Id { get; set; }

        string FirstName { get; set; }

        string LastName { get; set; }

        Publisher Publisher { get; set; }
    }
}
