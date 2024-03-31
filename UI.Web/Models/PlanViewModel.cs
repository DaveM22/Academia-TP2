using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace UI.Web.Models
{
    public class PlanViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo Descripción es requerido")]
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }

        [DisplayName("Especialidad")]

        [Required(ErrorMessage = "El campo Especialidad es requerido")]
        public int EspecialidadId { get; set; }

        public string EspecialidadDescripcion { get; set; }

        public List<MateriaModel> Materias { get; set; }

        public List<EspecialidadViewModel> Especialidades { get; set; }

        public MateriaModel Materia { get; set; }
    }
}
