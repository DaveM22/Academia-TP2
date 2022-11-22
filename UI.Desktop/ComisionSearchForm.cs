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
    public partial class ComisionSearchForm : Form
    {
        private ComisionLogic ComisionLogic { get; set; }

        public Comision ComisionObj { get; set; }

        private Plan PlanObj { get; set; }


        public ComisionSearchForm()
        {
            InitializeComponent();
        }

        public ComisionSearchForm(Plan plan) : this()
        {
            PlanObj = plan;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            ComisionObj = dgvComisiones.SelectedRows[0].DataBoundItem as Comision;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void ComisionSearchForm_Load(object sender, EventArgs e)
        {
            ComisionLogic = new ComisionLogic();
            dgvComisiones.AutoGenerateColumns = false;
            dgvComisiones.DataSource = ComisionLogic.GetAllByPlan(PlanObj.Id);
            if(dgvComisiones.RowCount == 0)
            {
                btnSeleccionar.Enabled = false;
            }
            this.Text = $"Comisiones del plan: {PlanObj.Descripcion}";
        }
    }
}
