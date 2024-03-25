using Business.Data;
using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class DocenteCursoLogic
    {

        private readonly DocenteCursoAdapter _docenteCursoData;


        public DocenteCursoLogic()
        {
            _docenteCursoData = new DocenteCursoAdapter();
        }

        public List<DocenteCurso> DocenteCursoByCurso(int cursoId)
        {
            return _docenteCursoData.GetByCurso(cursoId);
        }

        public List<DocenteCurso> GetDocenteCursos()
        {
            return _docenteCursoData.GetDocenteCursos();
        }


        public List<DocenteCurso> GetDocenteCursos(int profesorId)
        {
            return _docenteCursoData.GetDocenteCursos(profesorId);
        }

        public DocenteCurso GetOne(int id)
        {
            return _docenteCursoData.GetOne(id);
        }

        public DocenteCurso Save(DocenteCurso docenteCurso)
        {
            return _docenteCursoData.Save(docenteCurso);
        }
    }
}
