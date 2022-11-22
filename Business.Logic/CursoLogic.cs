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
        private StringBuilder StringBuilder { get; set; }
        private CursoAdapter CursoAdapter => new();

        public CursoLogic()
        {
            StringBuilder = new StringBuilder();
        }


        public List<Curso> GetAll()
        {
            return CursoAdapter.GetAll();
        }

        public List<Curso> GetAllByPlan(int idPlan)
        {
            return CursoAdapter.GetAllByPlan(idPlan);
        }

        public Curso GetOne(int id)
        {
            return CursoAdapter.GetOne(id);
        }

        public Curso Save(Curso cur)
        {
            try
            {
                if(cur.ComisionId == 0)
                {
                    StringBuilder.AppendLine("Se debe seleccionar una comisión");
                }
                if(cur.MateriaId == 0)
                {
                    StringBuilder.AppendLine("Se debe seleccionar una materia");
                }
                if(cur.AnioCalendario == 0)
                {
                    StringBuilder.AppendLine($"Se debe ingresar un año calendario distinto de 0");
                }
                if(cur.Cupo == 0)
                {
                    StringBuilder.AppendLine("Se debe ingresar un curso mayor a 0");
                }
                
                if (StringBuilder.Length > 0)
                {
                    throw new EntityValidationException("Error al guardar datos del curso", StringBuilder);
                }
                
                return CursoAdapter.Save(cur);
            }
            catch (EntityValidationException)
            {
                throw;
            }
        }

        public void Delete(int id)
        {
            CursoAdapter.Delete(id);
        }
    }
}
