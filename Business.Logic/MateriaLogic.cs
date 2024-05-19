using Business.Data;
using Business.Entities;
using Business.Util.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class MateriaLogic
    {
        private MateriaAdapter MateriaData => new();

        public List<Materia> GetAllByPlan(int idPlan)
        {
            return MateriaData.GetAllByPlan(idPlan);
        }

        public List<Materia> GetAll()
        {
            return MateriaData.GetAll();
        }

        public Materia GetOne(int id)
        {
            return MateriaData.GetOne(id);
        }

        public void Borrar(int id)
        {
            if(MateriaData.ExistMateriaCF(id))
            {
                throw new DeleteCFReferenciadaException("La materia esta vinculada a uno o mas cursos. Debera borrar los cursos vinculado primero para poder borarla");
            }
            MateriaData.Delete(id);
        }

        public void Guardar(Materia materia)
        {
            MateriaData.Guardar(materia);
        }

        public List<Materia> MateriaAlumno(int alumnoId, int planId)
        {
            return MateriaData.MateriasPlanAlumno(alumnoId, planId);
        }
    }
}
