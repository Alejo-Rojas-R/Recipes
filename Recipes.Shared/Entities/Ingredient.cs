using System.ComponentModel.DataAnnotations;

namespace Recipes.Shared.Entities
{
    public class Ingredient
    {
        public int Id { get; set; }

        [Display(Name = "Nombre del ingrediente")]
        [MaxLength(20)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string? Name { get; set; }

        [Display(Name = "Imagen")]
        [MaxLength(2000)]
        public string? ImageUrl { get; set; }
        public ICollection<IngredientRecipe>? IngredientRecipe { get; set; }
    }
}
