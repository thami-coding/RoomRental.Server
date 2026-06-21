using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration;

public class ApartmentConfiguration: IEntityTypeConfiguration<Apartment>
{
    public void Configure(EntityTypeBuilder<Apartment> builder)
    {
        var addressId = new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6");

        builder.HasData(
            new Apartment
            {
                ApartmentId = new Guid("7c9e6679-7425-40de-944b-e07fc1f90ae7"),
                Title = "Cozy Studio",
                AvailableRooms = 2,
                Description = "A nice place",
                AddressId = addressId,
                
            }
        );
    }
}
