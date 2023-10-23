using Microsoft.EntityFrameworkCore;
using Recipes.Shared.Entities;

namespace Recipes.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }


        public DbSet<Category>Categories { get; set; }
        public DbSet<Favorite>Favorites { get; set; }
        public DbSet<Ingredient>Ingredients { get; set; }
        public DbSet<Recipe>Recipes { get; set; }
        public DbSet<RecipeCategory>RecipeCategories { get; set; }
        public DbSet<IngredientRecipe> IngredientRecipes { get; set; }
        public DbSet<Review>Reviews { get; set; }
        public DbSet<Step>Steps { get; set; }
        public DbSet<User>Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasIndex(c => c.Name).IsUnique();
            modelBuilder.Entity<Ingredient>().HasIndex(c => c.IngredientName).IsUnique();
        }
    }
}
