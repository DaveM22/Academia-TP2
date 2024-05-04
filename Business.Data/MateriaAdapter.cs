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
            var context = Adapter.dbContext;
            return context.Materias.Include(x => x.Plan).AsNoTracking().Where(x => x.PlanId == idPlan).ToList();
        }

        public List<Materia> GetAll()
        {
            var context = Adapter.dbContext;
            return context.Materias.Include(x => x.Plan).ToList();
        }

        public Materia GetOne(int id)
        {
            var context = Adapter.dbContext;
            return context.Materias.AsNoTracking().Include(x => x.Plan).Single(x => x.Id == id);
        }

        public void Delete(int id)
        {
            var context = Adapter.dbContext;
            var materia = context.Materias.Single(x => x.Id == id);
            context.Materias.Remove(materia);
            context.SaveChanges();
        }

        public void Guardar(Materia materia)
        {
            var context = Adapter.dbContext;
            context.Update(materia);
            context.SaveChanges();
        }

        public List<Materia> MateriasPlanAlumno(int idAlumno, int idPlan)
        {
            var context = Adapter.dbContext;
            var inscripciones = context.AlumnoInscripciones.Include(x => x.Curso).ThenInclude(x => x.Materia).Where(x => x.AlumnoId == idAlumno).Select(x => x.Curso.MateriaId).Distinct().ToList();
            var materias = context.Materias.Where(x => !inscripciones.Contains(x.Id) && x.PlanId == idPlan).ToList();
            return materias;
        }
    }
}
