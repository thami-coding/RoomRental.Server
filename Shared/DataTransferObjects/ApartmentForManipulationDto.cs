

using System.ComponentModel.DataAnnotations;

namespace Shared.DataTransferObjects;

public abstract class ApartmentForManipulationDto
{
    [Required(ErrorMessage = "Title name is a required field.")]
    [MaxLength(150, ErrorMessage = "Maximum length for the Title is `50 characters.")]
    public string? Title { get; set; }

    [Required(ErrorMessage = "AvailableRooms is a required field.")]
    [Range(0, int.MaxValue, ErrorMessage = "AvailableRooms is required and it can't be lower than 0")]
    public int AvailableRooms { get; set; }

    [Required(ErrorMessage = "Description name is a required field.")]
    [MaxLength(350, ErrorMessage = "Maximum length for the Description is 350 characters.")]
    public string? Description { get; set; }

    [Required(ErrorMessage ="Address is required")]
    public AddressForCreationDto? Address { get; set; }
    public ICollection<ImageDto> Images { get; set; } = new List<ImageDto>();
}
