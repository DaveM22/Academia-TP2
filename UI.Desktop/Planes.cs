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
    public partial class Planes : Form
    {
        private PlanLogic PlanLogic => new PlanLogic();
        public Planes()
        {
            InitializeComponent();
            dgvPlanes.AutoGenerateColumns = false;
            dgvPlanes.DataSource = PlanLogic.GetAll();
        }

        private void tsNuevo_Click(object sender, EventArgs e)
        {
            var form = new PlanDesktop(ApplicationForm.ModoForm.Alta);
            form.ShowDialog();
            dgvPlanes.DataSource = PlanLogic.GetAll();
        }

        private void tsModificar_Click(object sender, EventArgs e)
        {
            var row = dgvPlanes.SelectedRows[0].DataBoundItem as Plan;
            var form = new PlanDesktop(row.Id, ApplicationForm.ModoForm.Modificacion);
            form.ShowDialog();
            dgvPlanes.DataSource = PlanLogic.GetAll();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            var row = dgvPlanes.SelectedRows[0].DataBoundItem as Plan;
            var form = new PlanDesktop(row.Id, ApplicationForm.ModoForm.Baja);
            form.ShowDialog();
            dgvPlanes.DataSource = PlanLogic.GetAll();
        }
    }
}
