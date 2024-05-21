using Business.Data;
using Business.Entities;
using Business.Util.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class CursoLogic
    {
        private CursoAdapter CursoAdapter => new();

   
        public List<Curso> GetAll()
        {
            return CursoAdapter.GetAll();
        }

        public List<Curso> GetAllByPlan(int idPlan)
        {
            return CursoAdapter.GetAllByPlan(idPlan);
        }

        public List<Curso> GetAllByPlanYDisponible(int idPlan, int idAlumno)
        {
            return CursoAdapter.GetAllByPlanYDisponibleAlumno(idPlan, idAlumno);
        }

        public Curso GetOne(int id)
        {
            return CursoAdapter.GetOne(id);
        }

        public List<Curso> GetAllByPlandAndMateria(int idPlan, int idMateria)
        {
            return CursoAdapter.GetAllByPlandAndMateria(idPlan, idMateria);
        }

        public List<Curso> GetAllByPlanYDisponibleDocente(int idDocente)
        {
            return CursoAdapter.GetAllByPlanYDisponibleDocente(idDocente);
        }

        public Curso GetOneReporte(int id)
        {
            return CursoAdapter.GetOneReporte(id);
        }

        public Curso Save(Curso cur)
        {
            try
            {                
                return CursoAdapter.Save(cur);
            }
            catch (EntityValidationException)
            {
                throw;
            }
        }

        public void Delete(int id)
        {
            if (CursoAdapter.ExistCursoCF(id))
            {
                throw new DeleteCFReferenciadaException("El curso a borrar ya forma de uno o varias inscriciones y/o asignaciones de profesor y para poder borrar el curso debera borrar todas las entidades vinculadas al curso");
            }
            CursoAdapter.Delete(id);
        }
    }
}
