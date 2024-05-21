using Business.Entities;
using Business.Logic;
using Business.Util;
using Business.Util.Extensiones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI.Desktop
{
    public partial class AsignarCursoAlumnoForm : ApplicationForm
    {
        private MasterForm MasterForm => this.MdiParent as MasterForm;

        private AlumnoInscripcionLogic AlumnoInscripcionLogic => new AlumnoInscripcionLogic();
        private PersonaLogic PersonaLogic => new PersonaLogic();

        private int PersonaId { get; set; }
        private int PlanId { get; set; }
        private Curso Curso { get; set; }

        private Persona Alumno { get; set; }
        public AsignarCursoAlumnoForm()
        {
            InitializeComponent();
        }

        public AsignarCursoAlumnoForm(int personaId, int planId) : this()
        {
            this.PersonaId = personaId;
            this.PlanId = planId;
        }

        private void btnSeleccionarCurso_Click(object sender, EventArgs e)
        {
            var curso = new CursosSearchForm(this.PlanId, this.PersonaId);
            var form = curso.ShowDialog();
            if (form == DialogResult.OK)
            {
                this.textBoxConValidacion1.TextBox.Text = string.Format("{0} - {1}", curso.Curso.Comision.Descripcion, curso.Curso.Materia.Descripcion);
                this.Curso = curso.Curso;
            }
        }

        private void AsignarCursoAlumnoForm_Load(object sender, EventArgs e)
        {
            this.Alumno = this.PersonaLogic.GetOne(this.PersonaId);
            this.txtAlumno.Text = $"{this.Alumno.Legajo} - {this.Alumno.Apellido}  {this.Alumno.Nombre}";
            this.cbCondicion.DataSource = Enum.GetValues(typeof(CondicionEnum));
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.MasterForm.OpenForm(new AlumnoInscripciones(this.PersonaId));
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            var alumnoInscripcion = new Business.Entities.AlumnoInscripcion() { AlumnoId = PersonaId, CursoId = this.Curso.Id, Condicion = ((CondicionEnum)this.cbCondicion.SelectedValue).ToDescriptionString() };
            this.AlumnoInscripcionLogic.Save(alumnoInscripcion);
            notifyIcon1.ShowBalloonTip(1000, "Asignar alumno", $"Se ha asignado al alumno al curso: {this.Curso.Comision.Descripcion} - {this.Curso.Materia.Descripcion}", ToolTipIcon.Info);
            this.MasterForm.OpenForm(new AlumnoInscripciones(this.PersonaId));
        }
    }
}
