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
            var context = Adapter.dbContext;
            return context.Comisiones.Include(x => x.Plan).ToList();
        }

        public List<Comision> GetAllByPlan(int planId)
        {
            var context = Adapter.dbContext;
            return context.Comisiones.Include(x => x.Plan).AsNoTracking().Where(x => x.PlanId == planId).ToList();
        }

        public Comision GetOne(int id)
        {
            var context = Adapter.dbContext;
            return context.Comisiones.Include(x => x.Plan).FirstOrDefault(x => x.Id == id);
        }

        public Comision Save(Comision com)
        {
            var context = Adapter.dbContext;
            context.Comisiones.Update(com);
            context.SaveChanges();
            return com;
        }

        public void Delete(int id)
        {
            var context = Adapter.dbContext;
            var entity = context.Comisiones.Find(id);
            context.Comisiones.Remove(entity);
            context.SaveChanges();
        }
    }
}
