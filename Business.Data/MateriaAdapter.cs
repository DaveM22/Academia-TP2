using Business.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Data
{
    public class MateriaAdapter
    {
        public List<Materia> GetAllByPlan(int idPlan)
        {
            using var context = new AcademiaContext();
            return context.Materias.Where(x => x.PlanId == idPlan).ToList();
        }

        public List<Materia> GetAll()
        {
            using var context = new AcademiaContext();
            return context.Materias.Include(x => x.Plan).ToList();
        }
    }
}
