using System.Linq;
using LibrarySystem.Data.Models.Models;
using LibrarySystem.Data.Services.Contracts;
using LibrarySystem.Data.Contracts;
using Bytes2you.Validation;

namespace LibrarySystem.Data.Services.Models
{
    public class AuthorServices : IAuthorServices
    {
        private readonly IRepository<Author> authorRepository;

        public AuthorServices(IRepository<Author> authorRepository)
        {
            Guard.WhenArgument(authorRepository, "Author repository is null.").IsNull().Throw();

            this.authorRepository = authorRepository;
        }

        public IQueryable<Author> GetAllAuthors()
        {
            return this.authorRepository.All();
        }

        public Author GetById(int id)
        {
            return this.authorRepository.GetById(id);
        }
    }
}
