using System.Collections.Generic;

namespace UI.Web.Models
{
    public class InscripcionProfesorViewModel
    {

        public CursoViewModel Curso {get; set;}
        public List<PersonaViewModel> Docentes { get; set; }

        public DocenteCursoViewModel DocenteCurso { get; set; }


    }
}
