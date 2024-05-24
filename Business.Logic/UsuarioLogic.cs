﻿using Business.Data;
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


        public Usuario GetOne(string nombreUsario, string clave)
        {
            List<string> errors = new List<string>();
            var usuario = UsuarioAdapter.GetByCredenciales(nombreUsario, clave);
            if (usuario == null)
            {
                throw new Exception("No existe el cliente con el nombre de usuario ingresado");
            }
            else
            {
                if(usuario.Clave != clave)
                {
                    throw new Exception("La clave ingresada es incorrecta");
                }
            }
            return usuario;
        }

        public Usuario Save(Usuario usuario)
        {
            return this.UsuarioAdapter.Save(usuario);
        }

        public Usuario GetByCredenciales(string nombreUsuario, string clave)
        {
            var usuario = this.UsuarioAdapter.GetByCredenciales(nombreUsuario, clave);
            if (usuario == null)
            {
                throw new Exception("El usuario ingresado no existe");
            }
            if (usuario.Clave != clave)
            {
                throw new Exception("La contraseña es incorrecta");
            }
            return usuario;
        }
        public Usuario GetOne(int id)
        {
            return this.UsuarioAdapter.GetOne(id);
        }
    }
}
