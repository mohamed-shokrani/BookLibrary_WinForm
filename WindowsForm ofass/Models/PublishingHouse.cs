using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm_ofass.Models
{
    public class PublishingHouse
    {
        [Key]
        public int PublishingHouseId { get; set; }
        [StringLength(200)]

        public string PublishingHouseName { get; set; }

        // Navigation property to BookDetails
        public virtual ICollection<BookDetail> Books { get; set; } = new List<BookDetail>();
    }
}
