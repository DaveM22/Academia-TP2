using Business.Entities;

namespace UI.Web.Models
{
    public class UsuarioViewModel
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }
        public int? PersonaId { get; set; }
        public bool Habilitado { get; set; }
        public string Telefono { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
    }
}
