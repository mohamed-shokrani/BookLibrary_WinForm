using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WindowsForm_ofass.Models
{
    public class LibraryUser
    {
        [Key]
        public int LibraryUserId { get; set; }

        [Required]
        [StringLength(200)]
        public string LibraryUserName { get; set; }
        public int PhoneNumber { get; set; }
        [Required]
        public bool IsNotAllowedToBorrow { get; set; } = false; // Default value to match the database default

        [StringLength(500)]
        public string ReasonNotAllowed { get; set; }
        [Required]
        public string Password {  get; set; }
        public bool IsAdmin { get; set; } = false;
        public ICollection<BorrowedBook> BorrowedBooks { get; set; }
        public ICollection<Penalty> Penalties { get; set; }
    }
}
