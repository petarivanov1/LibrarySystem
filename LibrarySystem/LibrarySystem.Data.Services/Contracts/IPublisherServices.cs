using LibrarySystem.Data.Models.Models;
using System.Linq;

namespace LibrarySystem.Data.Services.Contracts
{
    public interface IPublisherServices
    {
        IQueryable<Publisher> GetAllPublishers();

        Publisher GetById(int id);
    }
}
