using System.Collections.Generic;

namespace UI.Web.Models
{
    public class AlumnoInscripcionHeadViewModel
    {
        public string Comision {  get; set; }

        public List<AlumnoInscripcionViewModel> AlumnoInscripciones { get; set; }
    }
}
