using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Shared.Entities
{
    public class Step
    {
        public int Id { get; set; }

        public int RecipeId { get; set; }

        public int IngredientId { get; set; }

        [Display(Name = "Cantidad de ingredientes de la receta")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public int Quantity { get; set; } = 0;

        [Display(Name = "Descripcion del paso a paso de la receta")]
        [MaxLength(1000)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Description { get; set; } = null;

        [Display(Name = "Imagen")]
        [MaxLength(2000)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string ImageUrl { get; set; } = null;
    }
}
