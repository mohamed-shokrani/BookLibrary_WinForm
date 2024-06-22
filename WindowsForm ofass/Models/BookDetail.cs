using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace WindowsForm_ofass.Models
{
    public class BookDetail
    {
        private static int _serialNumberCounter = 1; // Static counter for generating unique serial numbers

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
        public byte[] Photo { get; set; } // Add this property for the photo

        public int CategoryId { get; set; }
        [StringLength(50)]
        public decimal? Value {  get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public ICollection<BorrowedBook> BorrowedBooks { get; set; }
        public virtual BookLanguage Language { get; set; }
        public virtual BookCategory Category { get; set; }
        public int? PublishingHouseId { get; set; }
        public virtual PublishingHouse PublishingHouse { get; set; }

        public BookDetail()
        {
            SerialNumber = GenerateUniqueSerialNumber();
        }

        private string GenerateUniqueSerialNumber()
        {
            string serialNumber = $"SN{_serialNumberCounter:D3}";
            _serialNumberCounter++; 
            return serialNumber;
        }
    }
}
