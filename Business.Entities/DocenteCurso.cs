using Business.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class DocenteCurso : BusinessEntity
    {
        public int CursoId { get; set; }
        public int DocenteId { get; set; }
        public DocenteCargoEnum DocenteCargo { get; set; }
        public Curso Curso { get; set; }
        public Persona Docente { get; set; }
    }
}
