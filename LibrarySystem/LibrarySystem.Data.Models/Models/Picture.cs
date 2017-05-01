using System.ComponentModel.DataAnnotations;
using LibrarySystem.Data.Models.Contracts;

namespace LibrarySystem.Data.Models.Models
{
    public class Picture : IPicture
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int BookId { get; set; }

        public virtual Book Book { get; set; }
    }
}
