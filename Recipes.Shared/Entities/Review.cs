using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Shared.Entities
{
    public class Review
    {
        public int Id { get; set; }

        [Display(Name = "Comentario acerca de la receta")]
        [MaxLength(1000)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Comment { get; set; } = null;

        [Display(Name = "Que puntaje le das a la receta")]
        [Range(1, 5, ErrorMessage = "El campo {0} debe estar en el rango de 1 a 5.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public int Score { get; set; }

        [Display(Name = "Fecha")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime date { get; set; }

        public int UserId { get; set; }

        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }
        public User User { get; set; }
    }
}
