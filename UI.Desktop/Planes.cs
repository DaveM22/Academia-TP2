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
    public partial class Planes : ApplicationForm
    {
        private PlanLogic PlanLogic => new PlanLogic();
        private MasterForm MasterForm = Application.OpenForms["MasterForm"] as MasterForm;


        public Planes()
        {
            InitializeComponent();
            dgvPlanes.AutoGenerateColumns = false;
            dgvPlanes.DataSource = PlanLogic.GetAll();
        }

        private void tsNuevo_Click(object sender, EventArgs e)
        {
            var form = new PlanDesktop(ApplicationForm.ModoForm.Alta);
            MasterForm.OpenForm(form);
        }

        private void tsModificar_Click(object sender, EventArgs e)
        {
            //var row = dgvPlanes.SelectedRows[0].DataBoundItem as Plan;
            //var form = new PlanDesktop(row.Id, ApplicationForm.ModoForm.Modificacion);
            //form.ShowDialog();
            //dgvPlanes.DataSource = PlanLogic.GetAll();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            //var row = dgvPlanes.SelectedRows[0].DataBoundItem as Plan;
            //var form = new PlanDesktop(row.Id, ApplicationForm.ModoForm.Baja);
            //form.ShowDialog();
            //dgvPlanes.DataSource = PlanLogic.GetAll();
        }

        private void dgvPlanes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPlanes.CurrentCell.OwningColumn.Name == "Editar")
            {
                Plan plan = dgvPlanes.SelectedRows[0].DataBoundItem as Plan;
                var form = new PlanDesktop(plan.Id, ModoForm.Modificacion);
                MasterForm.OpenForm(form);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dgvPlanes.DataSource = this.PlanLogic.GetAll();
            niPlanes.ShowBalloonTip(1000, "Actualizar lista de planes", "Se ha actualizado la lista de planes", ToolTipIcon.Info);
            try
            {

            }
            catch (Exception)
            {
                niPlanes.ShowBalloonTip(1000, "Actualizar lista de planes", "No se puedo realizar la consulta de planes. Contacte con un administrador", ToolTipIcon.Error);
            }
        }
    }
}
