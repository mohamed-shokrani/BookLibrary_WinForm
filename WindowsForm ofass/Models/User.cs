using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WindowsForm_ofass.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [StringLength(200)]
        public string UserName { get; set; }

        [Required]
        [StringLength(200)]
        public string Password { get; set; }

    }
}
