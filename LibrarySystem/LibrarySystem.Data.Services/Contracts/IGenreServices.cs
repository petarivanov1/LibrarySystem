using LibrarySystem.Data.Models.Models;
using System.Linq;

namespace LibrarySystem.Data.Services.Contracts
{
    public interface IGenreServices
    {
        IQueryable<Genre> GetAllGenres();

        Genre GetById(int id);
    }
}
