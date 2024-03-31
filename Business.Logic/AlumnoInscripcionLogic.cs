using Business.Data;
using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class AlumnoInscripcionLogic
    {
        AlumnoInscripcionAdapter adapter => new();

        public List<AlumnoInscripcion> GetAll(int personaId)
        {
            return adapter.GetAll(personaId);
        }

        public AlumnoInscripcion GetOne(int inscripcionId)
        {
            return adapter.GetOne(inscripcionId);
        }

        public List<AlumnoInscripcion> GetAllByCurso(int cursoId)
        {
            return adapter.GetAllByCurso(cursoId);
        }

        public void Save(AlumnoInscripcion insc) 
        { 
            adapter.Save(insc);
        }
    }
}
