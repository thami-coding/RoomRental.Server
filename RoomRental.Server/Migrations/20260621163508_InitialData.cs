using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RoomRental.Server.Migrations
{
    /// <inheritdoc />
    public partial class InitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "AddressId", "City", "Province", "Street", "Suburb" },
                values: new object[] { new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), "Durban", "KwaZulu-Natal", "123 Main Street", "Berea" });

            migrationBuilder.InsertData(
                table: "Apartments",
                columns: new[] { "ApartmentId", "AddressId", "AvailableRooms", "Description", "Title" },
                values: new object[] { new Guid("7c9e6679-7425-40de-944b-e07fc1f90ae7"), new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), 2, "A nice place", "Cozy Studio" });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ImageId", "ApartmentId", "Url" },
                values: new object[] { new Guid("1a2b3c4d-1234-5678-abcd-1a2b3c4d5e6f"), new Guid("7c9e6679-7425-40de-944b-e07fc1f90ae7"), "https://picsum.photos/seed/picsum/200/300" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("1a2b3c4d-1234-5678-abcd-1a2b3c4d5e6f"));

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("7c9e6679-7425-40de-944b-e07fc1f90ae7"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "AddressId",
                keyValue: new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"));
        }
    }
}
