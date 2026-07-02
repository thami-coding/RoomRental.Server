
using System.ComponentModel.DataAnnotations;

namespace Shared.DataTransferObjects;

public class AddressForManipulationDto
{
    [Required(ErrorMessage = "Street name is a required field.")]
    [MaxLength(30, ErrorMessage = "Maximum length for the Street is 60 characters.")]
    public string? Street { get; set; }

    [Required(ErrorMessage = "Province name is a required field.")]
    [MaxLength(30, ErrorMessage = "Maximum length for the Province is 60 characters.")]
    public string? Province { get; set; }

    [Required(ErrorMessage = "City name is a required field.")]
    [MaxLength(30, ErrorMessage = "Maximum length for the City is 60 characters.")]
    public string? City { get; set; }

    [Required(ErrorMessage = "Suburb name is a required field.")]
    [MaxLength(30, ErrorMessage = "Maximum length for the Suburb is 60 characters.")]
    public string? Suburb { get; set; }
}
