using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration;

public class AddressConfiguration : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> builder)
    {
        builder.HasData(
            new Address { Id = new Guid("3fa85f6457174562b3fc2c963f66afa6"), Street = "123 Main Street", Province = "KwaZulu-Natal", City = "Durban", Suburb = "Berea", ApartmentId = new Guid("7c9e6679-7425-40de-944b-e07fc1f90ae7") },
            new Address { Id = new Guid("aa803b77-3292-4d1b-86b9-6d3fe2576eef"), Street = "12 Msizi Drive", Province = "KwaZulu-Natal", City = "Durban", Suburb = "Umlazi", ApartmentId = new Guid("759ecab4-ce31-441c-9e7f-47a69040a312") },
            new Address { Id = new Guid("208a5e1c-3ab5-4157-9fad-b32654b4c9dc"), Street = "45 Nyandeni Road", Province = "KwaZulu-Natal", City = "Durban", Suburb = "Umlazi", ApartmentId = new Guid("7cc4c5d3-a093-4a3f-bcd9-695947d3b211") },
            new Address { Id = new Guid("b483ab33-3dae-4029-b901-b5c334fccc0f"), Street = "7 Bhekani Street", Province = "KwaZulu-Natal", City = "Durban", Suburb = "Umlazi", ApartmentId = new Guid("3b0086b1-2a2f-4dd7-991f-fcb54114bed0") },
            new Address { Id = new Guid("81bcd457-5d93-488a-bcda-79aafaead87f"), Street = "23 Mthembu Road", Province = "KwaZulu-Natal", City = "Durban", Suburb = "KwaMashu", ApartmentId = new Guid("0fcc7e71-9f73-4d7d-ba29-51b627eaed68") },
            new Address { Id = new Guid("d84a9e60-201f-4d77-9c0a-04227ee460fe"), Street = "89 Nkosi Street", Province = "KwaZulu-Natal", City = "Durban", Suburb = "KwaMashu", ApartmentId = new Guid("5d9def3d-df8b-488b-906b-b553138c4250") },
            new Address { Id = new Guid("2820c620-a856-47d8-b666-1828d3922eac"), Street = "3 Dube Place", Province = "KwaZulu-Natal", City = "Durban", Suburb = "KwaMashu", ApartmentId = new Guid("85defa89-e3b4-4880-afdb-7ef0b2a186f0") },
            new Address { Id = new Guid("00d3e707-e057-43b1-92a5-63624a53a3ba"), Street = "15 Ntuzuma Road", Province = "KwaZulu-Natal", City = "Durban", Suburb = "Ntuzuma", ApartmentId = new Guid("7a9029b4-09e3-4784-a371-6ab719ca10e1") },
            new Address { Id = new Guid("ebbf0fde-ebb5-434c-bc56-1acb49400dd0"), Street = "62 Zulu Street", Province = "KwaZulu-Natal", City = "Durban", Suburb = "Ntuzuma", ApartmentId = new Guid("455ca4a3-209f-48ec-ba60-b6dcc79371bb") },
            new Address { Id = new Guid("20b407d9-fe7c-40a9-a811-bb055e515924"), Street = "9 Maphumulo Drive", Province = "KwaZulu-Natal", City = "Durban", Suburb = "Ntuzuma", ApartmentId = new Guid("f42801fb-faa9-4cbd-b5ca-bc5e70138801") },
            new Address { Id = new Guid("89051b63-50b2-4d8f-ac6e-26d9eb81cc79"), Street = "34 Clermont Main Road", Province = "KwaZulu-Natal", City = "Durban", Suburb = "Clermont", ApartmentId = new Guid("86efdab8-4d9c-434e-ba4a-b2dac453edae") },
            new Address { Id = new Guid("f2f3411c-3e6e-4265-a575-7d7002da0762"), Street = "78 Cele Street", Province = "KwaZulu-Natal", City = "Durban", Suburb = "Clermont", ApartmentId = new Guid("c6241678-eca6-4594-854c-5e2acf8abf81") },
            new Address { Id = new Guid("af1c9601-815f-4d17-a25d-8184f821e003"), Street = "5 Buthelezi Road", Province = "KwaZulu-Natal", City = "Durban", Suburb = "Clermont", ApartmentId = new Guid("07112d1e-3fb9-4106-bb8d-d9c2e511707f") },
            new Address { Id = new Guid("8347c94b-5dd2-40b0-9aca-38d6f0f2fcfd"), Street = "19 Lamontville Highway", Province = "KwaZulu-Natal", City = "Durban", Suburb = "Lamontville", ApartmentId = new Guid("0ee86b56-c90a-4e07-b07b-0c354b70f7f1") },
            new Address { Id = new Guid("2a523149-a8e9-4bba-859a-2ab489cded75"), Street = "41 Ngcobo Street", Province = "KwaZulu-Natal", City = "Durban", Suburb = "Lamontville", ApartmentId = new Guid("d176bf4a-33c8-44cc-989d-d7fb93c396cc") },
            new Address { Id = new Guid("997e1fc0-ee17-407b-9d4c-843eddaecc07"), Street = "27 Mhlongo Drive", Province = "KwaZulu-Natal", City = "Durban", Suburb = "Chesterville", ApartmentId = new Guid("0b10b8bf-5562-4849-9369-09eaf18f679b") },
            new Address { Id = new Guid("8bf583e7-a76a-4b98-84a3-3b27f86cfb7a"), Street = "55 Khoza Road", Province = "KwaZulu-Natal", City = "Durban", Suburb = "Chesterville", ApartmentId = new Guid("1901a0e4-3060-425c-b4ae-868ad3d60d8c") },
            new Address { Id = new Guid("6f3dd6a9-143f-4e7e-868b-8e2cd1165bb7"), Street = "11 Sithole Street", Province = "KwaZulu-Natal", City = "Durban", Suburb = "Chesterville", ApartmentId = new Guid("444dfb56-81b1-4404-991c-cfd2cf795bba") },
            new Address { Id = new Guid("5b6573b5-d980-4793-8636-3dfb35029d11"), Street = "38 KwaDabeka Road", Province = "KwaZulu-Natal", City = "Durban", Suburb = "KwaDabeka", ApartmentId = new Guid("e7d194bc-c669-4ded-9690-4e8fff8978dc") },
            new Address { Id = new Guid("e2d95181-6034-469a-90c9-a21faf97188b"), Street = "72 Ndlovu Street", Province = "KwaZulu-Natal", City = "Durban", Suburb = "KwaDabeka", ApartmentId = new Guid("18b47fc3-cfb3-42e3-8a2b-da76528f128c") },
            new Address { Id = new Guid("4db85c11-b6c1-4ba3-9ac3-8e109cebf2df"), Street = "6 Mthethwa Drive", Province = "KwaZulu-Natal", City = "Durban", Suburb = "KwaDabeka", ApartmentId = new Guid("924977f3-d616-443f-9340-0805cfec43f3") },
            new Address { Id = new Guid("79936c8c-67c3-4fd5-93ec-30125aefabc7"), Street = "29 Chatsworth Centre Road", Province = "KwaZulu-Natal", City = "Durban", Suburb = "Chatsworth", ApartmentId = new Guid("a226187c-69ff-4537-93c7-6629fa51f55d") },
            new Address { Id = new Guid("ffbccbda-73e8-43f0-a80a-fd1f85972b29"), Street = "84 Phoenix Main Road", Province = "KwaZulu-Natal", City = "Durban", Suburb = "Phoenix", ApartmentId = new Guid("204d39f6-6063-4cb9-9996-b787ed422f0c") },
            new Address { Id = new Guid("62d6e954-2f4d-45c4-a1c8-9dcc2a132c53"), Street = "17 Lotus Park Drive", Province = "KwaZulu-Natal", City = "Durban", Suburb = "Chatsworth", ApartmentId = new Guid("926d45f1-6999-4634-bca9-01f3ef0c1fe0") },
            new Address { Id = new Guid("ba3fabbb-1830-4099-8c73-0648301f85c3"), Street = "53 Phoenix Industrial Road", Province = "KwaZulu-Natal", City = "Durban", Suburb = "Phoenix", ApartmentId = new Guid("19c1f5ef-ef57-4169-8952-13fee6bf49a3") },
            new Address { Id = new Guid("e8919bfe-f303-46b4-b84b-f84a16fabad1"), Street = "14 Edendale Road", Province = "KwaZulu-Natal", City = "Pietermaritzburg", Suburb = "Edendale", ApartmentId = new Guid("dcc0854b-0c75-45da-8457-1871909a78eb") },
            new Address { Id = new Guid("c9da969c-8d79-4386-83e0-573febb02b64"), Street = "66 Mkhize Street", Province = "KwaZulu-Natal", City = "Pietermaritzburg", Suburb = "Edendale", ApartmentId = new Guid("4b76ace7-8609-42b1-8cb7-2226dc499bb4") },
            new Address { Id = new Guid("a5c15dbe-c304-4026-9622-b9db1fd5232e"), Street = "32 Sobantu Village Road", Province = "KwaZulu-Natal", City = "Pietermaritzburg", Suburb = "Sobantu", ApartmentId = new Guid("29015c46-992a-4d8f-a584-70a6c8be00cc") },
            new Address { Id = new Guid("dbea8f89-cdb5-4cb3-bcc4-1039022e91d8"), Street = "8 Ngubane Drive", Province = "KwaZulu-Natal", City = "Pietermaritzburg", Suburb = "Sobantu", ApartmentId = new Guid("938a93ce-4020-419b-85d7-1f7d4cd0554b") },
            new Address { Id = new Guid("4974bb04-ebb3-456d-a3f2-cef34c494497"), Street = "43 Imbali Main Road", Province = "KwaZulu-Natal", City = "Pietermaritzburg", Suburb = "Imbali", ApartmentId = new Guid("f0aa0d6a-5449-416e-92a7-3b4711fc57c2") },
            new Address { Id = new Guid("f6b057a7-cf3d-45f0-81f9-fc528cf9d9c3"), Street = "21 Ashdown Road", Province = "KwaZulu-Natal", City = "Pietermaritzburg", Suburb = "Ashdown", ApartmentId = new Guid("f4556404-fc0e-4adc-9e4e-4aacdadf2f0a") }

        );
    }
}
