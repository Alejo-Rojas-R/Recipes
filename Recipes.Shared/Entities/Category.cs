﻿using System.ComponentModel.DataAnnotations;

namespace Recipes.Shared.Entities
{
    public class Category
    {
        public int Id { get; set; } = 0;

        [Display(Name = "Categoría")]
        [MaxLength(50)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string? Name { get; set; }

        [Display(Name = "Tipo de categoría")]
        [MaxLength(10)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string? Type { get; set; }

        [Display(Name = "Imagen")]
        [MaxLength(2000)]
        public string? ImageUrl { get; set; }

        public ICollection<RecipeCategory>? RecipeCategories { get; set; }
    }
}
