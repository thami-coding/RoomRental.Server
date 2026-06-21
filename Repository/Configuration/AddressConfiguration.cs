using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration;

public class AddressConfiguration : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> builder)
    {
        builder.HasData(
            new Address
            {
                AddressId = new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"),
                Street = "123 Main Street",
                Province = "KwaZulu-Natal",
                City = "Durban",
                Suburb = "Berea"

            }
        );
    }
}
