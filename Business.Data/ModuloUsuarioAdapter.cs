using Business.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Data
{
    public class ModuloUsuarioAdapter
    {

        public List<ModuloUsuario> GetModulosByUsuario(int idUsuario)
        {
            using var context = new AcademiaContext();
            return context.ModuloUsuarios.Include(x => x.Modulo).Where(x => x.UsuarioId == idUsuario).ToList();
        }
    }
}
