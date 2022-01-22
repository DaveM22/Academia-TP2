using System.Collections.Generic;

namespace UI.Web.Models
{
    public class PlanViewModel
    {
        public int Id { get; set; }

        public string Descripcion { get; set; }

        public string EspecialidadDescripcion { get; set; }

        public List<MateriaViewModel> Materias { get; set; }
    }
}
