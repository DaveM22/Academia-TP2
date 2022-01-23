﻿using System.Collections.Generic;
using System.ComponentModel;

namespace UI.Web.Models
{
    public class CursoViewModel
    {
        public int Id { get; set; }
        [DisplayName("Año calendario")]
        public int AnioCalendario { get; set; }
        [DisplayName("Cupo")]
        public int Cupo { get; set; }
        [DisplayName("Comisión")]
        public int ComisionId { get; set; }
        [DisplayName("Materia")]
        public int MateriaId { get; set; }
        [DisplayName("Comisión")]
        public string ComisionDescripcion { get; set; }
        [DisplayName("Materia")]
        public string MateriaDescripcion { get; set; }
        [DisplayName("Comisiones")]
        public List<ComisionViewModel> Comisiones { get; set; }
        [DisplayName("Materias")]
        public List<MateriaViewModel> Materias { get; set; }
    }
}