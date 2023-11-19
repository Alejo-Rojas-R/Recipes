using System.ComponentModel.DataAnnotations;

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
        [DataType(DataType.MultilineText)]
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
        public string? ImageUrl { get; set; }

        [Display(Name = "Tiempo aproximado")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public int? Time { get; set; }

        [Display(Name = "Porciones")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public int? Portions { get; set; }

        public User? User { get; set; }

        public ICollection<RecipeCategory>? RecipeCategories { get; set; }
        public ICollection<IngredientRecipe>? IngredientRecipe { get; set; }
        public ICollection<Review>? Reviews { get; set; }
        public ICollection<Step>? Steps { get; set; }
        public ICollection<Favorite>? Favorites { get; set; }
    }
}
