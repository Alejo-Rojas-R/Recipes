using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Recipes.API.Migrations
{
    /// <inheritdoc />
    public partial class fixingcamelcaseentities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_favorites_recipes_RecipeId",
                table: "favorites");

            migrationBuilder.DropForeignKey(
                name: "FK_favorites_users_UserId",
                table: "favorites");

            migrationBuilder.DropForeignKey(
                name: "FK_recipeCategories_categories_CategoryId",
                table: "recipeCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_recipeCategories_recipes_RecipeId",
                table: "recipeCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_reviews_recipes_RecipeId",
                table: "reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_reviews_users_UserId",
                table: "reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_steps_ingredients_IngredientId",
                table: "steps");

            migrationBuilder.DropForeignKey(
                name: "FK_steps_recipes_RecipeId",
                table: "steps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_users",
                table: "users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_steps",
                table: "steps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_reviews",
                table: "reviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_recipes",
                table: "recipes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_recipeCategories",
                table: "recipeCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ingredients",
                table: "ingredients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_favorites",
                table: "favorites");

            migrationBuilder.DropPrimaryKey(
                name: "PK_categories",
                table: "categories");

            migrationBuilder.RenameTable(
                name: "users",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "steps",
                newName: "Steps");

            migrationBuilder.RenameTable(
                name: "reviews",
                newName: "Reviews");

            migrationBuilder.RenameTable(
                name: "recipes",
                newName: "Recipes");

            migrationBuilder.RenameTable(
                name: "recipeCategories",
                newName: "RecipeCategories");

            migrationBuilder.RenameTable(
                name: "ingredients",
                newName: "Ingredients");

            migrationBuilder.RenameTable(
                name: "favorites",
                newName: "Favorites");

            migrationBuilder.RenameTable(
                name: "categories",
                newName: "Categories");

            migrationBuilder.RenameColumn(
                name: "lastName",
                table: "Users",
                newName: "LastName");

            migrationBuilder.RenameIndex(
                name: "IX_steps_RecipeId",
                table: "Steps",
                newName: "IX_Steps_RecipeId");

            migrationBuilder.RenameIndex(
                name: "IX_steps_IngredientId",
                table: "Steps",
                newName: "IX_Steps_IngredientId");

            migrationBuilder.RenameColumn(
                name: "date",
                table: "Reviews",
                newName: "Date");

            migrationBuilder.RenameIndex(
                name: "IX_reviews_UserId",
                table: "Reviews",
                newName: "IX_Reviews_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_reviews_RecipeId",
                table: "Reviews",
                newName: "IX_Reviews_RecipeId");

            migrationBuilder.RenameColumn(
                name: "date",
                table: "Recipes",
                newName: "Date");

            migrationBuilder.RenameIndex(
                name: "IX_recipeCategories_RecipeId",
                table: "RecipeCategories",
                newName: "IX_RecipeCategories_RecipeId");

            migrationBuilder.RenameIndex(
                name: "IX_recipeCategories_CategoryId",
                table: "RecipeCategories",
                newName: "IX_RecipeCategories_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_favorites_UserId",
                table: "Favorites",
                newName: "IX_Favorites_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_favorites_RecipeId",
                table: "Favorites",
                newName: "IX_Favorites_RecipeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Steps",
                table: "Steps",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reviews",
                table: "Reviews",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Recipes",
                table: "Recipes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RecipeCategories",
                table: "RecipeCategories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ingredients",
                table: "Ingredients",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Favorites",
                table: "Favorites",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Favorites_Recipes_RecipeId",
                table: "Favorites",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Favorites_Users_UserId",
                table: "Favorites",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeCategories_Categories_CategoryId",
                table: "RecipeCategories",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeCategories_Recipes_RecipeId",
                table: "RecipeCategories",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Recipes_RecipeId",
                table: "Reviews",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Users_UserId",
                table: "Reviews",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Steps_Ingredients_IngredientId",
                table: "Steps",
                column: "IngredientId",
                principalTable: "Ingredients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Steps_Recipes_RecipeId",
                table: "Steps",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Favorites_Recipes_RecipeId",
                table: "Favorites");

            migrationBuilder.DropForeignKey(
                name: "FK_Favorites_Users_UserId",
                table: "Favorites");

            migrationBuilder.DropForeignKey(
                name: "FK_RecipeCategories_Categories_CategoryId",
                table: "RecipeCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_RecipeCategories_Recipes_RecipeId",
                table: "RecipeCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Recipes_RecipeId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Users_UserId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Steps_Ingredients_IngredientId",
                table: "Steps");

            migrationBuilder.DropForeignKey(
                name: "FK_Steps_Recipes_RecipeId",
                table: "Steps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Steps",
                table: "Steps");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reviews",
                table: "Reviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Recipes",
                table: "Recipes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RecipeCategories",
                table: "RecipeCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ingredients",
                table: "Ingredients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Favorites",
                table: "Favorites");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "users");

            migrationBuilder.RenameTable(
                name: "Steps",
                newName: "steps");

            migrationBuilder.RenameTable(
                name: "Reviews",
                newName: "reviews");

            migrationBuilder.RenameTable(
                name: "Recipes",
                newName: "recipes");

            migrationBuilder.RenameTable(
                name: "RecipeCategories",
                newName: "recipeCategories");

            migrationBuilder.RenameTable(
                name: "Ingredients",
                newName: "ingredients");

            migrationBuilder.RenameTable(
                name: "Favorites",
                newName: "favorites");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "categories");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "users",
                newName: "lastName");

            migrationBuilder.RenameIndex(
                name: "IX_Steps_RecipeId",
                table: "steps",
                newName: "IX_steps_RecipeId");

            migrationBuilder.RenameIndex(
                name: "IX_Steps_IngredientId",
                table: "steps",
                newName: "IX_steps_IngredientId");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "reviews",
                newName: "date");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_UserId",
                table: "reviews",
                newName: "IX_reviews_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_RecipeId",
                table: "reviews",
                newName: "IX_reviews_RecipeId");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "recipes",
                newName: "date");

            migrationBuilder.RenameIndex(
                name: "IX_RecipeCategories_RecipeId",
                table: "recipeCategories",
                newName: "IX_recipeCategories_RecipeId");

            migrationBuilder.RenameIndex(
                name: "IX_RecipeCategories_CategoryId",
                table: "recipeCategories",
                newName: "IX_recipeCategories_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Favorites_UserId",
                table: "favorites",
                newName: "IX_favorites_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Favorites_RecipeId",
                table: "favorites",
                newName: "IX_favorites_RecipeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_users",
                table: "users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_steps",
                table: "steps",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_reviews",
                table: "reviews",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_recipes",
                table: "recipes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_recipeCategories",
                table: "recipeCategories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ingredients",
                table: "ingredients",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_favorites",
                table: "favorites",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_categories",
                table: "categories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_favorites_recipes_RecipeId",
                table: "favorites",
                column: "RecipeId",
                principalTable: "recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_favorites_users_UserId",
                table: "favorites",
                column: "UserId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_recipeCategories_categories_CategoryId",
                table: "recipeCategories",
                column: "CategoryId",
                principalTable: "categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_recipeCategories_recipes_RecipeId",
                table: "recipeCategories",
                column: "RecipeId",
                principalTable: "recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_reviews_recipes_RecipeId",
                table: "reviews",
                column: "RecipeId",
                principalTable: "recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_reviews_users_UserId",
                table: "reviews",
                column: "UserId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_steps_ingredients_IngredientId",
                table: "steps",
                column: "IngredientId",
                principalTable: "ingredients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_steps_recipes_RecipeId",
                table: "steps",
                column: "RecipeId",
                principalTable: "recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
