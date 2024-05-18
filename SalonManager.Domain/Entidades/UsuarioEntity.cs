using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace SalonManager.Domain.Entidades
{
    public class UsuarioEntity : PersonaEntity
    {
        [Required]
        [MaxLength(15, ErrorMessage = "El nombre de usuario no puede exceder los 15 caracteres.")]
        public string Usuario { get; set; }

        [Required]
        [MinLength(6, ErrorMessage = "La contraseña debe tener mas de 6 caracteres.")]
        public string Contraseña { get; set; }

        [Required]
        public RolEntity Rol { get; set; }
    }
}
