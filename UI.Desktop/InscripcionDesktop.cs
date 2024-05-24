using Business.Logic;
using Business.Util;
using Business.Util.Extensiones;
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

namespace UI.Desktop
{
    public partial class InscripcionDesktop : ApplicationForm
    {
        public AlumnoInscripcionLogic AlumnoInscripcionLogic => new AlumnoInscripcionLogic();
        private bool ActualizarNota { get; set; }
        private Business.Entities.AlumnoInscripcion AlumnoInscripcion { get; set; }
        private bool EditarInscripcionAdmin { get; set; }
        private MasterForm MasterForm => this.MdiParent as MasterForm;
        public InscripcionDesktop()
        {
            InitializeComponent();
        }



        public InscripcionDesktop(int id, bool actualizarNota, bool editarInscripcionAdmin = false) : this()
        {
            this.EditarInscripcionAdmin = editarInscripcionAdmin;
            if (!editarInscripcionAdmin)
            {
                this.AlumnoInscripcion = this.AlumnoInscripcionLogic.GetOne(id);
                this.ActualizarNota = actualizarNota;
                this.txtComision.Text = this.AlumnoInscripcion.Curso.Comision.Descripcion;
                this.txtMateria.Text = this.AlumnoInscripcion.Curso.Materia.Descripcion;
                this.txtApellido.Text = this.AlumnoInscripcion.Alumno.Apellido;
                this.txtNombre.Text = this.AlumnoInscripcion.Alumno.Nombre;
                this.txtLegajo.Text = this.AlumnoInscripcion.Alumno.Legajo.ToString();
                this.cbEstado.ValueMember = "Value";
                this.cbEstado.DataSource = new CondicionEnum[] { CondicionEnum.INSCRIPTO, CondicionEnum.REGULAR };

                this.cbEstado.SelectedItem = EnumExtension.GetEnumValueFromDescription<CondicionEnum>(this.AlumnoInscripcion.Condicion);
                if (ActualizarNota)
                {
                    this.lblTitulo.Text = "Actualizar nota";
                    this.cbEstado.Enabled = false;
                }
                else
                {
                    this.lblTitulo.Text = "Actualizar condición";
                    this.nudNota.Enabled = false;
                }
            }
            else
            {
                this.lblTitulo.Text = "Actualizar inscripción";
                this.AlumnoInscripcion = this.AlumnoInscripcionLogic.GetOne(id);
                this.txtComision.Text = this.AlumnoInscripcion.Curso.Comision.Descripcion;
                this.txtMateria.Text = this.AlumnoInscripcion.Curso.Materia.Descripcion;
                this.txtApellido.Text = this.AlumnoInscripcion.Alumno.Apellido;
                this.txtNombre.Text = this.AlumnoInscripcion.Alumno.Nombre;
                this.txtLegajo.Text = this.AlumnoInscripcion.Alumno.Legajo.ToString();
                this.nudNota.Value = this.AlumnoInscripcion.Nota.HasValue? this.AlumnoInscripcion.Nota.Value : 0;
                this.cbEstado.ValueMember = "Value";
                this.cbEstado.DataSource = new CondicionEnum[] { CondicionEnum.INSCRIPTO, CondicionEnum.REGULAR, CondicionEnum.LIBRE, CondicionEnum.APROBADO };
                this.cbEstado.SelectedIndex = this.cbEstado.FindStringExact(this.AlumnoInscripcion.Condicion);
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!EditarInscripcionAdmin) 
            {
                if (this.ActualizarNota)
                {
                    this.AlumnoInscripcion.Nota = (int)nudNota.Value;
                    var validator = new AlumnoInscripcionValidator();
                    var result = validator.Validate(this.AlumnoInscripcion);
                    if (result.IsValid)
                    {
                        this.AlumnoInscripcionLogic.Save(this.AlumnoInscripcion);
                        niAsignarNota.ShowBalloonTip(1000, "Actualizar condición", $"Se ha actualizado la condición del alumno correctamente", ToolTipIcon.Info);
                        this.MasterForm.OpenForm(new CursoAlumnos(this.AlumnoInscripcion.CursoId));
                    }
                    else
                    {
                        this.AlumnoInscripcion.Condicion = CondicionEnum.APROBADO.ToString();
                        var errorMessage = result.Errors.Single(x => x.PropertyName == "Nota").ErrorMessage;
                        niAsignarNota.ShowBalloonTip(1000, "Actualizar nota", errorMessage, ToolTipIcon.Info);
                    }
                }
                else
                {
                    this.AlumnoInscripcion.Condicion = this.cbEstado.SelectedValue.ToString();
                    this.AlumnoInscripcionLogic.Save(this.AlumnoInscripcion);
                    niAsignarNota.ShowBalloonTip(1000, "Actualizar condición", $"Se ha actualizado la condición del alumno correctamente", ToolTipIcon.Info);
                    this.MasterForm.OpenForm(new CursoAlumnos(this.AlumnoInscripcion.CursoId));
                }
            }
            else
            {
                this.AlumnoInscripcion.Nota = (int)nudNota.Value;
                this.AlumnoInscripcion.Condicion = this.cbEstado.SelectedValue.ToString();
                this.AlumnoInscripcionLogic.Save(this.AlumnoInscripcion);
                niAsignarNota.ShowBalloonTip(1000, "Actualizar condición", $"Se ha actualizado la condición del alumno correctamente", ToolTipIcon.Info);
                this.MasterForm.OpenForm(new AlumnoInscripciones(this.AlumnoInscripcion.AlumnoId));
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (EditarInscripcionAdmin)
            {
                this.MasterForm.OpenForm(new AlumnoInscripciones(this.AlumnoInscripcion.AlumnoId));
            }
            else
            {
                this.MasterForm.OpenForm(new CursoAlumnos(this.AlumnoInscripcion.CursoId));
            }

        }
    }
}
