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
        public bool Habilitado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }

        public List<ModuloUsuario> Modulos { get; set; }
    }
}
