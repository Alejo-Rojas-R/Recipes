using System.ComponentModel.DataAnnotations;

namespace Recipes.Shared.Entities
{
    public class IngredientRecipe
    {
        public int Id { get; set; }

        [Display(Name = "Cantidad")]
        [MaxLength(20)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string? Quantity { get; set; }

        public Ingredient? Ingredient { get; set; }

        public int IngredientId { get; set; }

        public Recipe? Recipe { get; set; }

        public int RecipeId { get; set; }
    }
}