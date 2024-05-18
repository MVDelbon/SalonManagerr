using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace SalonManager.Domain.Entidades
{
    public class RolEntity : BaseEntity
    {
        public string Tipo { get; set; }
        public string Descripcion { get; set; }
    }
}
