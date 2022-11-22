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
    public partial class EspecialidadSearchForm : ApplicationForm
    {
        private EspecialidadLogic EspecialidadLogic { get; set; }
        public Especialidad Especialidad { get; set; }

        public EspecialidadSearchForm()
        {
            InitializeComponent();
        }

        private void EspecialidSearchForm_Load(object sender, EventArgs e)
        {
            EspecialidadLogic = new EspecialidadLogic();
            dgvEspecialidades.DataSource = EspecialidadLogic.GetAll();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            Especialidad = dgvEspecialidades.SelectedRows[0].DataBoundItem as Especialidad;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
