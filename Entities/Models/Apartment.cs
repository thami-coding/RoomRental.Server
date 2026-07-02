using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Entities.Models;

public class Apartment
{
    [Column("ApartmentId")]
    public Guid Id { get; set; }

    [Required(ErrorMessage = "Title is a required field.")]
    public string? Title { get; set; }

    [Required(ErrorMessage = "AvailableRooms is a required field.")]
    public int AvailableRooms { get; set; }

    [Required(ErrorMessage = "Desciption is a required field.")]
    [MaxLength(150, ErrorMessage = "Maximum length for the Description is 150 characters.")]
    public string? Description { get; set; }

    [Required(ErrorMessage = "Price is a required field.")]
    public decimal Price { get; set; }

    [Required(ErrorMessage = "Address is a required field.")]
    public Address? Address { get; set; }
    public ICollection<Image> Images { get; set; } = new List<Image>();

}
