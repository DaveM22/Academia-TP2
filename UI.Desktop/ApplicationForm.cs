﻿using Business.Entities;
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
    public partial class ApplicationForm : Form
    {
        protected MasterForm Master => (MasterForm)Application.OpenForms["MasterForm"];
        protected UserControl Desktop { get; set; }
        public ApplicationForm()
        {
            InitializeComponent();
        }

        public ModoForm Modo { get; set; }

        protected Usuario UsuarioActual { get; set; }

        public enum ModoForm
        {
            Alta,Baja,Modificacion,Consulta
        }


        public void LoadDesktop(UserControl desktop, EventHandler evento)
        {
            Desktop = desktop;
            Desktop.Dock = DockStyle.Fill;
            Desktop.Disposed += evento;
        }



    }
}
