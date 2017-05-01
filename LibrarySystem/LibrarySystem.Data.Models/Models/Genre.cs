using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LibrarySystem.Data.Models.Contracts;
using LibrarySystem.Common.Constants;

namespace LibrarySystem.Data.Models.Models
{
    public class Genre : IGenre
    {
        private ICollection<Author> authors;
        private ICollection<Publisher> publishers;
        private ICollection<Book> books;

        public Genre()
        {
            this.authors = new HashSet<Author>();
            this.publishers = new HashSet<Publisher>();
            this.books = new HashSet<Book>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [Index(IsUnique = true)]
        [MinLength(ValidationConstants.GenreNameMinLength)]
        [MaxLength(ValidationConstants.GenreNameMaxLength)]
        public string Name { get; set; }

        public virtual ICollection<Author> Authors
        {
            get { return this.authors; }
            set { this.authors = value; }
        }

        public virtual ICollection<Publisher> Publishers
        {
            get { return this.publishers; }
            set { this.publishers = value; }
        }

        public virtual ICollection<Book> Books
        {
            get { return this.books; }
            set { this.books = value; }
        }
    }
}
