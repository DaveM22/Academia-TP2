using Business.Util;
using System;

namespace Business.Entities
{
    public class Persona
    {
        public int Id { get; set; }
        public string Apellido { get; set; }

        public string Direccion { get; set; }

        public string Nombre { get; set; }

        public string Telefono { get; set; }

        public int Legajo { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public int PlanId { get; set; }

        public TipoPersonaEnum TipoPersona { get; set; }

        public Usuario Usuario { get; set; }

        public Plan Plan { get; set; }
    }
}
