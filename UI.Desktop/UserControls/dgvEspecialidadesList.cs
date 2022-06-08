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

namespace UI.Desktop.UserControls
{
    public partial class dgvEspecialidadesList : UserControl
    {
        private EspecialidadLogic EspecialidadLogic => new EspecialidadLogic();

        public int? Id { get; set; }
        public dgvEspecialidadesList()
        {
            InitializeComponent();
        }

        private void dgvEspecialidadesList_Load(object sender, EventArgs e)
        {
            dgvEspecialidades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEspecialidades.AutoGenerateColumns = false;
            dgvEspecialidades.DataSource = EspecialidadLogic.GetAll();
        }

        private void dgvEspecialidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > 0)
            {
                var especialidad = dgvEspecialidades.Rows[e.RowIndex].DataBoundItem as Especialidad;
                this.Id = especialidad.Id;
                
                ////tabEspecialidades.SelectTab(nameof(tabFormulario));
                ////tabFormulario.Controls.Clear();
                //
                //var desktop = this.LoadEspecialidadDesktop(new EspecialidadDesktop(especialidad.Id, ModoForm.Modificacion), Form_Especialidad_FormClosed);
                //LoadControls(desktop);
                //desktop.Show();
            }
        }
    }
}
