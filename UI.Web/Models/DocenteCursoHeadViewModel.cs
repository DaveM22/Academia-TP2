using System.Collections.Generic;

namespace UI.Web.Models
{

    public class DocenteCursoHeadViewModel
    {

        public PersonaViewModel Docente { get; set; }

        public List<DocenteCursoViewModel> DocenteCursos { get; set;}
    }
}
