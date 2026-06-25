using System.ComponentModel.DataAnnotations.Schema;


namespace Entities.Models;

public class Apartment
{
    [Column("ApartmentId")]
    public Guid Id { get; set; }
    public string? Title { get; set; }
    public int AvailableRooms { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public Address? Address { get; set; }
    public ICollection<Image> Images { get; set; } = new List<Image>();

}
