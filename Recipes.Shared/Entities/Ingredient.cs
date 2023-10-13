using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Recipes.Shared.Entities
{
    public class Ingredient
    {
        public int Id { get; set; }

        [Display(Name = "Nombre del ingrediente")]
        [MaxLength(20)]
        [Required (ErrorMessage ="El campo {0} es obligatorio")]
        public string IngredientName { get; set; } =null;

        [Display(Name = "Descripcion")]
        [MaxLength(1000)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Description { get; set; } =null;

        [Display(Name = "Imagen")]
        [MaxLength(2000)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string ImageUrl { get; set; } =null;
        public ICollection<Step> Steps { get; set; }

    }
}
