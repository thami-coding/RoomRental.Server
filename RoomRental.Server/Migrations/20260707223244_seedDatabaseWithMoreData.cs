using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RoomRental.Server.Migrations
{
    /// <inheritdoc />
    public partial class seedDatabaseWithMoreData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("7c9e6679-7425-40de-944b-e07fc1f90ae7"),
                column: "price",
                value: 1100m);

            migrationBuilder.InsertData(
                table: "apartments",
                columns: new[] { "ApartmentId", "available_rooms", "description", "price", "title" },
                values: new object[,]
                {
                    { new Guid("07112d1e-3fb9-4106-bb8d-d9c2e511707f"), 1, "Neat bachelor flat with own entrance. Ideal for a single working person.", 2200m, "Bachelor Pad in Clermont" },
                    { new Guid("0b10b8bf-5562-4849-9369-09eaf18f679b"), 2, "Neat 2 bedroom unit in Chesterville. Tiled throughout with a small stoep.", 3000m, "2 Bedroom Unit in Chesterville" },
                    { new Guid("0ee86b56-c90a-4e07-b07b-0c354b70f7f1"), 3, "Well located 3 bedroom house near Lamontville stadium. Good transport links to the city.", 2300m, "3 Bedroom House in Lamontville" },
                    { new Guid("0fcc7e71-9f73-4d7d-ba29-51b627eaed68"), 3, "Spacious 3 bedroom house in a quiet street. Features a garden and secure parking.", 420m, "3 Bedroom House in KwaMashu" },
                    { new Guid("18b47fc3-cfb3-42e3-8a2b-da76528f128c"), 1, "Basic but clean room in a shared property. Water and electricity included in rent.", 1400m, "Budget Room in KwaDabeka" },
                    { new Guid("1901a0e4-3060-425c-b4ae-868ad3d60d8c"), 3, "Comfortable family home with 3 bedrooms and a yard. Quiet street with good neighbours.", 650m, "Family Home in Chesterville" },
                    { new Guid("19c1f5ef-ef57-4169-8952-13fee6bf49a3"), 2, "Comfortable 2 bedroom unit in Phoenix close to the industrial area. Easy highway access.", 800m, "2 Bedroom Unit in Phoenix" },
                    { new Guid("204d39f6-6063-4cb9-9996-b787ed422f0c"), 3, "Well maintained 3 bedroom home in Phoenix. Close to schools, temples and shops.", 700m, "Family Home in Phoenix" },
                    { new Guid("29015c46-992a-4d8f-a584-70a6c8be00cc"), 2, "Cozy 2 bedroom house in Sobantu village. Quiet area close to Pietermaritzburg CBD.", 2000m, "2 Bedroom House in Sobantu" },
                    { new Guid("3b0086b1-2a2f-4dd7-991f-fcb54114bed0"), 2, "Newly renovated 2 bedroom unit with modern finishes. Walking distance to Umlazi Mega City.", 900m, "Modern 2 Bedroom in Umlazi" },
                    { new Guid("444dfb56-81b1-4404-991c-cfd2cf795bba"), 1, "Clean single room with own entrance. Close to public transport and local shops.", 1700m, "Single Room in Chesterville" },
                    { new Guid("455ca4a3-209f-48ec-ba60-b6dcc79371bb"), 1, "Simple and clean single room for rent. Shared bathroom and kitchen facilities.", 1500m, "Single Room in Ntuzuma" },
                    { new Guid("4b76ace7-8609-42b1-8cb7-2226dc499bb4"), 1, "Clean single room in a family home in Edendale. Shared facilities. No pets allowed.", 1300m, "Single Room in Edendale" },
                    { new Guid("5d9def3d-df8b-488b-906b-b553138c4250"), 1, "Affordable single room in a shared house. Ideal for students or young professionals.", 550m, "Budget Room in KwaMashu" },
                    { new Guid("759ecab4-ce31-441c-9e7f-47a69040a312"), 3, "A well maintained family home in the heart of Umlazi. Close to schools, shops and public transport.", 2600m, "Spacious Family Home in Umlazi" },
                    { new Guid("7a9029b4-09e3-4784-a371-6ab719ca10e1"), 3, "Large family unit in Ntuzuma with a yard and secure gate. Close to local amenities.", 3000m, "Family Unit in Ntuzuma" },
                    { new Guid("7cc4c5d3-a093-4a3f-bcd9-695947d3b211"), 1, "Compact and affordable bachelor flat ideal for a working professional. Secure complex with parking.", 2800m, "Affordable Bachelor Flat in Umlazi" },
                    { new Guid("85defa89-e3b4-4880-afdb-7ef0b2a186f0"), 2, "Well kept 2 bedroom unit close to KwaMashu station. Easy access to the CBD.", 500m, "Cozy 2 Bedroom in KwaMashu" },
                    { new Guid("86efdab8-4d9c-434e-ba4a-b2dac453edae"), 4, "Large 4 bedroom home perfect for a big family. Has a garage and spacious backyard.", 1200m, "Spacious Home in Clermont" },
                    { new Guid("924977f3-d616-443f-9340-0805cfec43f3"), 3, "Large 3 bedroom home with a big yard. Ideal for a family looking for space.", 2200m, "Spacious 3 Bedroom in KwaDabeka" },
                    { new Guid("926d45f1-6999-4634-bca9-01f3ef0c1fe0"), 1, "Neat bachelor flat in a secure complex in Chatsworth. Good for a single professional.", 900m, "Bachelor Flat in Chatsworth" },
                    { new Guid("938a93ce-4020-419b-85d7-1f7d4cd0554b"), 3, "Well kept 3 bedroom family unit in Sobantu. Yard with washing line and parking.", 1700m, "Family Unit in Sobantu" },
                    { new Guid("a226187c-69ff-4537-93c7-6629fa51f55d"), 2, "Modern 2 bedroom flat near Chatsworth Centre. Tiled floors, open plan kitchen.", 700m, "Modern Flat in Chatsworth" },
                    { new Guid("c6241678-eca6-4594-854c-5e2acf8abf81"), 2, "Clean and affordable 2 bedroom flat in Clermont. Close to taxi ranks and shopping.", 2900m, "Affordable Flat in Clermont" },
                    { new Guid("d176bf4a-33c8-44cc-989d-d7fb93c396cc"), 1, "Affordable room in a family home. Shared kitchen and bathroom. Water and lights included.", 1600m, "Compact Room in Lamontville" },
                    { new Guid("dcc0854b-0c75-45da-8457-1871909a78eb"), 3, "Spacious 3 bedroom home in Edendale, Pietermaritzburg. Close to Edendale Hospital and schools.", 2500m, "Affordable Home in Edendale" },
                    { new Guid("e7d194bc-c669-4ded-9690-4e8fff8978dc"), 2, "Affordable 2 bedroom home in KwaDabeka. Secure yard with parking.", 2000m, "2 Bedroom Home in KwaDabeka" },
                    { new Guid("f0aa0d6a-5449-416e-92a7-3b4711fc57c2"), 3, "Spacious family home in Imbali, Pietermaritzburg. Close to schools and local amenities.", 1600m, "3 Bedroom Home in Imbali" },
                    { new Guid("f42801fb-faa9-4cbd-b5ca-bc5e70138801"), 2, "Comfortable 2 bedroom flat with tiled floors and burglar bars. Secure neighbourhood.", 850m, "2 Bedroom Flat in Ntuzuma" },
                    { new Guid("f4556404-fc0e-4adc-9e4e-4aacdadf2f0a"), 2, "Neat 2 bedroom flat in Ashdown. Modern kitchen and bathroom. Secure complex.", 2300m, "Modern Flat in Ashdown" }
                });

            migrationBuilder.InsertData(
                table: "addresses",
                columns: new[] { "AddressId", "apartment_id", "city", "province", "street", "suburb" },
                values: new object[,]
                {
                    { new Guid("00d3e707-e057-43b1-92a5-63624a53a3ba"), new Guid("7a9029b4-09e3-4784-a371-6ab719ca10e1"), "Durban", "KwaZulu-Natal", "15 Ntuzuma Road", "Ntuzuma" },
                    { new Guid("208a5e1c-3ab5-4157-9fad-b32654b4c9dc"), new Guid("7cc4c5d3-a093-4a3f-bcd9-695947d3b211"), "Durban", "KwaZulu-Natal", "45 Nyandeni Road", "Umlazi" },
                    { new Guid("20b407d9-fe7c-40a9-a811-bb055e515924"), new Guid("f42801fb-faa9-4cbd-b5ca-bc5e70138801"), "Durban", "KwaZulu-Natal", "9 Maphumulo Drive", "Ntuzuma" },
                    { new Guid("2820c620-a856-47d8-b666-1828d3922eac"), new Guid("85defa89-e3b4-4880-afdb-7ef0b2a186f0"), "Durban", "KwaZulu-Natal", "3 Dube Place", "KwaMashu" },
                    { new Guid("2a523149-a8e9-4bba-859a-2ab489cded75"), new Guid("d176bf4a-33c8-44cc-989d-d7fb93c396cc"), "Durban", "KwaZulu-Natal", "41 Ngcobo Street", "Lamontville" },
                    { new Guid("4974bb04-ebb3-456d-a3f2-cef34c494497"), new Guid("f0aa0d6a-5449-416e-92a7-3b4711fc57c2"), "Pietermaritzburg", "KwaZulu-Natal", "43 Imbali Main Road", "Imbali" },
                    { new Guid("4db85c11-b6c1-4ba3-9ac3-8e109cebf2df"), new Guid("924977f3-d616-443f-9340-0805cfec43f3"), "Durban", "KwaZulu-Natal", "6 Mthethwa Drive", "KwaDabeka" },
                    { new Guid("5b6573b5-d980-4793-8636-3dfb35029d11"), new Guid("e7d194bc-c669-4ded-9690-4e8fff8978dc"), "Durban", "KwaZulu-Natal", "38 KwaDabeka Road", "KwaDabeka" },
                    { new Guid("62d6e954-2f4d-45c4-a1c8-9dcc2a132c53"), new Guid("926d45f1-6999-4634-bca9-01f3ef0c1fe0"), "Durban", "KwaZulu-Natal", "17 Lotus Park Drive", "Chatsworth" },
                    { new Guid("6f3dd6a9-143f-4e7e-868b-8e2cd1165bb7"), new Guid("444dfb56-81b1-4404-991c-cfd2cf795bba"), "Durban", "KwaZulu-Natal", "11 Sithole Street", "Chesterville" },
                    { new Guid("79936c8c-67c3-4fd5-93ec-30125aefabc7"), new Guid("a226187c-69ff-4537-93c7-6629fa51f55d"), "Durban", "KwaZulu-Natal", "29 Chatsworth Centre Road", "Chatsworth" },
                    { new Guid("81bcd457-5d93-488a-bcda-79aafaead87f"), new Guid("0fcc7e71-9f73-4d7d-ba29-51b627eaed68"), "Durban", "KwaZulu-Natal", "23 Mthembu Road", "KwaMashu" },
                    { new Guid("8347c94b-5dd2-40b0-9aca-38d6f0f2fcfd"), new Guid("0ee86b56-c90a-4e07-b07b-0c354b70f7f1"), "Durban", "KwaZulu-Natal", "19 Lamontville Highway", "Lamontville" },
                    { new Guid("89051b63-50b2-4d8f-ac6e-26d9eb81cc79"), new Guid("86efdab8-4d9c-434e-ba4a-b2dac453edae"), "Durban", "KwaZulu-Natal", "34 Clermont Main Road", "Clermont" },
                    { new Guid("8bf583e7-a76a-4b98-84a3-3b27f86cfb7a"), new Guid("1901a0e4-3060-425c-b4ae-868ad3d60d8c"), "Durban", "KwaZulu-Natal", "55 Khoza Road", "Chesterville" },
                    { new Guid("997e1fc0-ee17-407b-9d4c-843eddaecc07"), new Guid("0b10b8bf-5562-4849-9369-09eaf18f679b"), "Durban", "KwaZulu-Natal", "27 Mhlongo Drive", "Chesterville" },
                    { new Guid("a5c15dbe-c304-4026-9622-b9db1fd5232e"), new Guid("29015c46-992a-4d8f-a584-70a6c8be00cc"), "Pietermaritzburg", "KwaZulu-Natal", "32 Sobantu Village Road", "Sobantu" },
                    { new Guid("aa803b77-3292-4d1b-86b9-6d3fe2576eef"), new Guid("759ecab4-ce31-441c-9e7f-47a69040a312"), "Durban", "KwaZulu-Natal", "12 Msizi Drive", "Umlazi" },
                    { new Guid("af1c9601-815f-4d17-a25d-8184f821e003"), new Guid("07112d1e-3fb9-4106-bb8d-d9c2e511707f"), "Durban", "KwaZulu-Natal", "5 Buthelezi Road", "Clermont" },
                    { new Guid("b483ab33-3dae-4029-b901-b5c334fccc0f"), new Guid("3b0086b1-2a2f-4dd7-991f-fcb54114bed0"), "Durban", "KwaZulu-Natal", "7 Bhekani Street", "Umlazi" },
                    { new Guid("ba3fabbb-1830-4099-8c73-0648301f85c3"), new Guid("19c1f5ef-ef57-4169-8952-13fee6bf49a3"), "Durban", "KwaZulu-Natal", "53 Phoenix Industrial Road", "Phoenix" },
                    { new Guid("c9da969c-8d79-4386-83e0-573febb02b64"), new Guid("4b76ace7-8609-42b1-8cb7-2226dc499bb4"), "Pietermaritzburg", "KwaZulu-Natal", "66 Mkhize Street", "Edendale" },
                    { new Guid("d84a9e60-201f-4d77-9c0a-04227ee460fe"), new Guid("5d9def3d-df8b-488b-906b-b553138c4250"), "Durban", "KwaZulu-Natal", "89 Nkosi Street", "KwaMashu" },
                    { new Guid("dbea8f89-cdb5-4cb3-bcc4-1039022e91d8"), new Guid("938a93ce-4020-419b-85d7-1f7d4cd0554b"), "Pietermaritzburg", "KwaZulu-Natal", "8 Ngubane Drive", "Sobantu" },
                    { new Guid("e2d95181-6034-469a-90c9-a21faf97188b"), new Guid("18b47fc3-cfb3-42e3-8a2b-da76528f128c"), "Durban", "KwaZulu-Natal", "72 Ndlovu Street", "KwaDabeka" },
                    { new Guid("e8919bfe-f303-46b4-b84b-f84a16fabad1"), new Guid("dcc0854b-0c75-45da-8457-1871909a78eb"), "Pietermaritzburg", "KwaZulu-Natal", "14 Edendale Road", "Edendale" },
                    { new Guid("ebbf0fde-ebb5-434c-bc56-1acb49400dd0"), new Guid("455ca4a3-209f-48ec-ba60-b6dcc79371bb"), "Durban", "KwaZulu-Natal", "62 Zulu Street", "Ntuzuma" },
                    { new Guid("f2f3411c-3e6e-4265-a575-7d7002da0762"), new Guid("c6241678-eca6-4594-854c-5e2acf8abf81"), "Durban", "KwaZulu-Natal", "78 Cele Street", "Clermont" },
                    { new Guid("f6b057a7-cf3d-45f0-81f9-fc528cf9d9c3"), new Guid("f4556404-fc0e-4adc-9e4e-4aacdadf2f0a"), "Pietermaritzburg", "KwaZulu-Natal", "21 Ashdown Road", "Ashdown" },
                    { new Guid("ffbccbda-73e8-43f0-a80a-fd1f85972b29"), new Guid("204d39f6-6063-4cb9-9996-b787ed422f0c"), "Durban", "KwaZulu-Natal", "84 Phoenix Main Road", "Phoenix" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("00d3e707-e057-43b1-92a5-63624a53a3ba"));

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("208a5e1c-3ab5-4157-9fad-b32654b4c9dc"));

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("20b407d9-fe7c-40a9-a811-bb055e515924"));

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("2820c620-a856-47d8-b666-1828d3922eac"));

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("2a523149-a8e9-4bba-859a-2ab489cded75"));

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("4974bb04-ebb3-456d-a3f2-cef34c494497"));

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("4db85c11-b6c1-4ba3-9ac3-8e109cebf2df"));

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("5b6573b5-d980-4793-8636-3dfb35029d11"));

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("62d6e954-2f4d-45c4-a1c8-9dcc2a132c53"));

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("6f3dd6a9-143f-4e7e-868b-8e2cd1165bb7"));

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("79936c8c-67c3-4fd5-93ec-30125aefabc7"));

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("81bcd457-5d93-488a-bcda-79aafaead87f"));

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("8347c94b-5dd2-40b0-9aca-38d6f0f2fcfd"));

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("89051b63-50b2-4d8f-ac6e-26d9eb81cc79"));

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("8bf583e7-a76a-4b98-84a3-3b27f86cfb7a"));

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("997e1fc0-ee17-407b-9d4c-843eddaecc07"));

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("a5c15dbe-c304-4026-9622-b9db1fd5232e"));

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("aa803b77-3292-4d1b-86b9-6d3fe2576eef"));

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("af1c9601-815f-4d17-a25d-8184f821e003"));

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("b483ab33-3dae-4029-b901-b5c334fccc0f"));

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("ba3fabbb-1830-4099-8c73-0648301f85c3"));

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("c9da969c-8d79-4386-83e0-573febb02b64"));

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("d84a9e60-201f-4d77-9c0a-04227ee460fe"));

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("dbea8f89-cdb5-4cb3-bcc4-1039022e91d8"));

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("e2d95181-6034-469a-90c9-a21faf97188b"));

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("e8919bfe-f303-46b4-b84b-f84a16fabad1"));

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("ebbf0fde-ebb5-434c-bc56-1acb49400dd0"));

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("f2f3411c-3e6e-4265-a575-7d7002da0762"));

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("f6b057a7-cf3d-45f0-81f9-fc528cf9d9c3"));

            migrationBuilder.DeleteData(
                table: "addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("ffbccbda-73e8-43f0-a80a-fd1f85972b29"));

            migrationBuilder.DeleteData(
                table: "apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("07112d1e-3fb9-4106-bb8d-d9c2e511707f"));

            migrationBuilder.DeleteData(
                table: "apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("0b10b8bf-5562-4849-9369-09eaf18f679b"));

            migrationBuilder.DeleteData(
                table: "apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("0ee86b56-c90a-4e07-b07b-0c354b70f7f1"));

            migrationBuilder.DeleteData(
                table: "apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("0fcc7e71-9f73-4d7d-ba29-51b627eaed68"));

            migrationBuilder.DeleteData(
                table: "apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("18b47fc3-cfb3-42e3-8a2b-da76528f128c"));

            migrationBuilder.DeleteData(
                table: "apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("1901a0e4-3060-425c-b4ae-868ad3d60d8c"));

            migrationBuilder.DeleteData(
                table: "apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("19c1f5ef-ef57-4169-8952-13fee6bf49a3"));

            migrationBuilder.DeleteData(
                table: "apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("204d39f6-6063-4cb9-9996-b787ed422f0c"));

            migrationBuilder.DeleteData(
                table: "apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("29015c46-992a-4d8f-a584-70a6c8be00cc"));

            migrationBuilder.DeleteData(
                table: "apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("3b0086b1-2a2f-4dd7-991f-fcb54114bed0"));

            migrationBuilder.DeleteData(
                table: "apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("444dfb56-81b1-4404-991c-cfd2cf795bba"));

            migrationBuilder.DeleteData(
                table: "apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("455ca4a3-209f-48ec-ba60-b6dcc79371bb"));

            migrationBuilder.DeleteData(
                table: "apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("4b76ace7-8609-42b1-8cb7-2226dc499bb4"));

            migrationBuilder.DeleteData(
                table: "apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("5d9def3d-df8b-488b-906b-b553138c4250"));

            migrationBuilder.DeleteData(
                table: "apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("759ecab4-ce31-441c-9e7f-47a69040a312"));

            migrationBuilder.DeleteData(
                table: "apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("7a9029b4-09e3-4784-a371-6ab719ca10e1"));

            migrationBuilder.DeleteData(
                table: "apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("7cc4c5d3-a093-4a3f-bcd9-695947d3b211"));

            migrationBuilder.DeleteData(
                table: "apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("85defa89-e3b4-4880-afdb-7ef0b2a186f0"));

            migrationBuilder.DeleteData(
                table: "apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("86efdab8-4d9c-434e-ba4a-b2dac453edae"));

            migrationBuilder.DeleteData(
                table: "apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("924977f3-d616-443f-9340-0805cfec43f3"));

            migrationBuilder.DeleteData(
                table: "apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("926d45f1-6999-4634-bca9-01f3ef0c1fe0"));

            migrationBuilder.DeleteData(
                table: "apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("938a93ce-4020-419b-85d7-1f7d4cd0554b"));

            migrationBuilder.DeleteData(
                table: "apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("a226187c-69ff-4537-93c7-6629fa51f55d"));

            migrationBuilder.DeleteData(
                table: "apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("c6241678-eca6-4594-854c-5e2acf8abf81"));

            migrationBuilder.DeleteData(
                table: "apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("d176bf4a-33c8-44cc-989d-d7fb93c396cc"));

            migrationBuilder.DeleteData(
                table: "apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("dcc0854b-0c75-45da-8457-1871909a78eb"));

            migrationBuilder.DeleteData(
                table: "apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("e7d194bc-c669-4ded-9690-4e8fff8978dc"));

            migrationBuilder.DeleteData(
                table: "apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("f0aa0d6a-5449-416e-92a7-3b4711fc57c2"));

            migrationBuilder.DeleteData(
                table: "apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("f42801fb-faa9-4cbd-b5ca-bc5e70138801"));

            migrationBuilder.DeleteData(
                table: "apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("f4556404-fc0e-4adc-9e4e-4aacdadf2f0a"));

            migrationBuilder.UpdateData(
                table: "apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("7c9e6679-7425-40de-944b-e07fc1f90ae7"),
                column: "price",
                value: 0m);
        }
    }
}
