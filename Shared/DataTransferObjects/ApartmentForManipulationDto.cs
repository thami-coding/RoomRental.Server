

using System.ComponentModel.DataAnnotations;

namespace Shared.DataTransferObjects;

public abstract class ApartmentForManipulationDto
{
    [Required(ErrorMessage = "Title name is a required field.")]
    [MaxLength(30, ErrorMessage = "Maximum length for the Title is 60 characters.")]
    public string? Title { get; set; }

    [Required(ErrorMessage = "AvailableRooms is a required field.")]
    [Range(1, int.MaxValue, ErrorMessage = "AvailableRooms is required and it can't be lower than 1")]
    public int AvailableRooms { get; set; }

    [Required(ErrorMessage = "Description name is a required field.")]
    [MaxLength(30, ErrorMessage = "Maximum length for the Description is 60 characters.")]
    public string? Description { get; set; }

    public AddressForCreationDto? Address { get; set; }
    public ICollection<ImageDto> Images { get; set; } = new List<ImageDto>();
}
