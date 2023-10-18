using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Shared.Entities
{
    public class Favorite
    {
        public int Id { get; set; } = 0;

        public int UserId { get; set; } = 0;

        public int RecipeId { get; set; } = 0;

        [Display (Name="Fecha")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }
        public Recipe? Recipe { get; set; }
        public User? User { get; set; }
    }
}
