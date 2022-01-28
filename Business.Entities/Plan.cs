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
        public virtual Especialidad Especialidad { get; set; }
        public string EspecialidadDescripcion => Especialidad == null ? "" : Especialidad.Descripcion;
        public List<Materia> Materias { get; set; }
    }
}
