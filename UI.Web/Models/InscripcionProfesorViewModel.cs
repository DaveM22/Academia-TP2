
using Business.Entities.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UI.Web.Models
{
    public class InscripcionProfesorViewModel
    {
        public int Id { get; set; }
        public int CursoId { get; set; }
        [Required(ErrorMessage = "El campo Profesor es requerido, debe seleccionar uno")]
        public int? DocenteId { get; set; }
        public CursoViewModel Curso { get; set; }
        [Required(ErrorMessage = "El campo Cargo es requerido, debe seleccionar uno")]
        public DocenteCargoEnum DocenteCargo { get; set; }
        public PersonaViewModel Docente { get; set; }
    }
}
