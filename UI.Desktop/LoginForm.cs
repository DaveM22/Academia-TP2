﻿using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class formLogin : ApplicationForm
    {
        private UsuarioLogic UsuarioLogic { get; set; }
        public bool LoginCorrecto { get; set; }

        public Usuario UsuarioLogin { get; set; }
        public formLogin()
        {
            InitializeComponent();
            UsuarioLogic = new UsuarioLogic();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                var user = UsuarioLogic.GetOne(txtUsuario.Text, txtClave.Text);
                Program.Usuario = user;
                Program.IsLoggin = true;
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al identificar el usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
