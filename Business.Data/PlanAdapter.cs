using Business.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Data
{
    public class PlanAdapter
    {
        public List<Plan> GetAll()
        {
            using var context = new AcademiaContext();
            return context.Planes.Include(x => x.Especialidad).Include(x => x.Materias).ToList();
        }

        public Plan GetOne(int id)
        {
            using var context = new AcademiaContext();
            return context.Planes.Include(x => x.Especialidad).Include(x => x.Materias).FirstOrDefault(x => x.Id == id);
        }

        public Plan Save(Plan plan)
        {
            using var context = new AcademiaContext();
            context.Planes.Update(plan);
            context.SaveChanges();
            return plan;
        }

        public void Delete(int id)
        {
            using var context = new AcademiaContext();
            var entity = context.Planes.Find(id);
            context.Planes.Remove(entity);
            context.SaveChanges();
        }

        public bool ExistsEspecialidadEnAlgunPlan(int idEspecialidad)
        {
            using var context = new AcademiaContext();
            return context.Planes.Any(x => x.EspecialidadId == idEspecialidad);
        }

        public List<Plan> PlanesByEspecialidad(int idEspecialidad)
        {
            using var context = new AcademiaContext();
            return context.Planes.Where(x => x.EspecialidadId == idEspecialidad).ToList();
        }
    }
}
