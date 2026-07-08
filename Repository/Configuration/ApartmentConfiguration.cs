using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration;

public class ApartmentConfiguration : IEntityTypeConfiguration<Apartment>
{
    public void Configure(EntityTypeBuilder<Apartment> builder)
    {

        builder.HasData(
            new Apartment { Id = new Guid("7c9e6679-7425-40de-944b-e07fc1f90ae7"), Title = "Cozy Studio", AvailableRooms = 2, Description = "A nice place",Price = 1100 },
            new Apartment { Id = new Guid("759ecab4-ce31-441c-9e7f-47a69040a312"), Title = "Spacious Family Home in Umlazi", AvailableRooms = 3, Description = "A well maintained family home in the heart of Umlazi. Close to schools, shops and public transport.", Price = 2600 },
            new Apartment { Id = new Guid("7cc4c5d3-a093-4a3f-bcd9-695947d3b211"), Title = "Affordable Bachelor Flat in Umlazi", AvailableRooms = 1, Description = "Compact and affordable bachelor flat ideal for a working professional. Secure complex with parking.", Price = 2800 },
            new Apartment { Id = new Guid("3b0086b1-2a2f-4dd7-991f-fcb54114bed0"), Title = "Modern 2 Bedroom in Umlazi", AvailableRooms = 2, Description = "Newly renovated 2 bedroom unit with modern finishes. Walking distance to Umlazi Mega City.", Price = 900 },
            new Apartment { Id = new Guid("0fcc7e71-9f73-4d7d-ba29-51b627eaed68"), Title = "3 Bedroom House in KwaMashu", AvailableRooms = 3, Description = "Spacious 3 bedroom house in a quiet street. Features a garden and secure parking.", Price = 420 },
            new Apartment { Id = new Guid("5d9def3d-df8b-488b-906b-b553138c4250"), Title = "Budget Room in KwaMashu", AvailableRooms = 1, Description = "Affordable single room in a shared house. Ideal for students or young professionals.", Price = 550 },
            new Apartment { Id = new Guid("85defa89-e3b4-4880-afdb-7ef0b2a186f0"), Title = "Cozy 2 Bedroom in KwaMashu", AvailableRooms = 2, Description = "Well kept 2 bedroom unit close to KwaMashu station. Easy access to the CBD.", Price = 500 },
            new Apartment { Id = new Guid("7a9029b4-09e3-4784-a371-6ab719ca10e1"), Title = "Family Unit in Ntuzuma", AvailableRooms = 3, Description = "Large family unit in Ntuzuma with a yard and secure gate. Close to local amenities.", Price = 3000 },
            new Apartment { Id = new Guid("455ca4a3-209f-48ec-ba60-b6dcc79371bb"), Title = "Single Room in Ntuzuma", AvailableRooms = 1, Description = "Simple and clean single room for rent. Shared bathroom and kitchen facilities.", Price = 1500 },
            new Apartment { Id = new Guid("f42801fb-faa9-4cbd-b5ca-bc5e70138801"), Title = "2 Bedroom Flat in Ntuzuma", AvailableRooms = 2, Description = "Comfortable 2 bedroom flat with tiled floors and burglar bars. Secure neighbourhood.", Price = 850 },
            new Apartment { Id = new Guid("86efdab8-4d9c-434e-ba4a-b2dac453edae"), Title = "Spacious Home in Clermont", AvailableRooms = 4, Description = "Large 4 bedroom home perfect for a big family. Has a garage and spacious backyard.", Price = 1200 },
            new Apartment { Id = new Guid("c6241678-eca6-4594-854c-5e2acf8abf81"), Title = "Affordable Flat in Clermont", AvailableRooms = 2, Description = "Clean and affordable 2 bedroom flat in Clermont. Close to taxi ranks and shopping.", Price = 2900 },
            new Apartment { Id = new Guid("07112d1e-3fb9-4106-bb8d-d9c2e511707f"), Title = "Bachelor Pad in Clermont", AvailableRooms = 1, Description = "Neat bachelor flat with own entrance. Ideal for a single working person.", Price = 2200 },
            new Apartment { Id = new Guid("0ee86b56-c90a-4e07-b07b-0c354b70f7f1"), Title = "3 Bedroom House in Lamontville", AvailableRooms = 3, Description = "Well located 3 bedroom house near Lamontville stadium. Good transport links to the city.", Price = 2300 },
            new Apartment { Id = new Guid("d176bf4a-33c8-44cc-989d-d7fb93c396cc"), Title = "Compact Room in Lamontville", AvailableRooms = 1, Description = "Affordable room in a family home. Shared kitchen and bathroom. Water and lights included.", Price = 1600 },
            new Apartment { Id = new Guid("0b10b8bf-5562-4849-9369-09eaf18f679b"), Title = "2 Bedroom Unit in Chesterville", AvailableRooms = 2, Description = "Neat 2 bedroom unit in Chesterville. Tiled throughout with a small stoep.", Price = 3000 },
            new Apartment { Id = new Guid("1901a0e4-3060-425c-b4ae-868ad3d60d8c"), Title = "Family Home in Chesterville", AvailableRooms = 3, Description = "Comfortable family home with 3 bedrooms and a yard. Quiet street with good neighbours.", Price = 650 },
            new Apartment { Id = new Guid("444dfb56-81b1-4404-991c-cfd2cf795bba"), Title = "Single Room in Chesterville", AvailableRooms = 1, Description = "Clean single room with own entrance. Close to public transport and local shops.", Price = 1700 },
            new Apartment { Id = new Guid("e7d194bc-c669-4ded-9690-4e8fff8978dc"), Title = "2 Bedroom Home in KwaDabeka", AvailableRooms = 2, Description = "Affordable 2 bedroom home in KwaDabeka. Secure yard with parking.", Price = 2000 },
            new Apartment { Id = new Guid("18b47fc3-cfb3-42e3-8a2b-da76528f128c"), Title = "Budget Room in KwaDabeka", AvailableRooms = 1, Description = "Basic but clean room in a shared property. Water and electricity included in rent.", Price = 1400 },
            new Apartment { Id = new Guid("924977f3-d616-443f-9340-0805cfec43f3"), Title = "Spacious 3 Bedroom in KwaDabeka", AvailableRooms = 3, Description = "Large 3 bedroom home with a big yard. Ideal for a family looking for space.", Price = 2200 },
            new Apartment { Id = new Guid("a226187c-69ff-4537-93c7-6629fa51f55d"), Title = "Modern Flat in Chatsworth", AvailableRooms = 2, Description = "Modern 2 bedroom flat near Chatsworth Centre. Tiled floors, open plan kitchen.", Price = 700 },
            new Apartment { Id = new Guid("204d39f6-6063-4cb9-9996-b787ed422f0c"), Title = "Family Home in Phoenix", AvailableRooms = 3, Description = "Well maintained 3 bedroom home in Phoenix. Close to schools, temples and shops.", Price = 700 },
            new Apartment { Id = new Guid("926d45f1-6999-4634-bca9-01f3ef0c1fe0"), Title = "Bachelor Flat in Chatsworth", AvailableRooms = 1, Description = "Neat bachelor flat in a secure complex in Chatsworth. Good for a single professional.", Price = 900 },
            new Apartment { Id = new Guid("19c1f5ef-ef57-4169-8952-13fee6bf49a3"), Title = "2 Bedroom Unit in Phoenix", AvailableRooms = 2, Description = "Comfortable 2 bedroom unit in Phoenix close to the industrial area. Easy highway access.", Price = 800 },
            new Apartment { Id = new Guid("dcc0854b-0c75-45da-8457-1871909a78eb"), Title = "Affordable Home in Edendale", AvailableRooms = 3, Description = "Spacious 3 bedroom home in Edendale, Pietermaritzburg. Close to Edendale Hospital and schools.", Price = 2500 },
            new Apartment { Id = new Guid("4b76ace7-8609-42b1-8cb7-2226dc499bb4"), Title = "Single Room in Edendale", AvailableRooms = 1, Description = "Clean single room in a family home in Edendale. Shared facilities. No pets allowed.", Price = 1300 },
            new Apartment { Id = new Guid("29015c46-992a-4d8f-a584-70a6c8be00cc"), Title = "2 Bedroom House in Sobantu", AvailableRooms = 2, Description = "Cozy 2 bedroom house in Sobantu village. Quiet area close to Pietermaritzburg CBD.", Price = 2000 },
            new Apartment { Id = new Guid("938a93ce-4020-419b-85d7-1f7d4cd0554b"), Title = "Family Unit in Sobantu", AvailableRooms = 3, Description = "Well kept 3 bedroom family unit in Sobantu. Yard with washing line and parking.", Price = 1700 },
            new Apartment { Id = new Guid("f0aa0d6a-5449-416e-92a7-3b4711fc57c2"), Title = "3 Bedroom Home in Imbali", AvailableRooms = 3, Description = "Spacious family home in Imbali, Pietermaritzburg. Close to schools and local amenities.", Price = 1600 },
            new Apartment { Id = new Guid("f4556404-fc0e-4adc-9e4e-4aacdadf2f0a"), Title = "Modern Flat in Ashdown", AvailableRooms = 2, Description = "Neat 2 bedroom flat in Ashdown. Modern kitchen and bathroom. Secure complex.", Price = 2300 }
        );
    }
}
