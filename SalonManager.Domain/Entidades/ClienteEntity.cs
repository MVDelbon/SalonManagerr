using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonManager.Domain.Entidades
{
    public class ClienteEntity : UsuarioEntity
    {
        public string Apellido { get; set; }
        public List<TurnoEntity> Turnos { get; set; }
    }

}
