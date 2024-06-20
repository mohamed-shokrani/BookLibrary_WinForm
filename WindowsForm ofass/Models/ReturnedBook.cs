using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using WindowsForm_ofass.Models;

public class ReturnedBook
{
    [Key]
    public int ReturnId { get; set; }

    public int BorrowId { get; set; }
    [Required]
    public int ReturnedQuantity { get; set; }


    [ForeignKey("BorrowId")]
    public BorrowedBook BorrowedBook { get; set; }

    public DateTime ReturnDate { get; set; }

    public int LibraryUserId { get; set; }

    [ForeignKey("LibraryUserId")]
    public LibraryUser LibraryUser { get; set; }

    public int BookId { get; set; }

    [ForeignKey("BookId")]
    public BookDetail BookDetail { get; set; }

    // Other properties if needed
}
