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
            if (string.IsNullOrEmpty(plan.Descripcion))
            {
                Errors.AppendLine("El campo es Descripción es obligatorio");
            }

            if(plan.EspecialidadId == 0)
            {
                Errors.AppendLine("Se debe seleccionar una especialidad");
            }

            if(plan.Materias.Any(x => string.IsNullOrWhiteSpace(x.Descripcion)))
            {
                Errors.AppendLine("Todas las masterias del plan deben tener un nombre");
            }

            if(plan.Materias.Any(x => x.HSSemanales == 0))
            {
                Errors.AppendLine("Todas las materias del plan deben tener el campo horas semanales distinto de cero");
            }

            if(plan.Materias.Any(x => x.HSTotales == 0))
            {
                Errors.AppendLine("Todas las materias del plan deben tener el campo horas totales distinto de cero");
            }

            if(Errors.Length > 0)
            {
                throw new EntityValidationException("Error al guardar materia", Errors);
            }

            return PlanAdapter.Save(plan);
        }

        public void Delete(int id)
        {
            PlanAdapter.Delete(id);
        }
    }
}
