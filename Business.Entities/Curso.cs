﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Curso : BusinessEntity
    {
        public int AnioCalendario { get; set; }
        public int Cupo { get; set; }
        public int ComisionId { get; set; }
        public int MateriaId { get; set; }
        public string ComisionDescripcion => Comision.Descripcion;
        public string MateriaDescripcion => Materia.Descripcion;
        public Comision Comision { get; set; }
        public Materia Materia { get; set; }
    }
}
