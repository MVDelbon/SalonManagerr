using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonManager.Domain.Entidades
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public DateTime FechaRegsitro { get; set; }

        public DateTime FechaModificacion { get; set; }

        public bool Eliminado { get; set; }
    }
}
