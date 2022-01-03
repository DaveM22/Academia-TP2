using Business.Data;
using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class CursoLogic
    {
        private CursoAdapter CursoAdapter => new();

        public List<Curso> GetAll()
        {
            return CursoAdapter.GetAll();
        }

        public Curso GetOne(int id)
        {
            return CursoAdapter.GetOne(id);
        }

        public Curso Save(Curso cur)
        {
            return CursoAdapter.Save(cur);
        }

        public void Delete(int id)
        {
            CursoAdapter.Delete(id);
        }
    }
}
