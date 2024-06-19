using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm_ofass.Models
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }

        [Required]
        [StringLength(200)]
        public string AuthorName { get; set; }

        [StringLength(1000)]
        public string Bio { get; set; }

        public ICollection<BookDetail> BookDetails { get; set; }
    }
}
