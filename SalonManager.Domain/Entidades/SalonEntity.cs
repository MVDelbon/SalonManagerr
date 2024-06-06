using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonManager.Domain.Entidades
{
    public class SalonEntity : PersonaEntity
    {
        public List<ClienteEntity> Clientes { get; set; }
    }
}
