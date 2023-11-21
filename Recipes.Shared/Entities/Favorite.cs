using System.ComponentModel.DataAnnotations;

namespace Recipes.Shared.Entities
{
    public class Favorite
    {
        public int Id { get; set; } = 0;

        public int RecipeId { get; set; } = 0;

        public User? User { get; set; }
        public string? UserId { get; set; }

        [Display(Name = "Fecha")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }
        public Recipe? Recipe { get; set; }
    }
}
