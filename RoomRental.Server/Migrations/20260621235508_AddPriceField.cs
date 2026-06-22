using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RoomRental.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddPriceField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Apartments",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Apartments",
                keyColumn: "ApartmentId",
                keyValue: new Guid("7c9e6679-7425-40de-944b-e07fc1f90ae7"),
                column: "Price",
                value: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Apartments");
        }
    }
}
