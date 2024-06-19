using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WindowsForm_ofass.Models
{
    public class BookDetail
    {
        [Key]
        public int Id { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

       

        [ForeignKey("Author")]
        public int? AuthorId { get; set; }
         public Author Author { get; set; }
        [ForeignKey("BookLanguage")]
        public int? LanguageId { get; set; }

        [StringLength(300)]
        public string SerialNumber { get; set; }

        [Required]
        public int Quantity { get; set; }

        public int? NumberOfPages { get; set; }

        public int? PrintNumber { get; set; }
        [ForeignKey("CategoryId")]

        public int CategoryId { get; set; }
        [StringLength(50)]
        public decimal? Value {  get; set; }   
        public ICollection<BorrowedBook> BorrowedBooks { get; set; }
        public virtual BookLanguage Language { get; set; }
        public virtual BookCategory Category { get; set; }
        public int? PublishingHouseId { get; set; }
        public virtual PublishingHouse PublishingHouse { get; set; }


    }
}
