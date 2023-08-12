using Business.Data;
using Business.Entities;
using Business.Util.Dto;
using Business.Util.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class EspecialidadLogic
    {
        private StringBuilder Errors { get; set; }
        public EspecialidadAdapter EspecialidadData { get; }
        public PlanAdapter PlanData { get; set; }
        public EspecialidadLogic()
        {
            EspecialidadData = new EspecialidadAdapter();
            PlanData = new PlanAdapter();
            Errors = new StringBuilder();
        }

        public List<Especialidad> GetAll()
        {
            return EspecialidadData.GetAll();
        }

        public Especialidad GetOne(int id)
        {
            return EspecialidadData.GetOne(id);
        }

        public Especialidad Save(Especialidad esp)
        {

  
            return EspecialidadData.Save(esp);
        }

        public void Delete(int id)
        {
            if (PlanData.ExistsEspecialidadEnAlgunPlan(id))
            {
                throw new DeleteCFReferenciadaException("La especialidad ingresada ya forma parte de un plan, borré todos sus planes vinculados e intente nuevamente");
            }
            EspecialidadData.Delete(id);
        }
    }
}
