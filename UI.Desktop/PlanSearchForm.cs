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
    public partial class PlanSearchForm : Form
    {
        private PlanLogic PlanLogic { get; set; }

        public Plan PlanObj { get; set; }

        public PlanSearchForm()
        {
            InitializeComponent();
        }

        private void PlanSearchForm_Load(object sender, EventArgs e)
        {
            PlanLogic = new PlanLogic();
            dgvPlanes.AutoGenerateColumns = false;
            dgvPlanes.DataSource = PlanLogic.GetAll();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            this.PlanObj = dgvPlanes.SelectedRows[0].DataBoundItem as Plan;
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
