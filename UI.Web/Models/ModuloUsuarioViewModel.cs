using Business.Entities;

namespace UI.Web.Models
{
    public class ModuloUsuarioViewModel
    {
        public int Id { get; set; }

        public int ModuloId { get; set; }

        public int UsuarioId { get; set; }

        public bool Alta { get; set; }

        public bool Modificacion { get; set; }

        public bool Baja { get; set; }

        public bool Consulta { get; set; }

        public string Modulo { get; set; }
    }
}
