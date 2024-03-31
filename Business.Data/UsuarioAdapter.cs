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
            return context.Usuarios.Include(x => x.Persona).Include(x => x.Modulos).ThenInclude(x => x.Modulo).ToList();
        }

        public override Usuario GetOneByString(string nombreUsuario)
        {
            using var context = new AcademiaContext();
            return context.Usuarios.SingleOrDefault(x => x.NombreUsuario == nombreUsuario);
        }

        public Usuario GetOne(int id)
        {
            using var context = new AcademiaContext();
            return context.Usuarios.Include(x => x.Persona).SingleOrDefault(x => x.Id == id);
        }

        public Usuario GetByCredenciales(string nombreUsuario, string clave)
        {
            using var context = new AcademiaContext();
            return context.Usuarios.Include(x => x.Persona).Include(x => x.Modulos).ThenInclude(x => x.Modulo).SingleOrDefault(x => x.NombreUsuario == nombreUsuario && x.Clave == clave);
        }

        public override Usuario Save(Usuario entity)
        {
            using var context = new AcademiaContext();
            context.Usuarios.Update(entity);
            context.SaveChanges();
            return entity;
        }
    }
}
