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

namespace UI.Desktop
{
    public partial class Especialidades : Form
    {
        EspecialidadLogic EspecialidadLogic => new();
        public Especialidades()
        {
            InitializeComponent();
            dgvEspecialidades.AutoGenerateColumns = false;
            dgvEspecialidades.DataSource = EspecialidadLogic.GetAll();
        }

        private void tsNuevo_Click(object sender, EventArgs e)
        {
            var form = new EspecialidadDesktop(ApplicationForm.ModoForm.Alta);
            form.ShowDialog();
            dgvEspecialidades.DataSource = EspecialidadLogic.GetAll();
        }

        private void tsEditar_Click(object sender, EventArgs e)
        {
            var row = dgvEspecialidades.SelectedRows[0].DataBoundItem as Especialidad;
            var form = new EspecialidadDesktop(row.Id, ApplicationForm.ModoForm.Modificacion);
            form.ShowDialog();
            dgvEspecialidades.DataSource = EspecialidadLogic.GetAll();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dgvEspecialidades.DataSource = EspecialidadLogic.GetAll();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsEliminar_Click(object sender, EventArgs e)
        {
            var row = dgvEspecialidades.SelectedRows[0].DataBoundItem as Especialidad;
            var form = new EspecialidadDesktop(row.Id, ApplicationForm.ModoForm.Baja);
            form.ShowDialog();
            dgvEspecialidades.DataSource = EspecialidadLogic.GetAll();
        }
    }
}
