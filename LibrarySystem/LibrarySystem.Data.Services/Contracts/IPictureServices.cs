using LibrarySystem.Data.Models.Models;
using System.Linq;

namespace LibrarySystem.Data.Services.Contracts
{
    public interface IPictureServices
    {
        IQueryable<Picture> GetPictureByBookId(int bookId);

        string GetFirstPictureNameByBookId(int bookId);
    }
}
