using System.ComponentModel.DataAnnotations;
using LibrarySystem.Data.Models.Contracts;
using LibrarySystem.Common.Constants;

namespace LibrarySystem.Data.Models.Models
{
    public class Picture : IPicture
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(ValidationConstants.PictureNameMinLength)]
        [MaxLength(ValidationConstants.PictureNameMaxLength)]
        public string Name { get; set; }

        public int BookId { get; set; }

        public virtual Book Book { get; set; }
    }
}
