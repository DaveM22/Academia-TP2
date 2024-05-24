using Accord.Controls;
using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class CursoAlumnos : ApplicationForm
    {
        public CursoLogic CursoLogic => new CursoLogic();
        private List<Business.Entities.AlumnoInscripcion> Inscripciones { get; set; }
        private Curso Curso { get; set; }

        private MasterForm MasterForm => this.MdiParent as MasterForm;
        public CursoAlumnos()
        {
            InitializeComponent();
            this.dgvCursoAlumnos.AllowNestedProperties(true);
            this.dgvCursoAlumnos.AutoGenerateColumns = false;
        }

        public CursoAlumnos(int cursoId) : this()
        {
            this.Curso = CursoLogic.GetOne(cursoId);
            this.lblTitulo.Text = $"Alumnos de la comision: {Curso.Comision.Descripcion} - Materia: {Curso.Materia.Descripcion}";
            Inscripciones = this.Curso.Inscriptos;
        }

        private void CursoAlumnos_Load(object sender, EventArgs e)
        {
            this.dgvCursoAlumnos.DataSource = Inscripciones;
        }

        private void dgvCursoAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCursoAlumnos.CurrentCell.OwningColumn.Name == "Actualizar")
            {
                Business.Entities.AlumnoInscripcion ai = dgvCursoAlumnos.SelectedRows[0].DataBoundItem as Business.Entities.AlumnoInscripcion;
                var form = new InscripcionDesktop(ai.Id, false);
                MasterForm.OpenForm(form);
            }
            else if (dgvCursoAlumnos.CurrentCell.OwningColumn.Name == "Estado")
            {
                Business.Entities.AlumnoInscripcion ai = dgvCursoAlumnos.SelectedRows[0].DataBoundItem as Business.Entities.AlumnoInscripcion;
                var form = new InscripcionDesktop(ai.Id, true);
                MasterForm.OpenForm(form);
            }
        }

        private void tlpCursoAlumnos_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
