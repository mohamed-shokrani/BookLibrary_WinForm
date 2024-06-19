using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm_ofass.Models
{
    public class BookLanguage
    {
        [Key]
        public int LanguageId { get; set; }
        public string LanguageName { get; set; }

        // Navigation property to BookDetails
        public virtual ICollection<BookDetail> Books { get; set; }
    }
}
