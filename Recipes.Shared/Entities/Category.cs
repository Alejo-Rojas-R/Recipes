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
        public string CategoryName { get; set; } =null;

        [Display(Name = "Tipo de categoría")]
        [MaxLength(10)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Type { get; set; } =null;

        [Display(Name = "Imagen")]
        [DataType(DataType.ImageUrl)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string ImageUrl { get; set; } =null;
    }
}
