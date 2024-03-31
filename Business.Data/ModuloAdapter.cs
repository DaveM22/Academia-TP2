using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Data
{
    public class ModuloAdapter
    {

        public List<Modulo> GetModulos()
        {
            using var context = new AcademiaContext();
            return context.Modulos.ToList();
        }
    }
}
