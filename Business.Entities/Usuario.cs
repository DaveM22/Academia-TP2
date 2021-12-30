using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Usuario : BusinessEntity
    {
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }
        public int? PersonaId { get; set; }
        public Persona Persona { get; set; }
        public string Nombre => Persona.Nombre;
        public string Apellido => Persona.Apellido;
        public string Email => Persona.Email;
    }
}
