namespace Shared.DataTransferObjects;

public class ApartmentForUpdateDto
{
    public string? Title { get; set; }
    public int AvailableRooms { get; set; }
    public string? Description { get; set; }
    public AddressForCreationDto? Address { get; set; }
    public ICollection<ImageDto> Images { get; set; } = new List<ImageDto>();
}
