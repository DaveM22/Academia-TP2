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
    public partial class MateriaSearchForm : Form
    {
        private MateriaLogic MateriaLogic { get; set; }
        private Plan Plan { get; set; }
        public Materia MateriaObj { get; set; }
        public MateriaSearchForm()
        {
            InitializeComponent();
        }

        public MateriaSearchForm(Plan plan) : this()
        {
            Plan = plan;
        }

        private void MateriaSearchForm_Load(object sender, EventArgs e)
        {
            MateriaLogic = new MateriaLogic();
            dgvMaterias.AutoGenerateColumns = false;
            dgvMaterias.DataSource = MateriaLogic.GetAllByPlan(Plan.Id);
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            MateriaObj = dgvMaterias.SelectedRows[0].DataBoundItem as Materia;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
