namespace Shared.DataTransferObjects;

public class ApartmentDto
{
    public Guid Id { get; set; }
    public string? Title { get; set; }
    public int AvailableRooms { get; set; }
    public string? Description { get; set; }
    public AddressDto? Address { get; set; }
}