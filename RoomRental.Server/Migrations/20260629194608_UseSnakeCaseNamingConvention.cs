using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RoomRental.Server.Migrations
{
    /// <inheritdoc />
    public partial class UseSnakeCaseNamingConvention : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Apartments_ApartmentId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Apartments_ApartmentId",
                table: "Images");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Images",
                table: "Images");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Apartments",
                table: "Apartments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses");

            migrationBuilder.RenameTable(
                name: "Images",
                newName: "images");

            migrationBuilder.RenameTable(
                name: "Apartments",
                newName: "apartments");

            migrationBuilder.RenameTable(
                name: "Addresses",
                newName: "addresses");

            migrationBuilder.RenameColumn(
                name: "Url",
                table: "images",
                newName: "url");

            migrationBuilder.RenameColumn(
                name: "ApartmentId",
                table: "images",
                newName: "apartment_id");

            migrationBuilder.RenameColumn(
                name: "ImageId",
                table: "images",
                newName: "image_id");

            migrationBuilder.RenameIndex(
                name: "IX_Images_ApartmentId",
                table: "images",
                newName: "ix_images_apartment_id");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "apartments",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "apartments",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "apartments",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "AvailableRooms",
                table: "apartments",
                newName: "available_rooms");

            migrationBuilder.RenameColumn(
                name: "Suburb",
                table: "addresses",
                newName: "suburb");

            migrationBuilder.RenameColumn(
                name: "Street",
                table: "addresses",
                newName: "street");

            migrationBuilder.RenameColumn(
                name: "Province",
                table: "addresses",
                newName: "province");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "addresses",
                newName: "city");

            migrationBuilder.RenameColumn(
                name: "ApartmentId",
                table: "addresses",
                newName: "apartment_id");

            migrationBuilder.RenameIndex(
                name: "IX_Addresses_ApartmentId",
                table: "addresses",
                newName: "ix_addresses_apartment_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_images",
                table: "images",
                column: "image_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_apartments",
                table: "apartments",
                column: "ApartmentId");

            migrationBuilder.AddPrimaryKey(
                name: "pk_addresses",
                table: "addresses",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "fk_addresses_apartments_apartment_id",
                table: "addresses",
                column: "apartment_id",
                principalTable: "apartments",
                principalColumn: "ApartmentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_images_apartments_apartment_id",
                table: "images",
                column: "apartment_id",
                principalTable: "apartments",
                principalColumn: "ApartmentId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_addresses_apartments_apartment_id",
                table: "addresses");

            migrationBuilder.DropForeignKey(
                name: "fk_images_apartments_apartment_id",
                table: "images");

            migrationBuilder.DropPrimaryKey(
                name: "pk_images",
                table: "images");

            migrationBuilder.DropPrimaryKey(
                name: "pk_apartments",
                table: "apartments");

            migrationBuilder.DropPrimaryKey(
                name: "pk_addresses",
                table: "addresses");

            migrationBuilder.RenameTable(
                name: "images",
                newName: "Images");

            migrationBuilder.RenameTable(
                name: "apartments",
                newName: "Apartments");

            migrationBuilder.RenameTable(
                name: "addresses",
                newName: "Addresses");

            migrationBuilder.RenameColumn(
                name: "url",
                table: "Images",
                newName: "Url");

            migrationBuilder.RenameColumn(
                name: "apartment_id",
                table: "Images",
                newName: "ApartmentId");

            migrationBuilder.RenameColumn(
                name: "image_id",
                table: "Images",
                newName: "ImageId");

            migrationBuilder.RenameIndex(
                name: "ix_images_apartment_id",
                table: "Images",
                newName: "IX_Images_ApartmentId");

            migrationBuilder.RenameColumn(
                name: "title",
                table: "Apartments",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "Apartments",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Apartments",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "available_rooms",
                table: "Apartments",
                newName: "AvailableRooms");

            migrationBuilder.RenameColumn(
                name: "suburb",
                table: "Addresses",
                newName: "Suburb");

            migrationBuilder.RenameColumn(
                name: "street",
                table: "Addresses",
                newName: "Street");

            migrationBuilder.RenameColumn(
                name: "province",
                table: "Addresses",
                newName: "Province");

            migrationBuilder.RenameColumn(
                name: "city",
                table: "Addresses",
                newName: "City");

            migrationBuilder.RenameColumn(
                name: "apartment_id",
                table: "Addresses",
                newName: "ApartmentId");

            migrationBuilder.RenameIndex(
                name: "ix_addresses_apartment_id",
                table: "Addresses",
                newName: "IX_Addresses_ApartmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Images",
                table: "Images",
                column: "ImageId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Apartments",
                table: "Apartments",
                column: "ApartmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Apartments_ApartmentId",
                table: "Addresses",
                column: "ApartmentId",
                principalTable: "Apartments",
                principalColumn: "ApartmentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Apartments_ApartmentId",
                table: "Images",
                column: "ApartmentId",
                principalTable: "Apartments",
                principalColumn: "ApartmentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
