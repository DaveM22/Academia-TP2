using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class ModuloUsuario
    {
        public int Id { get; set; }

        public int ModuloId { get; set; }

        public int UsuarioId { get; set; }

        public bool Alta { get; set; }

        public bool Modificacion { get; set; }

        public bool Baja { get; set; }

        public bool Consulta { get; set; }

        public Modulo Modulo { get; set; }

        public Usuario Usuario { get; set; }
    }
}
