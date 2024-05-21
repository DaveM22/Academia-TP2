using Business.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business.Data
{
    public class AlumnoInscripcionAdapter
    {
        public List<AlumnoInscripcion> GetAll(int personaId)
        {
            using var context = new AcademiaContext();
            return context.AlumnoInscripciones.Include(x => x.Alumno)
                .Include(x => x.Curso).ThenInclude(x => x.Comision)
                .Include(x => x.Curso).ThenInclude(x => x.Materia).Where(x => x.AlumnoId == personaId).ToList();
        }

        public AlumnoInscripcion GetOne(int inscripcionId)
        {
            using var context = new AcademiaContext();
            return context.AlumnoInscripciones.Include(x => x.Alumno)
                .Include(x => x.Curso).ThenInclude(x => x.Comision)
                .Include(x => x.Curso).ThenInclude(x => x.Materia).FirstOrDefault(x => x.Id == inscripcionId);
        }

        public List<AlumnoInscripcion> GetAllByCurso(int cursoId)
        {
            using var context = new AcademiaContext();
            return context.AlumnoInscripciones.Include(x => x.Alumno)
                .Include(x => x.Curso).ThenInclude(x => x.Comision)
                .Include(x => x.Curso).ThenInclude(x => x.Materia).Where(x => x.CursoId == cursoId).ToList();
        }

        public List<AlumnoInscripcion> GetByAlumno(int alumnoId)
        {
            using var context = new AcademiaContext();
            return context.AlumnoInscripciones.Include(x => x.Alumno)
                .Include(x => x.Curso).ThenInclude(x => x.Materia).Where(x => x.AlumnoId == alumnoId).ToList();
        }

        public void Borrar(int idInscripcion)
        {
            try
            {
                using var context = new AcademiaContext();
                context.Database.BeginTransaction();
                var inscripcion = context.AlumnoInscripciones.Where(x => x.Id == idInscripcion).SingleOrDefault();
                context.AlumnoInscripciones.Remove(inscripcion);
                var curso = context.Cursos.Where(x => x.Id == inscripcion.CursoId).SingleOrDefault();
                curso.Cupo += 1;
                context.SaveChanges();
                context.Database.CommitTransaction();
            }
            catch
            {
                var context = Adapter.dbContext;
                context.Database.RollbackTransaction();
            }
        }

        public void Save(AlumnoInscripcion insc)
        {
            using var context = new AcademiaContext(); ;
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {

                    context.AlumnoInscripciones.Update(insc);
                    var curso = context.Cursos.Single(x => x.Id == insc.CursoId);
                    curso.Cupo -= 1;
                    context.Cursos.Update(curso);
                    context.SaveChanges();
                    context.Database.CommitTransaction();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw;
                }
            }

        }
    }
}
