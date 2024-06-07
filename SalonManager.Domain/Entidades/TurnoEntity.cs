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
        // hola, soy un constructor :S
        public TurnoEntity(DateTime fechaTurno, int idCliente)
        {
            FechaRegsitro = DateTime.Now;
            FechaModificacion = DateTime.Now;
            Estado = EstadosTurnoEnum.Reservado;

            if (fechaTurno >= DateTime.Now)
            {
                Fecha = fechaTurno;
            }
            else
            {
                throw new Exception("Fecha de turno invalida");
            }

            if (idCliente < 1)
            {
                throw new Exception("IdCliente menor que 1");
            }
            else
            {
                ClienteId = idCliente;
            }

        }
        public string Descripcion { get; private set; }

        [Range(0, Int32.MaxValue)]
        public int Precio { get; private set; }

        public DateTime Fecha { get; private set; }

        public int ClienteId { get; private set; }

        public ClienteEntity Cliente { get; private set; }

        public EstadosTurnoEnum Estado { get; private set; }

    }
}
