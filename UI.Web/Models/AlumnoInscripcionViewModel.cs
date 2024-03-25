using Business.Entities;

namespace UI.Web.Models
{
    public class AlumnoInscripcionViewModel
    {
        public int Id { get; set; }
        public string Condicion { get; set; }
        public int? Nota { get; set; }
        public int AlumnoId { get; set; }
        public int CursoId { get; set; }
        public PersonaViewModel Alumno { get; set; }
        public CursoViewModel Curso { get; set; }
    }
}
