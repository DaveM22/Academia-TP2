using Business.Data;
using Business.Entities;
using Business.Util.Dto;
using Business.Util.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class EspecialidadLogic
    {
        private StringBuilder Errors { get; set; }
        public EspecialidadAdapter EspecialidadData { get; }
        public EspecialidadLogic()
        {
            EspecialidadData = new EspecialidadAdapter();
            Errors = new StringBuilder();
        }

        public List<Especialidad> GetAll()
        {
            return EspecialidadData.GetAll();
        }

        public Especialidad GetOne(int id)
        {
            return EspecialidadData.GetOne(id);
        }

        public Especialidad Save(Especialidad esp)
        {
            if (string.IsNullOrEmpty(esp.Descripcion))
            {
                Errors.AppendLine("El campo descripción es obligatorio");
            }
            try
            {
                if (Errors.Length > 0)
                {
                    throw new EntityValidationException("Error al guardar especialidad", Errors);
                }
                return EspecialidadData.Save(esp);
            }
            catch (EntityValidationException)
            {
                throw;
            }
        }

        public void Delete(int id)
        {
            EspecialidadData.Delete(id);
        }
    }
}
