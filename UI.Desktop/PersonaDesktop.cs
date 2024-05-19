using Business.Entities;
using Business.Entities.Enums;
using Business.Logic;
using Business.Util.Exceptions;
using Business.Util.ValidatorsDesktop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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

        private string TipoPersonaString { get; set; }

        private TipoPersonaEnum TipoPersonaEnum { get; set; }

        private MasterForm MasterForm => this.MdiParent as MasterForm;

        private PersonaValidator PersonaValidator => new PersonaValidator();

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
                txtNombre.TextBox.ReadOnly = true;
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

        private void Eliminar()
        {
            string tipoPersona;
            if (TipoPersonaEnum == TipoPersonaEnum.ALUMNO)
            {
                tipoPersona = "alumno";
            }
            else
            {
                tipoPersona = "profesor";
            }
            DialogResult result = MessageBox.Show($"¿Desea borrar el {tipoPersona}?", $"Borrar {tipoPersona}", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                try
                {
                    this.PersonaLogic.Delete(Persona);
                    notifyIcon1.ShowBalloonTip(1000, $"Borrar {tipoPersona}", $"Se ha borrado el {tipoPersona} correctamente", ToolTipIcon.Info);
                    MasterForm.OpenForm(new Planes());
                }
                catch (DeleteCFReferenciadaException ex)
                {
                    notifyIcon1.ShowBalloonTip(1000, $"Borrar {tipoPersona}", ex.Message, ToolTipIcon.Error);
                }
            }
        }


        private void Guardar()
        {
            string tipoPersona;
            if (TipoPersonaEnum == TipoPersonaEnum.ALUMNO)
            {
                tipoPersona = "alumno";
            }
            else
            {
                tipoPersona = "profesor";
            }
            string mensajeAlerta;
            if (Modo == ModoForm.Alta)
            {
                mensajeAlerta = $"¿Desea confirmar la creación del {tipoPersona}?";
            }
            else
            {
                mensajeAlerta = $"¿Desea guardar los cambios del {tipoPersona}?";
            }

            DialogResult result = MessageBox.Show(mensajeAlerta, "Confirmar cambios", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {

                var resultValidation = PersonaValidator.Validate(this.Persona);
                if (resultValidation.IsValid)
                {
                    MapearDatos();
                    Persona.TipoPersona = this.TipoPersonaEnum;

                    PersonaLogic.Save(this.Persona);
                    if (Modo == ModoForm.Alta)
                    {
                        if (TipoPersonaEnum == TipoPersonaEnum.ALUMNO)
                        {
                            notifyIcon1.ShowBalloonTip(1000, "Crear alumno", $"Se ha creado el alumno correctamente", ToolTipIcon.Info);
                        }
                        else
                        {
                            notifyIcon1.ShowBalloonTip(1000, "Crear profesor", $"Se ha creado el profesor correctamente", ToolTipIcon.Info);
                        }

                    }
                    else
                    {
                        if (TipoPersonaEnum == TipoPersonaEnum.ALUMNO)
                        {
                            notifyIcon1.ShowBalloonTip(1000, "Editar especialidad", $"Se han guardado los cambios del alumno correctamente", ToolTipIcon.Info);
                        }
                        else
                        {
                            notifyIcon1.ShowBalloonTip(1000, "Editar especialidad", $"Se han guardado los del profesor correctamente", ToolTipIcon.Info);
                        }

                    }
                    this.MasterForm.OpenForm(new Personas(TipoPersonaEnum));
                    this.Close();
                }
                else
                {
                    foreach (var error in resultValidation.Errors)
                    {
                        if (error.PropertyName == nameof(Persona.Nombre))
                        {
                            this.txtNombre.LabelError.Text = error.ErrorMessage;
                        }

                        if (error.PropertyName == nameof(Persona.Apellido))
                        {
                            this.txtApellido.LabelError.Text = error.ErrorMessage;
                        }

                        if (error.PropertyName == nameof(Persona.PlanId))
                        {
                            this.txtPlan.LabelError.Text = error.ErrorMessage;
                        }
                    }
                }
            }




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
            switch (Modo)
            {
                case ModoForm.Modificacion:
                case ModoForm.Alta:
                    Guardar();
                    break;
                case ModoForm.Baja:
                    Eliminar();
                    break;
            }
        }
    }
}
