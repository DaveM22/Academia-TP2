using Business.Data;
using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class PlanLogic
    {
        private PlanAdapter PlanAdapter => new();

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
            PlanAdapter.Delete(id);
        }
    }
}
