﻿using Business.Entities;
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
            return context.Materias.Include(x => x.Plan).Where(x => x.PlanId == idPlan).ToList();
        }

        public List<Materia> GetAll()
        {
            using var context = new AcademiaContext();
            return context.Materias.AsNoTracking().Include(x => x.Plan).ToList();
        }

        public Materia GetOne(int id)
        {
            using var context = new AcademiaContext();
            return context.Materias.AsNoTracking().Include(x => x.Plan).Single(x => x.Id == id);
        }

        public void Delete(int id)
        {
            using var context = new AcademiaContext();
            var materia = context.Materias.Single(x => x.Id == id);
            context.Materias.Remove(materia);
            context.SaveChanges();
        }

        public void Guardar(Materia materia)
        {
            using var context = new AcademiaContext();
            context.Update(materia);
            context.SaveChanges();
        }

        public List<Materia> MateriasPlanAlumno(int idAlumno, int idPlan)
        {
            using var context = new AcademiaContext();
            var inscripciones = context.AlumnoInscripciones.Include(x => x.Curso).ThenInclude(x => x.Materia).Where(x => x.AlumnoId == idAlumno).Select(x => x.Curso.MateriaId).Distinct().ToList();
            var materias = context.Materias.Where(x => !inscripciones.Contains(x.Id) && x.PlanId == idPlan).ToList();
            return materias;
        }


        public bool ExistMateriaCF(int materiaId)
        {
            using var context = new AcademiaContext();
            return context.Materias.Any(x => x.Id == materiaId && x.Cursos.Any());
        }
    }
}
