using Business.Entities;
using Business.Entities.Enums;
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
    public partial class PersonaDesktop : ApplicationForm
    {
        private PersonaLogic PersonaLogic { get; set; }

        private Persona Persona { get; set; }

        private ModoForm Modo { get; set; }

        private TipoPersonaEnum TipoPersonaEnum { get; set; }

        private MasterForm MasterForm => this.MdiParent as MasterForm;

        private int Id { get; set; }

        public PersonaDesktop()
        {
            InitializeComponent();
            this.PersonaLogic = new PersonaLogic();
        }

        public PersonaDesktop(ModoForm modo, TipoPersonaEnum tipoPersonaEnum) : this()
        {
            this.Modo = modo;
            this.TipoPersonaEnum = tipoPersonaEnum;
        }

        public PersonaDesktop(int id, ModoForm modo, TipoPersonaEnum tipoPersonaEnum) : this()
        {
            this.Modo = modo;
            this.TipoPersonaEnum = tipoPersonaEnum;
            this.Id = id;
        }

        private void CargarDatos()
        {
            Persona = PersonaLogic.GetOne(Id);
            nudLegajo.Value = Persona.Legajo;
            txtApellido.TextBox.Text = Persona.Apellido;
            txtNombre.TextBox.Text = Persona.Nombre;
            txtEmail.TextBox.Text = Persona.Email;
            txtTelefono.TextBox.Text = Persona.Telefono;
            txtDireccion.TextBox.Text = Persona.Direccion;
            txtPlan.TextBox.Text = Persona.Plan.Descripcion;
            dtFechaNacimiento.Value = Persona.FechaNacimiento;
        }

        private void PersonaDesktop_Load(object sender, EventArgs e)
        {
            txtPlan.TextBox.ReadOnly = true;
            Persona = new();

            if (Modo == ModoForm.Alta)
            {
                if (TipoPersonaEnum == TipoPersonaEnum.ALUMNO)
                {
                    this.lblTitulo.Text = "Crear alumno";
                }
                else
                {
                    this.lblTitulo.Text = "Crear profesor";
                }
            }
            if (Modo == ModoForm.Modificacion)
            {
                this.CargarDatos();
                if (TipoPersonaEnum == TipoPersonaEnum.ALUMNO)
                {
                    this.lblTitulo.Text = "Editar alumno";
                }
                else
                {
                    this.lblTitulo.Text = "Editar profesor";
                }
            }
            if (Modo == ModoForm.Baja)
            {
                this.CargarDatos();
                nudLegajo.ReadOnly = true;
                txtApellido.TextBox.ReadOnly = true;
                txtDireccion.TextBox.ReadOnly = true;
                txtEmail.TextBox.ReadOnly = true;
                dtFechaNacimiento.Enabled = false;
                txtPlan.TextBox.ReadOnly = true;
                txtTelefono.TextBox.ReadOnly = true;
                btnSeleccionarPlan.Enabled = false;
                if (TipoPersonaEnum == TipoPersonaEnum.ALUMNO)
                {
                    this.lblTitulo.Text = "Borrar alumno";
                }
                else
                {
                    this.lblTitulo.Text = "Borrar profesor";
                }
            }
        }

        private void btnSeleccionarPlan_Click(object sender, EventArgs e)
        {
            var form = new PlanSearchForm();
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                Persona.PlanId = form.PlanObj.Id;
                txtPlan.TextBox.Text = form.PlanObj.Descripcion;
            }
        }

        private void Guardar()
        {
            if (Modo == ModoForm.Alta)
            {
                if (TipoPersonaEnum == TipoPersonaEnum.ALUMNO)
                {
                    Persona.TipoPersona = TipoPersonaEnum.ALUMNO;
                }
                else
                {
                    Persona.TipoPersona = TipoPersonaEnum.PROFESOR;
                }
                MapearDatos();
                this.PersonaLogic.Save(Persona);
            }
            if (Modo == ModoForm.Modificacion)
            {
                if (TipoPersonaEnum == TipoPersonaEnum.ALUMNO)
                {
                    Persona.TipoPersona = TipoPersonaEnum.ALUMNO;
                }
                else
                {
                    Persona.TipoPersona = TipoPersonaEnum.PROFESOR;
                }
                MapearDatos();
                this.PersonaLogic.Save(Persona);
            }
            if (Modo == ModoForm.Baja)
            {
                this.PersonaLogic.Delete(Persona);
            }
            this.MasterForm.OpenForm(new Personas(TipoPersonaEnum));
        }

        private void MapearDatos()
        {
            Persona = Persona ?? new Persona();
            Persona.Legajo = (int)nudLegajo.Value;
            Persona.Apellido = txtApellido.TextBox.Text;
            Persona.Nombre = txtNombre.TextBox.Text;
            Persona.Email = txtEmail.TextBox.Text;
            Persona.FechaNacimiento = dtFechaNacimiento.Value;
            Persona.Direccion = txtDireccion.TextBox.Text;
            Persona.Telefono = txtTelefono.TextBox.Text;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.MasterForm.OpenForm(new Personas(TipoPersonaEnum.ALUMNO));
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.Guardar();
        }
    }
}
