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

        public List<AlumnoInscripcion> GetAll()
        {
            return adapter.GetAll();
        }
    }
}
