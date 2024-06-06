using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonManager.Domain.Entidades
{
    public class ClienteEntity : UsuarioEntity
    {
        [Required(ErrorMessage = "El apellido es requerido")]
        [MaxLength(30, ErrorMessage = "El apellido no puede tener mas de 30 caracteres")]
        public string Apellido { get; set; }

        public List<TurnoEntity> Turnos { get; set; }
    }

}
