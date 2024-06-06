using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalonManager.Domain.Enums;

namespace SalonManager.Domain.Entidades
{
    public class TurnoEntity : BaseEntity
    {
        public string Descripcion { get; set; }

        [Range(0, Int32.MaxValue)]
        public int  Precio { get; set; }

        public DateTime Fecha { get; set; }

        public int ClienteId { get; set; }

        public ClienteEntity Cliente { get; set; }

        public EstadosTurnoEnum Estado;

    }
}
