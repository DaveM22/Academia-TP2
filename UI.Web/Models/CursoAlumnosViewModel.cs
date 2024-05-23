using System.Collections.Generic;

namespace UI.Web.Models
{
    public class CursoAlumnosViewModel
    {
        public CursoViewModel Curso { get; set; }

        public List<PersonaViewModel> AlumnoInscriptos { get; set; }
    }
}
