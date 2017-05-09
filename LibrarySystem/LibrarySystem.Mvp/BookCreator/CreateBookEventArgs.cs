using LibrarySystem.Data.Models.Models;
using System;
using System.Collections.Generic;

namespace LibrarySystem.Mvp.BookCreator
{
    public class CreateBookEventArgs : EventArgs
    {
        public string Title { get; private set; }
        public string UserId { get; private set; }
        public int AuthorId { get; private set; }
        public int PublisherId { get; private set; }
        public int GenreId { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public string Language { get; private set; }
        public DateTime IssueDate { get; private set; }
        public int PagesCount { get; private set; }
        public ICollection<string> PictureFilePaths { get; private set; }

        public CreateBookEventArgs(
            string title,
            string userId, 
            int authorId, 
            int publisherId,
            int genreId,
            string description,
            decimal price,
            string language,
            DateTime issueDate,
            int pagesCount,
            ICollection<string> pictureFilePaths)
        {
            this.Title = title;
            this.UserId = userId;
            this.AuthorId = authorId;
            this.PublisherId = publisherId;
            this.GenreId = genreId;
            this.Description = description;
            this.Price = price;
            this.Language = language;
            this.IssueDate = issueDate;
            this.PagesCount = pagesCount;
            this.PictureFilePaths = pictureFilePaths;
        }
    }
}