using System.ComponentModel.DataAnnotations;
using SalonManager.Domain.Enums;

namespace SalonManager.Domain.Entidades
{
    public class TurnoEntity : BaseEntity
    {
        //TODO Borrar este comentario
        // hola, soy un constructor :S
        public TurnoEntity(DateTime fechaTurno, int idCliente)
        {
            FechaRegsitro = DateTime.Now;
            FechaModificacion = DateTime.Now;
            Estado = EstadosTurnoEnum.Reservado;

            if (fechaTurno < DateTime.Now)
            {
                throw new Exception("Fecha de turno invalida");
            }
            if (idCliente < 1)
            {
                throw new Exception("IdCliente menor que 1");
            }

            Fecha = fechaTurno;
            ClienteId = idCliente;
        }

        public void Reprogramar(DateTime fechaReprogramada)
        {
            if (fechaReprogramada >= DateTime.Now)
            {
                Fecha = fechaReprogramada;
            }
            else
            {
                throw new Exception("Fecha de turno invalida");
            }

            Estado = EstadosTurnoEnum.Reprogramado;
            FechaModificacion = DateTime.Now;
        }
        //TODO Hacer lo mismo que en finalizar pero en los demas metodos
        public void Cancelar()
        {
            Estado = EstadosTurnoEnum.Cancelado;
            FechaModificacion = DateTime.Now;
        }

        public void Finalizar(int Precio, string Descripcion)
        {
            Estado = EstadosTurnoEnum.Realizado;
            FechaModificacion = DateTime.Now;

            if (Precio < 0)
            {
                throw new Exception("Cobra boluda");
            }
            if (string.IsNullOrWhiteSpace(Descripcion))
            {
                throw new Exception("La descripcion esta vacia");
            }


            this.Precio = Precio;
            this.Descripcion = Descripcion;
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
