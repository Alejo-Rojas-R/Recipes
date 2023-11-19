using Microsoft.AspNetCore.Identity;
using Recipes.Shared.Enums;
using System.ComponentModel.DataAnnotations;

namespace Recipes.Shared.Entities
{
    public class User : IdentityUser
    {
        [Display(Name = "Nombre del usuario")]
        [MaxLength(20)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string? Name { get; set; }

        [Display(Name = "Apellido del usuario")]
        [MaxLength(20)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string? LastName { get; set; }

        [Display(Name = "Imagen")]
        [MaxLength(2000)]
        public string? ImageUrl { get; set; }

        [Display(Name = "Tipo de usuario")]
        public UserType UserType { get; set; }

        [Display(Name = "Usuario")]
        public string FullName => $"{Name} {LastName}";

        public ICollection<Favorite>? Favorites { get; set; }
        public ICollection<Review>? Reviews { get; set; }
        public ICollection<Recipe>? Recipes { get; set; }
        //public ICollection<UserRole>? UserRoles { get; set; }
    }
}
