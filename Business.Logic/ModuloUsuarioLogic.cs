using Business.Data;
using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public class ModuloUsuarioLogic
    {

        public ModuloUsuarioAdapter ModuloUsuarioData  => new ModuloUsuarioAdapter();

        public List<ModuloUsuario> GetModuloByUsuario(int usuarioId)
        {
            return ModuloUsuarioData.GetModulosByUsuario(usuarioId);
        }
    }
}
