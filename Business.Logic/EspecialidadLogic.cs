using Business.Data;
using Business.Entities;
using Business.Util.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class EspecialidadLogic
    {
        public EspecialidadAdapter EspecialidadData { get; }
        public EspecialidadLogic()
        {
            EspecialidadData = new EspecialidadAdapter();
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
            return EspecialidadData.Save(esp);
        }

        public void Delete(int id)
        {
            EspecialidadData.Delete(id);
        }
    }
}
