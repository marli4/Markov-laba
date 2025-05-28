using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Markov_laba.Migrations
{
    /// <inheritdoc />
    public partial class AddedCuisine : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "cuisine",
                table: "Restaurant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "delivered",
                table: "Order",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cuisine",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "delivered",
                table: "Order");
        }
    }
}
