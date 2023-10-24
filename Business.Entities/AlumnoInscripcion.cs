using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class AlumnoInscripcion : BusinessEntity
    {
        public string Condicion { get; set; }
        public int? Nota { get; set; }
        public int AlumnoId { get; set; }
        public int CursoId { get; set; }
        public Persona Alumno { get; set; }
        public Curso Curso { get; set; }
    }
}
