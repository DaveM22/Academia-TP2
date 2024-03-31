﻿using Business.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void Save(AlumnoInscripcion insc)
        {
            using var context = new AcademiaContext();
            context.AlumnoInscripciones.Update(insc);
            context.SaveChanges();
        }
    }
}
