using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace UI.Web.Models
{
    public class ComisionViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo Año especialidad es requerido")]
        [DisplayName("Año especialidad")]
        [Range(1, 3000, ErrorMessage = "El campo Año especialidad no puede ser menor a cero ni mayor a 3000")]
        public int AnioEspecialidad { get; set; }
        [Required(ErrorMessage = "El campo Descripcion es requerido")]
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        [DisplayName("Plan")]
        [Required(ErrorMessage = "El campo plan es requerido, debe seleccionar uno")]
        public int? PlanId { get; set; }
        [DisplayName("Plan")]
        public string PlanDescripcion { get; set; }
    }
}
