using Business.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Data
{
    public class ComisionAdapter
    {
        public List<Comision> GetAll()
        {
            using var context = new AcademiaContext();
            return context.Comisiones.Include(x => x.Plan).ToList();
        }

        public List<Comision> GetAllByPlan(int planId)
        {
            using var context = new AcademiaContext();
            return context.Comisiones.Include(x => x.Plan).AsNoTracking().Where(x => x.PlanId == planId).ToList();
        }

        public Comision GetOne(int id)
        {
            using var context = new AcademiaContext();
            return context.Comisiones.Include(x => x.Plan).FirstOrDefault(x => x.Id == id);
        }

        public Comision Save(Comision com)
        {
            using var context = new AcademiaContext();
            context.Comisiones.Update(com);
            context.SaveChanges();
            return com;
        }


        public bool ExistComisionCF(int comisionId)
        {
            using var context = new AcademiaContext();
            return context.Comisiones.Any(x => x.Id == comisionId && x.Cursos.Any());
        }

        public void Delete(int id)
        {
            using var context = new AcademiaContext();
            var entity = context.Comisiones.Find(id);
            context.Comisiones.Remove(entity);
            context.SaveChanges();
        }
    }
}
