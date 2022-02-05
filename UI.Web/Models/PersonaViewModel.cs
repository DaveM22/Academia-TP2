using Business.Util;
using System;
using System.ComponentModel.DataAnnotations;

namespace UI.Web.Models
{
    public class PersonaViewModel
    {
        public int Id { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }

        public string Direccion { get; set; }

        public string Telefono { get; set; }

        public string Email { get; set; }

        public int Legajo { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }

        public int PlanId { get; set; }

        public TipoPersonaEnum TipoPersona { get; set; }
    }
}
