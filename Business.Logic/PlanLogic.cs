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
        private PlanAdapter PlanAdapter;

        public PlanLogic()
        {
            PlanAdapter = new PlanAdapter();
        }

        public List<Plan> GetAll()
        {
            return PlanAdapter.GetAll();
        }
    }
}
