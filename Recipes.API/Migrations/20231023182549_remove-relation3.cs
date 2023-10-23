using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Recipes.API.Migrations
{
    /// <inheritdoc />
    public partial class removerelation3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IngredientRecipes_Categories_CategoryId",
                table: "IngredientRecipes");

            migrationBuilder.DropForeignKey(
                name: "FK_IngredientRecipes_Recipes_RecipeId",
                table: "IngredientRecipes");

            migrationBuilder.DropIndex(
                name: "IX_IngredientRecipes_CategoryId",
                table: "IngredientRecipes");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "IngredientRecipes");

            migrationBuilder.AlterColumn<int>(
                name: "RecipeId",
                table: "IngredientRecipes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientRecipes_Recipes_RecipeId",
                table: "IngredientRecipes",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IngredientRecipes_Recipes_RecipeId",
                table: "IngredientRecipes");

            migrationBuilder.AlterColumn<int>(
                name: "RecipeId",
                table: "IngredientRecipes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "IngredientRecipes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_IngredientRecipes_CategoryId",
                table: "IngredientRecipes",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientRecipes_Categories_CategoryId",
                table: "IngredientRecipes",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IngredientRecipes_Recipes_RecipeId",
                table: "IngredientRecipes",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "Id");
        }
    }
}
