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
    public partial class Comisiones : Form
    {
        private ComisionLogic ComisionLogic => new();
        public Comisiones()
        {
            InitializeComponent();
            dgvComisiones.AutoGenerateColumns = false;
            dgvComisiones.DataSource = ComisionLogic.GetAll();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dgvComisiones.DataSource = ComisionLogic.GetAll();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsNuevo_Click(object sender, EventArgs e)
        {
            var form = new ComisionDesktop(ApplicationForm.ModoForm.Alta);
            form.ShowDialog();
            dgvComisiones.DataSource = ComisionLogic.GetAll();
        }

        private void tsEditar_Click(object sender, EventArgs e)
        {
            var row = dgvComisiones.SelectedRows[0].DataBoundItem as Comision;
            var form = new ComisionDesktop(row.Id, ApplicationForm.ModoForm.Modificacion);
            form.ShowDialog();
            dgvComisiones.DataSource = ComisionLogic.GetAll();
        }

        private void tsEliminar_Click(object sender, EventArgs e)
        {
            var row = dgvComisiones.SelectedRows[0].DataBoundItem as Comision;
            var form = new ComisionDesktop(row.Id, ApplicationForm.ModoForm.Baja);
            form.ShowDialog();
            dgvComisiones.DataSource = ComisionLogic.GetAll();
        }
    }
}
