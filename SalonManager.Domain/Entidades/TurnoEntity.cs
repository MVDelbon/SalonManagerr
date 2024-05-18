using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonManager.Domain.Entidades
{
    public class TurnoEntity : BaseEntity
    {
        [Required]
        public string Descripcion { get; set; }
        public int  Precio { get; set; }
        public DateTime Fecha { get; set; }
    }
}
