using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Recipes.API.Migrations
{
    /// <inheritdoc />
    public partial class removeunnecesaryfields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Steps");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Ingredients");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Steps",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Ingredients",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
