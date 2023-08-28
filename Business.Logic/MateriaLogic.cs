using Business.Data;
using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class MateriaLogic
    {
        private MateriaAdapter MateriaData => new();

        public List<Materia> GetAllByPlan(int idPlan)
        {
            return MateriaData.GetAllByPlan(idPlan);
        }

        public List<Materia> GetAll()
        {
            return MateriaData.GetAll();
        }

        public Materia GetOne(int id)
        {
            return MateriaData.GetOne(id);
        }

        public void Borrar(int id)
        {
            MateriaData.Delete(id);
        }

        public void Guardar(Materia materia)
        {
            MateriaData.Guardar(materia);
        }
    }
}
