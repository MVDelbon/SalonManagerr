using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonManager.Domain.Entidades
{
    public class SalonEntity : PersonaEntity
    {
        public SalonEntity(string nombre, string direccion, string email, string telefono) : base(nombre, direccion, email, telefono)
        {
        }

        public List<ClienteEntity> Clientes { get; set; }
    }
}
