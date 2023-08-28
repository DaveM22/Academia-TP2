using Business.Entities.Enums;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace UI.Web.Models
{
    public class PersonaViewModel
    {
        public int Id { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }

        [DisplayName("Dirección")]
        public string Direccion { get; set; }

        [DisplayName("Teléfono")]
        public string Telefono { get; set; }

        [DisplayName("E-Mail")]
        public string Email { get; set; }

        public int Legajo { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Fecha de nacimiento")]
        public DateTime FechaNacimiento { get; set; }

        public int PlanId { get; set; }

        public TipoPersonaEnum TipoPersona { get; set; }
    }
}
