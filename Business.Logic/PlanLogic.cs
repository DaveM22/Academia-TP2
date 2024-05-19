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
    public class PlanLogic
    {
        private StringBuilder Errors { get; set; }
        private PlanAdapter PlanAdapter => new();


        public PlanLogic()
        {
            Errors = new StringBuilder();
        }

        public List<Plan> GetAll()
        {
            return PlanAdapter.GetAll();
        }

        public Plan GetOne(int id)
        {
            return PlanAdapter.GetOne(id);  
        }

        public Plan Save(Plan plan)
        {
         
            return PlanAdapter.Save(plan);
        }

        public void Delete(int id)
        {
            if (PlanAdapter.ExistPlanCF(id))
            {
                throw new DeleteCFReferenciadaException("El plan a borrar ya forma de alguna comisión, materia o persona para poder borrar el plan debera borrar todas las entidades vinculadas al plan");
            }
            PlanAdapter.Delete(id);
        }

        public List<Plan> PlanesByEspecialidad(int idEspecialidad)
        {
            return PlanAdapter.PlanesByEspecialidad(idEspecialidad);
        }
    }
}
