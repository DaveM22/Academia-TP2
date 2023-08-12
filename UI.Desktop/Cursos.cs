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
    public partial class Cursos : ApplicationForm
    {
        private CursoLogic CursoLogic => new();

        private MasterForm MasterForm => this.MdiParent as MasterForm;
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
            MasterForm.OpenForm(form);
        }

        private void dgvCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCursos.CurrentCell.OwningColumn.Name == "Editar")
            {
                Curso curso = dgvCursos.SelectedRows[0].DataBoundItem as Curso;
                var form = new CursoDesktop(curso.Id, ModoForm.Modificacion);
                Master.OpenForm(form);
            }

            if (dgvCursos.CurrentCell.OwningColumn.Name == "Eliminar")
            {
                Curso curso = dgvCursos.SelectedRows[0].DataBoundItem as Curso;
                var form = new CursoDesktop(curso.Id, ModoForm.Baja);
                Master.OpenForm(form);
            }
        }
    }
}
