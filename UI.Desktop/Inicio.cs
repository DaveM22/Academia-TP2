using Business.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class Inicio : ApplicationForm
    {


        public Inicio()
        {
            InitializeComponent();
        }

        private MasterForm MasterForm => this.MdiParent as MasterForm;

        private void btnEspecialidades_Click(object sender, EventArgs e)
        {


            this.MasterForm.OpenForm(new Especialidades());
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

            this.btnEspecialidades.Visible = this.MasterForm.Autorizacion.Contains("Especialidades");
            this.btnPlanes.Visible = this.MasterForm.Autorizacion.Contains("Planes");
            this.btnProfesores.Visible = this.MasterForm.Autorizacion.Contains("Profesores");
            this.btnComisiones.Visible = this.MasterForm.Autorizacion.Contains("Comisiones");
            this.btnAlumnos.Visible = this.MasterForm.Autorizacion.Contains("Alumnos");
            this.btnUsuarios.Visible = this.MasterForm.Autorizacion.Contains("Usuarios");
            this.btnCursos.Visible = this.MasterForm.Autorizacion.Contains("Cursos");
            this.btnCatedras.Visible = this.MasterForm.Autorizacion.Contains("AlumnoMaterias");
            this.btnInscribirse.Visible = this.MasterForm.Autorizacion.Contains("AlumnosMateriasInscripcion");
        }

        private void btnPlanes_Click(object sender, EventArgs e)
        {
            this.MasterForm.OpenForm(new Planes());
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            this.MasterForm.OpenForm(new Cursos());
        }

        private void btnComisiones_Click(object sender, EventArgs e)
        {
            this.MasterForm.OpenForm(new Comisiones());
        }

        private void btnProfesores_Click(object sender, EventArgs e)
        {
            this.MasterForm.OpenForm(new Personas(TipoPersonaEnum.PROFESOR));
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            this.MasterForm.OpenForm(new Personas(TipoPersonaEnum.ALUMNO));
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            this.MasterForm.OpenForm(new Usuarios());
        }

        private void btnInscribirse_Click(object sender, EventArgs e)
        {
            this.MasterForm.OpenForm(new MateriasAlumno(this.MasterForm.UsuarioActual.PersonaId.Value, this.MasterForm.UsuarioActual.Persona.Plan.Id));
        }

        private void btnCatedras_Click(object sender, EventArgs e)
        {
            this.MasterForm.OpenForm(new AlumnoInscripciones(this.MasterForm.UsuarioActual.PersonaId.Value));
        }
    }
}
