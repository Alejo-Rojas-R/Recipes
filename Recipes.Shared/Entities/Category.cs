using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Recipes.Shared.Entities
{
    public class Category
    {
        public int Id { get; set; } = 0;

        [Display(Name = "Categoría")]
        [MaxLength(20)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string? Name { get; set; } 

        [Display(Name = "Tipo de categoría")]
        [MaxLength(10)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string? Type { get; set; } 

        [Display(Name = "Imagen")]
        [MaxLength(2000)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string? ImageUrl { get; set; }

        public ICollection<RecipeCategory>? RecipeCategories { get; set; }
    }
}
