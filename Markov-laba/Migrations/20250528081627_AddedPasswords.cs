using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Markov_laba.Migrations
{
    /// <inheritdoc />
    public partial class AddedPasswords : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "password",
                table: "Courier",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "password",
                table: "Client",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "password",
                table: "Courier");

            migrationBuilder.DropColumn(
                name: "password",
                table: "Client");
        }
    }
}
