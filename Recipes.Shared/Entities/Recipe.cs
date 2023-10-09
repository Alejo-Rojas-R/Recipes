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
        [MaxLength(2000)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Title { get; set; } =null;

        [Display(Name = "Descripcion de la receta")]
        [MaxLength(10000)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Description { get; set; } =null;

        [Display(Name = "Dificultad de la receta")]
        [Range(1,10, ErrorMessage ="El campo {0} debe estar en el rango de 1 a 10.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public int Difficulty { get; set; }

        [Display(Name = "Fecha")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime date { get; set; }

        [Display(Name = "Imagen")]
        [DataType(DataType.ImageUrl)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string ImageUrl { get; set; } = null;
    }
}
