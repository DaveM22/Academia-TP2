using System.Collections.Generic;
using System.ComponentModel;

namespace UI.Web.Models
{
    public class PlanViewModel
    {
        public int Id { get; set; }

        [DisplayName("Descripción")]
        public string Descripcion { get; set; }

        [DisplayName("Especialidad")]
        public int EspecialidadId { get; set; }

        public string EspecialidadDescripcion { get; set; }

        public List<MateriaViewModel> Materias { get; set; }

        public List<EspecialidadViewModel> Especialidades { get; set; }

        public MateriaViewModel Materia { get; set; }
    }
}
