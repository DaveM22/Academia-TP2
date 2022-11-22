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
            try
            {
                if (string.IsNullOrEmpty(com.Descripcion))
                {
                    Errors.AppendLine("El campo descripción es un campo obligatorio");
                }
                if (com.PlanId == 0)
                {
                    Errors.AppendLine("Se debe elegir un plan");
                }
                if(com.AnioEspecialidad == 0)
                {
                    Errors.AppendLine("Se debe elegir un año de especialidad distinto de 0");
                }
                if(Errors.Length > 0)
                {
                    throw new EntityValidationException("Error al guardar datos de la comisión", Errors);
                }
                return ComisionData.Save(com);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void Delete(int id)
        {
            ComisionData.Delete(id);
        }
    }
}
