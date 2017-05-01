using System;
using System.Collections.Generic;
using LibrarySystem.Data.Models.Models;

namespace LibrarySystem.Data.Models.Contracts
{
    public interface IBook
    {
        int Id { get; set; }

        string Title { get; set; }

        string Description { get; set; }

        decimal Price { get; set; }

        string Language { get; set; }

        int AuthorId { get; set; }

        int PublisherId { get; set; }

        int GenreId { get; set; }

        string UserId { get; set; }

        bool IsDeleted { get; set; }

        int PagesCount { get; set; }

        DateTime IssueDate { get; set; }

        Author Author { get; set; }

        Publisher Publisher { get; set; }

        Genre Genre { get; set; }

        ICollection<Picture> Pictures { get; set; }
    }
}
