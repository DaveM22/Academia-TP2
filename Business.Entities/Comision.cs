﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Comision : BusinessEntity
    {
        public int AnioEspecialidad { get; set; }
        public string Descripcion { get; set; }
        public int PlanId { get; set; }
        public string PlanDescripcion => Plan.Descripcion;
        public Plan Plan { get; set; }
    }
}
