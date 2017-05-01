using System.Linq;
using LibrarySystem.Data.Models.Models;
using LibrarySystem.Data.Services.Contracts;
using LibrarySystem.Data.Contracts;
using Bytes2you.Validation;

namespace LibrarySystem.Data.Services.Models
{
    public class GenreServices : IGenreServices
    {
        private readonly IRepository<Genre> genreRepository;

        public GenreServices(IRepository<Genre> genreRepository)
        {
            Guard.WhenArgument(genreRepository, "Genre repository is null.").IsNull().Throw();

            this.genreRepository = genreRepository;
        }

        public IQueryable<Genre> GetAllGenres()
        {
            return this.genreRepository.All();
        }

        public Genre GetById(int id)
        {
            return this.genreRepository.GetById(id);
        }
    }
}
