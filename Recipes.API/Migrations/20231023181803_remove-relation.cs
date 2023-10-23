using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Recipes.API.Migrations
{
    /// <inheritdoc />
    public partial class removerelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Steps_Ingredients_IngredientId",
                table: "Steps");

            migrationBuilder.DropIndex(
                name: "IX_Steps_IngredientId",
                table: "Steps");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Steps_IngredientId",
                table: "Steps",
                column: "IngredientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Steps_Ingredients_IngredientId",
                table: "Steps",
                column: "IngredientId",
                principalTable: "Ingredients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
