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

        public void Delete(int id)
        {
            using var context = new AcademiaContext();
            var entity = context.Comisiones.Find(id);
            context.Comisiones.Remove(entity);
            context.SaveChanges();
        }
    }
}
