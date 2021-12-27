using Business.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Data
{
    public class UsuarioAdapter : Adapter<Usuario>
    {

        public override List<Usuario> GetAll()
        {
            using var context = new AcademiaContext();
            return context.Usuarios.Include(x => x.Persona).ToList();
        }

        public override Usuario GetOneByString(string nombreUsuario)
        {
            using var context = new AcademiaContext();
            return context.Usuarios.SingleOrDefault(x => x.NombreUsuario == nombreUsuario);
        }

    }
}
