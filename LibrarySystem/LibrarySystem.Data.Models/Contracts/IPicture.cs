using LibrarySystem.Data.Models.Models;

namespace LibrarySystem.Data.Models.Contracts
{
    public interface IPicture
    {
        int Id { get; set; }

        string Name { get; set; }

        int BookId { get; set; }

        Book Book { get; set; }
    }
}
