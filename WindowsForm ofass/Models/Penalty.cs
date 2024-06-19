using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WindowsForm_ofass.Models;

public class Penalty
{
    [Key]
    public int PenaltyId { get; set; }

    [Required]
    [ForeignKey("LibraryUser")]
    public int LibraryUserId { get; set; }

    [Required]
    public DateTime DateOfCreation { get; set; }

    public LibraryUser LibraryUser { get; set; }
}
