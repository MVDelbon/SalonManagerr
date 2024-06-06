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
        [Required(ErrorMessage = "El campo ususario es obligatorio.")]
        [MaxLength(15, ErrorMessage = "El nombre de usuario no puede exceder los 15 caracteres.")]
        public string Usuario { get; set; }
   
        [Required(ErrorMessage = "Introduce una contraseña.")]
        [MinLength(8,ErrorMessage = "La contraseña debe tener mas de 6 caracteres.")]
        public string Contraseña { get; set; }

        public int RolId { get; set; }

        public RolEntity Rol { get; set; }
    }
}
