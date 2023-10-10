using Microsoft.EntityFrameworkCore;
using Recipes.Shared.Entities;

namespace Recipes.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }


        public DbSet<Category>categories { get; set; }
        public DbSet<Favorite>favorites { get; set; }
        public DbSet<Ingredient> ingredients { get; set; }
        public DbSet<Recipe> recipes { get; set; }
        public DbSet<RecipeCategory>recipeCategories { get; set; }
        public DbSet<Review> reviews { get; set; }
        public DbSet<Step> steps { get; set; }
        public DbSet<User> users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
