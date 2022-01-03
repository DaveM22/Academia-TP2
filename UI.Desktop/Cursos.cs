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
    public partial class Cursos : Form
    {
        private CursoLogic CursoLogic => new();
        public Cursos()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dgvCursos.DataSource = CursoLogic.GetAll();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cursos_Load(object sender, EventArgs e)
        {
            dgvCursos.AutoGenerateColumns = false;
            dgvCursos.DataSource = CursoLogic.GetAll();
        }

        private void tsNuevo_Click(object sender, EventArgs e)
        {
            var form = new CursoDesktop(ModoForm.Alta);
            form.ShowDialog();
            dgvCursos.DataSource = CursoLogic.GetAll();
        }

        private void tsModificacion_Click(object sender, EventArgs e)
        {
            var row = dgvCursos.SelectedRows[0].DataBoundItem as Curso;
            var form = new CursoDesktop(row.Id,ModoForm.Modificacion);
            form.ShowDialog();
            dgvCursos.DataSource = CursoLogic.GetAll();
        }

        private void tsEliminar_Click(object sender, EventArgs e)
        {
            var row = dgvCursos.SelectedRows[0].DataBoundItem as Curso;
            var form = new CursoDesktop(row.Id, ModoForm.Baja);
            form.ShowDialog();
            dgvCursos.DataSource = CursoLogic.GetAll();
        }
    }
}
