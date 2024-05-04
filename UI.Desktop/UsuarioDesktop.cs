using Business.Entities;
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
using static UI.Desktop.ApplicationForm;

namespace UI.Desktop
{
    public partial class UsuarioDesktop : Form
    {
        private Usuario Usuario { get; set; }
        private UsuarioLogic UsuarioLogic => new UsuarioLogic();
        private ModoForm ModoForm { get; set; }
        public UsuarioDesktop()
        {
            InitializeComponent();
        }


        public UsuarioDesktop(ModoForm modo) : this()
        {
            this.ModoForm = modo;
        }

        public void Nuevo()
        {
            Usuario = new Usuario();
        }

        public void Editar(int id)
        {
            this.Usuario = this.UsuarioLogic.GetOne(id);
            txtNombreUsuario.TextBox.Text = this.Usuario.NombreUsuario;
            txtNombre.TextBox.Text = this.Usuario.Nombre;
            txtClave.TextBox.Text = this.Usuario.Clave;
            txtEmail.Text = this.Usuario.Email;
            txtPlan.TextBox.Text = this.Usuario.Persona != null ? $"{this.Usuario.Persona.Nombre} - {this.Usuario.Persona.Apellido}" : string.Empty;
        }

        public void Borrar(int id)
        {
            this.Usuario = this.UsuarioLogic.GetOne(id);
            txtNombreUsuario.TextBox.Text = this.Usuario.NombreUsuario;
            txtNombre.TextBox.Text = this.Usuario.Nombre;
            txtClave.TextBox.Text = this.Usuario.Clave;
            txtEmail.Text = this.Usuario.Email;
            txtPlan.TextBox.Text = this.Usuario.Persona != null ? $"{this.Usuario.Persona.Nombre} - {this.Usuario.Persona.Apellido}" : string.Empty;
            txtNombreUsuario.TextBox.Enabled = false;
            txtNombre.TextBox.Enabled = false;
            txtClave.TextBox.Enabled = false;
            txtEmail.Enabled = false;
            txtPlan.TextBox.Enabled = false;
        }
        public UsuarioDesktop(ModoForm modo) : this()
        {

        }

        public UsuarioDesktop(ModoForm modo, int id) : this() 
        { 
        
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
