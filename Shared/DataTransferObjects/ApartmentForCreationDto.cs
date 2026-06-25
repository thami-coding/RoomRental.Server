namespace Shared.DataTransferObjects;

public class ApartmentForCreationDto
{
    public string? Title { get; set; }
    public int AvailableRooms { get; set; }
    public string? Description { get; set; }
    public AddressDto? Address { get; set; }
}
