using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace UI.Web.Models
{
    public class MateriaModel
    {
        public int Index { get; set; }
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo Descripción es requerido")]
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "El campo Hs semanales es requerido")]
        [DisplayName("Hs semanales")]
        public int HSSemanales { get; set; }
        [Required(ErrorMessage = "El campo Hs totales es requerido")]
        [DisplayName("Hs totales")]
        public int HSTotales { get; set; }
        public int PlanId { get; set; }
        [DisplayName("Plan")]
        public string PlanDescripcion { get; set; }
    }
}
