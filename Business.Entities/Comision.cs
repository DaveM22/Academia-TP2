using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Comision
    {
        public int Id { get; set; }
        public int AnioEspecialidad { get; set; }
        public string Descripcion { get; set; }
        public int PlanId { get; set; }
        public  Plan Plan { get; set; }
        public List<Curso> Cursos { get; set; }
    }
}
