namespace Entities.Models;

public class Address
{
    public Guid AddressId { get; set; }
    public string? Street { get; set; }
    public string? Province { get; set; }
    public string? City { get; set; }
    public string? Suburb { get; set; }
    public Apartment? Apartment { get; set; }
}
