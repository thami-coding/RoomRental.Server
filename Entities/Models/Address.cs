using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models;

public class Address
{
    [Column("AddressId")]
    public Guid Id { get; set; }
    public string? Street { get; set; }
    public string? Province { get; set; }
    public string? City { get; set; }
    public string? Suburb { get; set; }
    public Guid ApartmentId { get; set; }
    public Apartment? Apartment { get; set; } 
}
