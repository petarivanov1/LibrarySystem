using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LibrarySystem.Common.Constants;
using LibrarySystem.Data.Models.Contracts;

namespace LibrarySystem.Data.Models.Models
{
    public class Publisher : IPublisher
    {
        private ICollection<Author> authors;
        private ICollection<Genre> genres;
        private ICollection<Book> books;

        public Publisher()
        {
            this.authors = new HashSet<Author>();
            this.genres = new HashSet<Genre>();
            this.books = new HashSet<Book>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [Index(IsUnique = true)]
        [MinLength(ValidationConstants.PublisherNameMinLength)]
        [MaxLength(ValidationConstants.PublisherNameMaxLength)]
        public string Name { get; set; }

        public int AuthorId { get; set; }

        public virtual ICollection<Author> Authors
        {
            get { return this.authors; }
            set { this.authors = value; }
        }

        public virtual ICollection<Genre> Genres
        {
            get { return this.genres; }
            set { this.genres = value; }
        }

        public virtual ICollection<Book> Books
        {
            get { return this.books; }
            set { this.books = value; }
        }
    }
}
