using System.ComponentModel.DataAnnotations;

namespace UI.Web.Models
{
    public class EspecialidadViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo Descripción no puede estar vacio")]
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }
    }
}
