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
    public partial class Especialidades : ApplicationForm
    {
        EspecialidadLogic EspecialidadLogic => new();
        public Especialidades()
        {
            InitializeComponent();
        }

        private void tsNuevo_Click(object sender, EventArgs e)
        {
            tabFormulario.Controls.Clear();
            var desktop = this.LoadEspecialidadDesktop(new EspecialidadDesktop(ModoForm.Alta), Form_Especialidad_FormClosed);
            desktop.Show();
            LoadControls(desktop);
            tabEspecialidades.SelectTab(nameof(tabFormulario));
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dgvEspecialidades.DataSource = EspecialidadLogic.GetAll();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvEspecialidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex > 0)
            {
                tabEspecialidades.SelectTab(nameof(tabFormulario));
                tabFormulario.Controls.Clear();
                var especialidad = dgvEspecialidades.Rows[e.RowIndex].DataBoundItem as Especialidad;
                var desktop = this.LoadEspecialidadDesktop(new EspecialidadDesktop(especialidad.Id, ModoForm.Modificacion), Form_Especialidad_FormClosed);
                LoadControls(desktop);
                desktop.Show();
            }
        }

        private void Form_Especialidad_FormClosed(object sender, FormClosedEventArgs e)
        {
            dgvEspecialidades.DataSource = EspecialidadLogic.GetAll();
            tabEspecialidades.SelectTab("tabLista");
        }

        private void Especialidades_Load(object sender, EventArgs e)
        {
            dgvEspecialidades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEspecialidades.AutoGenerateColumns = false;
            dgvEspecialidades.DataSource = EspecialidadLogic.GetAll();
        }

        private void LoadControls(ApplicationForm desktop)
        {
            this.tabFormulario.Controls.Add(desktop);
            this.tabFormulario.Tag = desktop;
        }

        private void tabEspecialidades_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (tabEspecialidades.SelectedTab.Text == "Formulario")
            {
                if (tabFormulario.Controls.Count == 0)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
