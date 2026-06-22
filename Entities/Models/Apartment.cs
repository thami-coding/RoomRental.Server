using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models;

public class Apartment
{
    [Column("ApartmentId")]
    public Guid Id { get; set; }
    public string? Title { get; set; }
    public int AvailableRooms { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }

    [ForeignKey(nameof(Address))]
    public Guid AddressId { get; set; }
    public Address? Address { get; set; }
    public ICollection<Image> Images { get; set; } = new List<Image>();

}
