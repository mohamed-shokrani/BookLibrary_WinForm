using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm_ofass.Models
{
    public class BorrowedBook
    {
        [Key]
        public int BorrowId { get; set; }

        [ForeignKey("BookDetail")]
        public int BookId { get; set; }
        public BookDetail BookDetail { get; set; }

       

        [Required]
        public DateTime BorrowDate { get; set; }

        public DateTime? ReturnDate { get; set; }

        public DateTime DueDate { get; set; }


        public int BorrowedQuantity { get; set; } = 0;
        public bool CannotBeReturned { get; set; }

        [StringLength(500)]
        public string RefusalReason { get; set; }

        [ForeignKey("LibraryUser")]
        public int LibraryUserId { get; set; }
        public LibraryUser LibraryUser { get; set; }
    }
}
