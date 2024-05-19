using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Plan : BusinessEntity
    {
        public string Descripcion { get; set; }
        public int EspecialidadId { get; set; }
        public Especialidad Especialidad { get; set; }
        public List<Materia> Materias { get; set; }
        public List<Comision> Comisiones { get; set; }
        public List<Persona> Personas { get; set; }
    }
}
