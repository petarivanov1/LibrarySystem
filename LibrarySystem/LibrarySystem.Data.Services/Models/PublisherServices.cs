using System.Linq;
using LibrarySystem.Data.Models.Models;
using LibrarySystem.Data.Services.Contracts;
using LibrarySystem.Data.Contracts;
using Bytes2you.Validation;

namespace LibrarySystem.Data.Services.Models
{
    public class PublisherServices : IPublisherServices
    {
        private readonly IRepository<Publisher> publisherRepository;

        public PublisherServices(IRepository<Publisher> publisherRepository)
        {
            Guard.WhenArgument(publisherRepository, "Publisher repository is null.").IsNull().Throw();

            this.publisherRepository = publisherRepository;
        }

        public IQueryable<Publisher> GetAllPublishers()
        {
            return this.publisherRepository.All();
        }

        public Publisher GetById(int id)
        {
            return this.publisherRepository.GetById(id);
        }
    }
}
