using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using LibrarySystem.Common.Constants;
using LibrarySystem.Data.Models.Contracts;

namespace LibrarySystem.Data.Models.Models
{
    public class Book : IBook
    {
        private ICollection<Picture> pictures;

        public Book()
        {
            this.pictures = new HashSet<Picture>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [Index(IsUnique = true)]
        [MinLength(ValidationConstants.BookTitleMinLength)]
        [MaxLength(ValidationConstants.BookTitleMaxLength)]
        public string Title { get; set; }

        [MinLength(ValidationConstants.BookDescriptionMinLength)]
        [MaxLength(ValidationConstants.BookDescriptionMaxLength)]
        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        public string Language { get; set; }

        public int AuthorId { get; set; }

        public int PublisherId { get; set; }

        public int GenreId { get; set; }

        public string UserId { get; set; }

        public bool IsDeleted { get; set; }

        public int PagesCount { get; set; }
        
        public DateTime IssueDate { get; set; }

        public virtual Author Author { get; set; }

        public virtual Publisher Publisher { get; set; }

        public virtual Genre Genre { get; set; }

        public virtual ICollection<Picture> Pictures
        {
            get { return this.pictures; }
            set { this.pictures = value; }
        }
    }
}
