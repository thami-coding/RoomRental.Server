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
            migrationBuilder.CreateTable(
                name: "apartments",
                columns: table => new
                {
                    ApartmentId = table.Column<Guid>(type: "uuid", nullable: false),
                    title = table.Column<string>(type: "text", nullable: true),
                    available_rooms = table.Column<int>(type: "integer", nullable: false),
                    description = table.Column<string>(type: "text", nullable: true),
                    price = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_apartments", x => x.ApartmentId);
                });

            migrationBuilder.CreateTable(
                name: "addresses",
                columns: table => new
                {
                    AddressId = table.Column<Guid>(type: "uuid", nullable: false),
                    street = table.Column<string>(type: "text", nullable: true),
                    province = table.Column<string>(type: "text", nullable: true),
                    city = table.Column<string>(type: "text", nullable: true),
                    suburb = table.Column<string>(type: "text", nullable: true),
                    apartment_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_addresses", x => x.AddressId);
                    table.ForeignKey(
                        name: "fk_addresses_apartments_apartment_id",
                        column: x => x.apartment_id,
                        principalTable: "apartments",
                        principalColumn: "ApartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "images",
                columns: table => new
                {
                    image_id = table.Column<Guid>(type: "uuid", nullable: false),
                    url = table.Column<string>(type: "text", nullable: true),
                    apartment_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_images", x => x.image_id);
                    table.ForeignKey(
                        name: "fk_images_apartments_apartment_id",
                        column: x => x.apartment_id,
                        principalTable: "apartments",
                        principalColumn: "ApartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "apartments",
                columns: new[] { "ApartmentId", "available_rooms", "description", "price", "title" },
                values: new object[] { new Guid("7c9e6679-7425-40de-944b-e07fc1f90ae7"), 2, "A nice place", 0m, "Cozy Studio" });

            migrationBuilder.InsertData(
                table: "addresses",
                columns: new[] { "AddressId", "apartment_id", "city", "province", "street", "suburb" },
                values: new object[] { new Guid("3fa85f64-5717-4562-b3fc-2c963f66afa6"), new Guid("7c9e6679-7425-40de-944b-e07fc1f90ae7"), "Durban", "KwaZulu-Natal", "123 Main Street", "Berea" });

            migrationBuilder.InsertData(
                table: "images",
                columns: new[] { "image_id", "apartment_id", "url" },
                values: new object[] { new Guid("1a2b3c4d-1234-5678-abcd-1a2b3c4d5e6f"), new Guid("7c9e6679-7425-40de-944b-e07fc1f90ae7"), "https://picsum.photos/seed/picsum/200/300" });

            migrationBuilder.CreateIndex(
                name: "ix_addresses_apartment_id",
                table: "addresses",
                column: "apartment_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_images_apartment_id",
                table: "images",
                column: "apartment_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "addresses");

            migrationBuilder.DropTable(
                name: "images");

            migrationBuilder.DropTable(
                name: "apartments");
        }
    }
}
