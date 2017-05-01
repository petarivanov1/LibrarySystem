using System;
using System.Linq;
using LibrarySystem.Data.Models.Models;
using LibrarySystem.Data.Services.Contracts;
using LibrarySystem.Data.Contracts;
using Bytes2you.Validation;

namespace LibrarySystem.Data.Services.Models
{
    public class PictureServices : IPictureServices
    {
        private readonly IRepository<Picture> pictureRepository;

        public PictureServices(IRepository<Picture> pictureRepository)
        {
            Guard.WhenArgument(pictureRepository, "Picture repository is null.").IsNull().Throw();

            this.pictureRepository = pictureRepository;
        }

        public IQueryable<Picture> GetPictureByBookId(int bookId)
        {
            var pictures = this.pictureRepository.All().Where(p => p.BookId == bookId);

            return pictures;
        }

        public string GetFirstPictureNameByBookId(int bookId)
        {
            var picturePath = this.pictureRepository.All()
                .FirstOrDefault(p => p.BookId == bookId)?.Name;

            return picturePath;
        }
    }
}
