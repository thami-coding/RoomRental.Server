

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration;

public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
{
    public void Configure(EntityTypeBuilder<IdentityRole> builder)
    {
        builder.HasData(
            new IdentityRole
            {
                Id = "3d490a70-94ce-4d15-9494-5248280c2ce3",
                Name = "Manager",
                NormalizedName = "MANAGER",
                ConcurrencyStamp = "3d490a70-94ce-4d15-9494-5248280c2ce3"
            },
            new IdentityRole
            {
                Id = "b4280b6a-0613-4cbd-a9e6-f1701e926e73",
                Name = "Renter",
                NormalizedName = "RENTER",
                ConcurrencyStamp = "b4280b6a-0613-4cbd-a9e6-f1701e926e73"
            }
            );
    }
}
