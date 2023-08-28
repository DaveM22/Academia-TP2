using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace UI.Web.Models
{
    public class UsuarioLoginViewModel
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Nombre de usuario")]
        public string NombreUsuario { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Clave { get; set; }
    }
}
