using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelListAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddAddressHotel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Hotels",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Hotels");
        }
    }
}
