using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Shared.Entities
{
    public class Role
    {
        public int Id { get; set; }

        [Display(Name = "Nombre del rol")]
        [MaxLength(20)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string? Name { get; set; }

        public ICollection<UserRole>? UserRoles { get; set; }
    }
}
