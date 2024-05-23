using System.Collections.Generic;

namespace UI.Web.Models
{
    public class AlumnoMateriaViewModel
    {

        public PersonaViewModel Persona { get; set; }   

        public List<MateriaModel> MateriasDisponibles { get; set; }


        public string MateriaTitulo { get; set; }

        public List<CursoViewModel> CursosDisponibles { get; set; }
    }
}
