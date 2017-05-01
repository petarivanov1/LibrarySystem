using System.Linq;
using LibrarySystem.Data.Models.Models;

namespace LibrarySystem.Data.Services.Contracts
{
    public interface IAuthorServices
    {
        IQueryable<Author> GetAllAuthors();

        Author GetById(int id);
    }
}
