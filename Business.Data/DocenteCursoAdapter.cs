using Business.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Data
{
    public class DocenteCursoAdapter
    {
        public List<DocenteCurso> GetDocenteCursos()
        {
            using var context = new AcademiaContext();
            return context.DocenteCursos
                .Include(x => x.Curso).ThenInclude(x => x.Comision)
                .Include(x => x.Curso).ThenInclude(x => x.Materia)
                .Include(x => x.Docente).ToList();
        }

        public List<DocenteCurso> GetByCurso(int idCurso)
        {
            using var context = new AcademiaContext();
            return context.DocenteCursos
                .Include(x => x.Curso).ThenInclude(x => x.Comision)
                .Include(x => x.Curso).ThenInclude(x => x.Materia)
                .Include(x => x.Docente).Where(x => x.CursoId == idCurso).ToList();
        }

        public DocenteCurso GetOne(int id)
        {
            using var context = new AcademiaContext();
            return context.DocenteCursos
                .Include(x => x.Curso).ThenInclude(x => x.Comision)
                .Include(x => x.Curso).ThenInclude(x => x.Materia)
                .Include(x => x.Docente).Single(x => x.Id == id);
        }

        public DocenteCurso Save(DocenteCurso docenteCurso)
        {
            using var context = new AcademiaContext();
            context.DocenteCursos.Update(docenteCurso);
            context.SaveChanges();
            return docenteCurso;
        }
    }
}
