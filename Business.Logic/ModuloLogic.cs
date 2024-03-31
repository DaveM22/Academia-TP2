using Business.Data;
using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class ModuloLogic
    {
        private ModuloAdapter ModuloAdapter { get; set; }

        public List<Modulo> GetModulos()
        {
            return ModuloAdapter.GetModulos();
        }
    }
}
