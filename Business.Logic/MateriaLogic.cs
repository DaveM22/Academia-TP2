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
    }
}
