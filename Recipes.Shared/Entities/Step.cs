using System.ComponentModel.DataAnnotations;

namespace Recipes.Shared.Entities
{
    public class Step
    {
        public int Id { get; set; }

        public int RecipeId { get; set; }

        [Display(Name = "Descripcion del paso a paso de la receta")]
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string? Description { get; set; }

        [Display(Name = "Imagen")]
        [MaxLength(2000)]
        public string? ImageUrl { get; set; }

        [Display(Name = "Numero de paso")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public int Order { get; set; }

        public Recipe? Recipe { get; set; }
    }
}
