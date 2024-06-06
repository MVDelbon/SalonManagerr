using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace SalonManager.Domain.Entidades
{
    public class RolEntity : BaseEntity
    {
        [Required(ErrorMessage = "El tipo de rol es requerido")]
        public string Tipo { get; set; }

        public string Descripcion { get; set; }
    }
}
