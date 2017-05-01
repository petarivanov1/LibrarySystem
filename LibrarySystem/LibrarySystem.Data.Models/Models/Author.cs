using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using LibrarySystem.Common.Constants;
using LibrarySystem.Data.Models.Contracts;

namespace LibrarySystem.Data.Models.Models
{
    public class Author : IAuthor
    {
        private ICollection<Book> books;

        public Author()
        {
            this.books = new HashSet<Book>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(ValidationConstants.AuthorFirstNameMinLength)]
        [MaxLength(ValidationConstants.AuthorFirstNameMaxLength)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(ValidationConstants.AuthorLastNameMinLength)]
        [MaxLength(ValidationConstants.AuthorLastNameMaxLength)]
        public string LastName { get; set; }

        public int PublisherId { get; set; }

        public virtual Publisher Publisher { get; set; }

        public virtual Genre Genre { get; set; }

        public virtual ICollection<Book> Books
        {
            get { return this.books; }
            set { this.books = value; }
        }
    }
}
