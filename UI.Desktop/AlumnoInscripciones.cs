using Accord.Controls;
using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class AlumnoInscripciones : ApplicationForm
    {
        private int AlumnoId { get; set; }
        public AlumnoInscripcionLogic AlumnoInscripcionLogic => new AlumnoInscripcionLogic();

        public PersonaLogic PersonaLogic => new PersonaLogic();
        private MasterForm MasterForm => this.MdiParent as MasterForm;

        private Persona Alumno { get; set; }
        public AlumnoInscripciones()
        {
            InitializeComponent();
        }

        public AlumnoInscripciones(int alumnoId) : this()
        {
            this.AlumnoId = alumnoId;
        }

        private void AlumnoInscripciones_Load(object sender, EventArgs e)
        {
            this.dgvAlumnoInscripciones.AutoGenerateColumns = false;
            this.dgvAlumnoInscripciones.AllowNestedProperties(true);
            this.dgvAlumnoInscripciones.DataSource = AlumnoInscripcionLogic.GetAll(this.AlumnoId);
            this.Alumno = this.PersonaLogic.GetOne(this.AlumnoId);

            this.lblAlumno.Text = $"{Alumno.Legajo} - {Alumno.Apellido} {Alumno.Nombre}";
            this.lblPlan.Text = $"{Alumno.Plan.Descripcion}";

            this.tsNuevaAsignacion.Visible = !this.MasterForm.Autorizacion.Contains("AlumnoInscripcionAlumno");
        }

        private void dgvAlumnoInscripciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAlumnoInscripciones.CurrentCell.OwningColumn.Name == "Borrar")
            {
                Business.Entities.AlumnoInscripcion inscripcion = dgvAlumnoInscripciones.SelectedRows[0].DataBoundItem as Business.Entities.AlumnoInscripcion;
                var result = MessageBox.Show("¿Desea borrar la siguiente inscripción?", "Borrar inscripción", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if(result == DialogResult.OK)
                {
                    AlumnoInscripcionLogic.Borrar(inscripcion.Id);
                    this.niAlumnosIncripcion.ShowBalloonTip(1000, "Eliminar descripción", "Se ha eliminado la inscripción del alumno", ToolTipIcon.Info);
                    this.dgvAlumnoInscripciones.DataSource = this.AlumnoInscripcionLogic.GetAll(this.AlumnoId);
                }
            }
            else if (dgvAlumnoInscripciones.CurrentCell.OwningColumn.Name == "Editar")
            {
                Business.Entities.AlumnoInscripcion inscripcion = dgvAlumnoInscripciones.SelectedRows[0].DataBoundItem as Business.Entities.AlumnoInscripcion;
                var form = new InscripcionDesktop(inscripcion.Id, false, true);
                this.MasterForm.OpenForm(form);
            }
        }

        private void tlpInscripciones_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tsNuevaAsignacion_Click(object sender, EventArgs e)
        {
            var form = new AsignarCursoAlumnoForm(this.Alumno.Id, this.Alumno.PlanId);
            this.MasterForm.OpenForm(form);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.MasterForm.OpenForm(new Inscripciones());
        }

        private void tsCargaMasiva_Click(object sender, EventArgs e)
        {

        }
    }
}
