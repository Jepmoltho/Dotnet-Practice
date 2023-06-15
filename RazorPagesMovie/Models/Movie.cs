using System.ComponentModel.DataAnnotations;
//Added
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models;

public class Movie
{
    public int Id { get; set; }
    public string? Title { get; set; }

    //Added
    [Display(Name = "Release Date")]
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }
    public string? Genre { get; set; }

    //Added
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }
}