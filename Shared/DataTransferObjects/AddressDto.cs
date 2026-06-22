namespace Shared.DataTransferObjects;

public class AddressDto
{
    public Guid Id { get; set; }
    public string? Street { get; set; }
    public string? Province { get; set; }
    public string? City { get; set; }
    public string? Suburb { get; set; }
}