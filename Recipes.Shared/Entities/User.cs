using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Shared.Entities
{
    public class User
    {
        public int Id { get; set; }

        [Display(Name = "Nombre del usuario")]
        [MaxLength(20)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string? Name { get; set; }

        [Display(Name = "Apellido del usuario")]
        [MaxLength(20)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string? LastName { get; set; }

        [Display(Name = "Correo electronico del usuario")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string? Email { get; set; }

        [Display(Name = "Contraseña del usuario")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "La contraseña debe tener al menos 6 caracteres")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Display(Name = "Imagen")]
        [MaxLength(2000)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string? ImageUrl { get; set; }

        public ICollection<Favorite>? Favorites { get; set; }
        public ICollection<Review>? Reviews { get; set; }
    }
}
