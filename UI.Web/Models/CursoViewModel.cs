using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace UI.Web.Models
{
    public class CursoViewModel
    {
        public int Id { get; set; }
        [DisplayName("Año calendario")]
        public int AnioCalendario { get; set; }
        [DisplayName("Cupo")]
        public int Cupo { get; set; }
        [Required(ErrorMessage = "El campo comisión es requerido, debe seleccionar una comisión")]
        [DisplayName("Comisión")]
        public int? ComisionId { get; set; }
        [Required(ErrorMessage = "El campo materia es requerido, debe seleccionar una materia")]
        [DisplayName("Materia")]
        public int? MateriaId { get; set; }

        public MateriaModel Materia { get; set; }

        public ComisionViewModel Comision { get; set; } 
        [DisplayName("Comisión")]
        [Required]
        public string ComisionDescripcion { get; set; }
        [DisplayName("Materia")]
        [Required]
        public string MateriaDescripcion { get; set; }
        [DisplayName("Comisiones")]
        public List<ComisionViewModel> Comisiones { get; set; }

        [DisplayName("Materias")]
        public List<MateriaModel> Materias { get; set; }

        public List<DocenteCursoViewModel> DocenteCursos { get; set; }
    }
}
