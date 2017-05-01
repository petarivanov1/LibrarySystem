using LibrarySystem.Data.Models.Models;
using System.Linq;

namespace LibrarySystem.Data.Services.Contracts
{
    public interface IPictureServices
    {
        IQueryable<Picture> GetAllPictures();

        Picture GetById(int id);
    }
}
