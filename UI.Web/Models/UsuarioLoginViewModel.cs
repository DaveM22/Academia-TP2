using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace UI.Web.Models
{
    public class UsuarioLoginViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe ingresar un nombre de usuario")]
        [DisplayName("Nombre de usuario")]
        public string NombreUsuario { get; set; }

        [Required(ErrorMessage = "Debe ingresar una clave")]
        [DataType(DataType.Password)]
        public string Clave { get; set; }
    }
}
