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

        public Curso GetOneReporte(int id)
        {
            using var context = new AcademiaContext();
            return context.Cursos
                .Include(x => x.DocenteCursos)
                .Include(x => x.Inscriptos)
                .ThenInclude(x => x.Alumno)
                .Include(x => x.Materia)
                .ThenInclude(x => x.Plan)
                .ThenInclude(x => x.Especialidad)
                .Include(x => x.Comision).SingleOrDefault(x => x.Id == id);
        }


        public List<Curso> GetAll()
        {
            using var context = new AcademiaContext();
            return context.Cursos.AsNoTracking().Include(x => x.Materia).Include(x => x.Comision).ToList();
        }

        public List<Curso> GetAllByPlan(int idPlan)
        {
            using var context = new AcademiaContext();
            return context.Cursos.Include(x => x.Materia).Include(x => x.Comision).Where(x => x.Comision.PlanId == idPlan && x.Cupo > 0).ToList();
        }

        public List<Curso> GetAllByPlandAndMateria(int idPlan, int idMateria)
        {
            using var context = new AcademiaContext();
            return context.Cursos.Include(x => x.Materia).Include(x => x.Comision).Where(x => x.Comision.PlanId == idPlan && x.MateriaId == idMateria && x.Cupo > 0).ToList();
        }

        public Curso GetOne(int id)
        {
            using var context = new AcademiaContext();
            return context.Cursos.Include(x => x.Comision).Include(x => x.Materia).Include(x => x.DocenteCursos).ThenInclude(x => x.Docente).Include(x => x.Materia).ThenInclude(x => x.Plan).SingleOrDefault(x => x.Id == id);
        }

        public Curso Save(Curso cur)
        {
            using var context = new AcademiaContext();
            context.ChangeTracker.Clear();
            if (cur.Id == 0)
            {
                context.Cursos.Add(cur);
            }
            else
            {
                context.Cursos.Update(cur);
            }

            context.SaveChanges();
            return cur;
        }

        public void Delete(int id)
        {
            using var context = new AcademiaContext(); ;
            var entity = context.Cursos.Find(id);
            context.Cursos.Remove(entity);
            context.SaveChanges();
        }


        public bool ExistCursoCF(int cursoId)
        {
            using var context = new AcademiaContext();
            return context.Cursos.Any(x => x.Id == cursoId && (x.DocenteCursos.Any() || x.Inscriptos.Any()));
        }
    }
}
