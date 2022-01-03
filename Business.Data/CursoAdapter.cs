﻿using Business.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Data
{
    public class CursoAdapter
    {
        public List<Curso> GetAll()
        {
            using var context = new AcademiaContext();
            return context.Cursos.Include(x => x.Materia).Include(x => x.Comision).ToList();
        }

        public Curso GetOne(int id)
        {
            using var context = new AcademiaContext();
            return context.Cursos.Find(id);
        }

        public Curso Save(Curso cur)
        {
            using var context = new AcademiaContext();
            context.Update(cur);
            context.SaveChanges();
            return cur;
        }

        public void Delete(int id)
        {
            using var context = new AcademiaContext();
            var entity = context.Cursos.Find(id);
            context.Cursos.Remove(entity);
            context.SaveChanges();
        }
    }
}