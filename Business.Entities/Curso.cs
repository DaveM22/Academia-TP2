using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Curso : BusinessEntity
    {
        public string Descripcion { get; set; }
        public int AnioCalendario { get; set; }
        public int Cupo { get; set; }
        public int ComisionId { get; set; }
        public int MateriaId { get; set; }
        public Comision Comision { get; set; }
        public Materia Materia { get; set; }
    }
}
