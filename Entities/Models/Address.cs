using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models;

public class Address
{
    [Column("AddressId")]
    public Guid Id { get; set; }

    [Required(ErrorMessage = "Street is a required field.")]
    [MaxLength(60, ErrorMessage = "Maximum length for the Street is 60 characters.")]
    public string? Street { get; set; }

    [Required(ErrorMessage = "Province is a required field.")]
    [MaxLength(60, ErrorMessage = "Maximum length for the Province is 60 characters.")]
    public string? Province { get; set; }

    [Required(ErrorMessage = "City is a required field.")]
    [MaxLength(60, ErrorMessage = "Maximum length for the City is 60 characters.")]
    public string? City { get; set; }

    [Required(ErrorMessage = "Suburb is a required field.")]
    [MaxLength(60, ErrorMessage = "Maximum length for the Suburb is 60 characters.")]
    public string? Suburb { get; set; }

    [ForeignKey(nameof(Apartment))]
    public Guid ApartmentId { get; set; }
    public Apartment? Apartment { get; set; } 
}
