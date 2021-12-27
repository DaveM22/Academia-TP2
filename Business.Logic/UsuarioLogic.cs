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
    public class UsuarioLogic
    {
        private UsuarioAdapter UsuarioAdapter { get; }

        public UsuarioLogic()
        {
            UsuarioAdapter = new();
        }

        public List<Usuario> GetAll()
        {
            return UsuarioAdapter.GetAll();
        }

        public UsuarioDto GetOne(string nombreUsario, string clave)
        {
            List<string> errors = new List<string>();
            var usuario = UsuarioAdapter.GetOneByString(nombreUsario);
            if (usuario == null)
                errors.Add("No existe el cliente con el nombre de usuario ingresado");
            else
            {
                if(usuario.Clave != clave)
                {
                    errors.Add("La clave ingresada es incorrecta");
                }
            }
            return new UsuarioDto() { Id = usuario.Id, NombreUsuario = usuario.NombreUsuario };
        }
    }
}
