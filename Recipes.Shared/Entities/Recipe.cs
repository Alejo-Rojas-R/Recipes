using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Shared.Entities
{
    public class Recipe
    {
        public int Id { get; set; }

        [Display(Name = "Titulo de la receta")]
        [MaxLength(200)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string? Title { get; set; }

        [Display(Name = "Descripcion de la receta")]
        [MaxLength(1000)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string? Description { get; set; }

        [Display(Name = "Dificultad de la receta")]
        [MaxLength(15)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string? Difficulty { get; set; }

        [Display(Name = "Fecha")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }

        [Display(Name = "Imagen")]
        [MaxLength(2000)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string? ImageUrl { get; set; }

        public ICollection<RecipeCategory>? RecipeCategories { get; set; }
        public ICollection<Review>? Reviews { get; set; }
        public ICollection<Step>? Steps { get; set; }
        public ICollection<Favorite>? Favorites { get; set; }
    }
}
