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
using UI.Desktop.UserControls;

namespace UI.Desktop
{
    public partial class Especialidades : ApplicationForm
    {
        EspecialidadLogic EspecialidadLogic => new();

        public int? Id { get; set; }
        public Especialidades()
        {
            InitializeComponent();
        }

        private void tsNuevo_Click(object sender, EventArgs e)
        {
            this.tlEspecialidades.Controls.Clear();
            this.tlEspecialidades.Controls.Add(this.Desktop);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //dgvEspecialidades.DataSource = EspecialidadLogic.GetAll();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Especialidad_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.tlEspecialidades.Controls.Clear();
            this.tlEspecialidades.Controls.Add(new dgvEspecialidadesList() { Dock = DockStyle.Fill});
        }

        private void dgvEspecialidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > 0)
            {
            }
        }

        private void Especialidades_Load(object sender, EventArgs e)
        {

            this.LoadDesktop(new dgvEspecialidadesList() { Dock = DockStyle.Fill },Back);
            var especialidadForm = new EspecialidadFormControl();
            especialidadForm.Visible = false;
            this.Controls.Add(especialidadForm);
            //dgvEspecialidades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dgvEspecialidades.AutoGenerateColumns = false;
            //dgvEspecialidades.DataSource = EspecialidadLogic.GetAll();
        }

        private void LoadControls(ApplicationForm desktop)
        {
            this.tlEspecialidades.Controls.Clear();
            this.tlEspecialidades.Controls.Add(desktop);
        }

        private void Back(object sender, EventArgs e)
        {
            this.tlEspecialidades.Controls.Clear();
            this.tlEspecialidades.Controls.Add(new dgvEspecialidadesList() { Dock = DockStyle.Fill });
        }

        private void tabEspecialidades_Selecting(object sender, TabControlCancelEventArgs e)
        {
            //if (tabEspecialidades.SelectedTab.Text == "Formulario")
            //{
            //    if (tabFormulario.Controls.Count == 0)
            //    {
            //        e.Cancel = true;
            //    }
            //}
        }

        private void dgvEspecialidades_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > 0)
            {

                ////tabEspecialidades.SelectTab(nameof(tabFormulario));
                ////tabFormulario.Controls.Clear();
                //

            }
        }

        private void dgvEspecialidadesList1_Click(object sender, EventArgs e)
        {
            if (Id.HasValue)
            {
                var desktop = this.LoadEspecialidadDesktop(new EspecialidadDesktop(dgvEspecialidadesList1.Id.Value, ModoForm.Modificacion), Form_Especialidad_FormClosed);
                LoadControls(desktop);
                desktop.Show();
            }
        }
    }
}
