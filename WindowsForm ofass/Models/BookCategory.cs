using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WindowsForm_ofass.Models
{
    public class BookCategory
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        [StringLength(200)]
        public string CategoryName { get; set; }

        public ICollection<BookDetail> BookDetails { get; set; }
    }
}
