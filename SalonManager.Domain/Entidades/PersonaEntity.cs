using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonManager.Domain.Entidades
{
    public class PersonaEntity : BaseEntity
    {
        public PersonaEntity(string nombre, string direccion, string email, string telefono)
        {
            //TODO agregar validaciones a estas propiedades
            //TODO Ver excepciones personalizadas
            Nombre = nombre;
            Direccion = direccion;
            Email = email;
            Telefono = telefono;
        }

        [Required(ErrorMessage = "El nombre es requerido")]
        [MaxLength(30, ErrorMessage = "El nombre no puede tener mas de 30 caracteres")]
        public string Nombre { get; protected set; }

        public string Direccion { get; protected set; }


        [Required(ErrorMessage = "El email es requerido")]
        [EmailAddress(ErrorMessage = "Email invalido")]
        public string Email { get; protected set; }

        [Required(ErrorMessage = "El telefono es requerido")]
        public string Telefono { get; protected set; }

        public UsuarioEntity Usuario { get; protected set; }
    }
}
