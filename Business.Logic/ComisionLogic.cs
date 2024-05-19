using Business.Data;
using Business.Entities;
using Business.Util.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class ComisionLogic
    {
        private StringBuilder Errors { get; set; }
        private ComisionAdapter ComisionData => new();

        public ComisionLogic()
        {
            Errors = new StringBuilder();
        }


        public List<Comision> GetAll()
        {
            return ComisionData.GetAll();
        }

        public List<Comision> GetAllByPlan(int planId)
        {
            return ComisionData.GetAllByPlan(planId);
        }

        public Comision GetOne(int id)
        {
            return ComisionData.GetOne(id);
        }

        public Comision Save(Comision com)
        {
            return ComisionData.Save(com);
        }

        public void Delete(int id)
        {
            if (ComisionData.ExistComisionCF(id))
            {
                throw new DeleteCFReferenciadaException("La comisión a borrar ya forma de uno o varios cursos, para poder borrar la comisión debera borrar todos los cursos vinculados a la comisión");
            }
            ComisionData.Delete(id);
        }
    }
}
