using Business.Entities;
using Business.Entities.Enums;

namespace UI.Web.Models
{
    public class DocenteCursoViewModel
    {
        public int Id { get; set; }
        public int CursoId { get; set; }
        public int DocenteId { get; set; }
        public DocenteCargoEnum DocenteCargo { get; set; }
        public PersonaViewModel Docente { get; set; }
    }
}
