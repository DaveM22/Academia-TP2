using Business.Entities;
using Business.Logic;
using Business.Util.ValidatorsDesktop;
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
    public partial class UsuarioDesktop : ApplicationForm
    {
        private Usuario Usuario { get; set; }
        private UsuarioLogic UsuarioLogic => new UsuarioLogic();
        private ModoForm ModoForm { get; set; }
        private UsuarioValidator UsuarioValidator => new UsuarioValidator();
        private MasterForm MasterForm => this.MdiParent as MasterForm;
        public UsuarioDesktop()
        {
            InitializeComponent();
        }



        public void Nuevo()
        {
            Usuario = new Usuario();
        }

        public UsuarioDesktop(ModoForm modo) : this()
        {
            this.Usuario = new();
            lblTitulo.Text = "Crear usuario";
        }

        public UsuarioDesktop(ModoForm modo, int id) : this()
        {
            this.Usuario = UsuarioLogic.GetOne(id);
            txtNombreUsuario.TextBox.Text = this.Usuario.NombreUsuario;
            txtNombre.TextBox.Text = this.Usuario.Nombre;
            txtApellido.TextBox.Text = this.Usuario.Apellido;
            txtClave.TextBox.Text = this.Usuario.Clave;
            txtEmail.Text = this.Usuario.Email;
            cbHabilitado.Checked = this.Usuario.Habilitado;
            txtPlan.TextBox.Text = this.Usuario.Persona != null ? $"{this.Usuario.Persona.Apellido} {this.Usuario.Persona.Nombre}" : string.Empty;
            if (ModoForm == ModoForm.Modificacion)
            {
                lblTitulo.Text = "Editar usuario";
            }
            else
            {
                lblTitulo.Text = "Borrar usuario";
            }
        }

        public void Editar(int id)
        {
            this.Usuario = this.UsuarioLogic.GetOne(id);
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


        private void btnGuardar_Click(object sender, EventArgs e)
        {

            string mensajeAlerta;
            if (Modo == ModoForm.Alta)
            {
                mensajeAlerta = "¿Desea confirmar la creación del usuario?";
            }
            else
            {
                mensajeAlerta = "¿Desea guardar los cambios del usuario?";
            }
            this.MapearDatos();
            DialogResult result = MessageBox.Show(mensajeAlerta, "Confirmar cambios", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {

                var resultValidation = UsuarioValidator.Validate(this.Usuario);
                if (resultValidation.IsValid)
                {
                    MapearDatos();
                    UsuarioLogic.Save(this.Usuario);
                    if (Modo == ModoForm.Alta)
                    {
                        niUsuario.ShowBalloonTip(1000, "Crear usuario", $"Se ha creado el usuario correctamente", ToolTipIcon.Info);

                    }
                    else
                    {
                        niUsuario.ShowBalloonTip(1000, "Editar usuario", $"Se han guardado los cambios del usuario correctamente", ToolTipIcon.Info);
                    }
                    this.MasterForm.OpenForm(new Usuarios());
                }
                else
                {
                    foreach (var error in resultValidation.Errors)
                    {
                        if (error.PropertyName == nameof(Usuario.Nombre))
                        {
                            this.txtNombre.LabelError.Text = error.ErrorMessage;
                        }

                        if (error.PropertyName == nameof(Usuario.Apellido))
                        {
                            this.txtApellido.LabelError.Text = error.ErrorMessage;
                        }

                        if (error.PropertyName == nameof(Usuario.NombreUsuario))
                        {
                            this.txtNombreUsuario.LabelError.Text = error.ErrorMessage;
                        }

                        if (error.PropertyName == nameof(Usuario.Clave))
                        {
                            this.txtClave.LabelError.Text = error.ErrorMessage;
                        }
                    }
                }
            }
        }

        public void MapearDatos()
        {
            Usuario.Nombre = txtNombreUsuario.TextBox.Text;
            Usuario.Apellido = txtApellido.TextBox.Text;
            Usuario.Email = txtEmail.Text;
            Usuario.Clave = txtClave.TextBox.Text;
            Usuario.Habilitado = cbHabilitado.Checked;
            Usuario.NombreUsuario = txtNombreUsuario.TextBox.Text;
        }

        private void btnPlan_Click_1(object sender, EventArgs e)
        {
            var personaForm = new PersonaSearchForm();
            var result = personaForm.ShowDialog();
            if(result == DialogResult.OK)
            {
                txtPlan.TextBox.Text = string.Format("{0} {1}", personaForm.Persona.Apellido, personaForm.Persona.Nombre);
                this.Usuario.Persona = personaForm.Persona;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.MasterForm.OpenForm(new Usuarios());
        }
    }
}
