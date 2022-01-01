using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Data
{
    public class EspecialidadAdapter
    {
        public List<Especialidad> GetAll()
        {
            using var context = new AcademiaContext();
            return context.Especialidades.ToList();
        }

        public Especialidad GetOne(int id)
        {
            using var context = new AcademiaContext();
            return context.Especialidades.Find(id);
        }

        public Especialidad Save(Especialidad esp)
        {
            using var context = new AcademiaContext();
            context.Especialidades.Update(esp);
            context.SaveChanges();
            return esp;
        }

        public void Delete(int id)
        {
            using var context = new AcademiaContext();
            var entity = context.Especialidades.Find(id);
            context.Especialidades.Remove(entity);
            context.SaveChanges();
        }
    }
}
