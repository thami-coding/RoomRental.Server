using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration;

public class ImageConfiguration: IEntityTypeConfiguration<Image>
{
    public void Configure(EntityTypeBuilder<Image> builder)
    {
        var apartmentId = new Guid("7c9e6679-7425-40de-944b-e07fc1f90ae7");

        builder.HasData(
            new Image
            {
                ImageId = new Guid("1a2b3c4d-1234-5678-abcd-1a2b3c4d5e6f"),
                Url = "https://picsum.photos/seed/picsum/200/300",
                ApartmentId = apartmentId
            }
        );
    }
}
