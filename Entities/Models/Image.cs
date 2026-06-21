using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models;

public class Image
{
    public Guid ImageId { get; set; }
    public string? Url { get; set; }

    [ForeignKey(nameof(Apartment))]
    public Guid ApartmentId { get; set; }
    public Apartment? Apartment { get; set; }
}
