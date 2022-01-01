using Business.Data;
using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class ComisionLogic
    {
        private ComisionAdapter ComisionData => new();

        public List<Comision> GetAll()
        {
            return ComisionData.GetAll();
        }

        public Comision GetOne(int id)
        {
            return ComisionData.GetOne(id);
        }

        public Comision Save(Comision com)
        {
            return ComisionData.Save(com);
        }

        public void Delete(int id)
        {
            ComisionData.Delete(id);
        }
    }
}
