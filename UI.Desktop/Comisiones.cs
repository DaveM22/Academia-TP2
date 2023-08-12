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
    public partial class Comisiones : ApplicationForm
    {
        private ComisionLogic ComisionLogic => new();

        private MasterForm MasterForm => this.MdiParent as MasterForm;

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
            MasterForm.OpenForm(form);
        }

        private void tsEditar_Click(object sender, EventArgs e)
        {
            var row = dgvComisiones.SelectedRows[0].DataBoundItem as Comision;
            var form = new ComisionDesktop(row.Id, ApplicationForm.ModoForm.Modificacion);
            Master.OpenForm(form);
        }

        private void tsEliminar_Click(object sender, EventArgs e)
        {
            var row = dgvComisiones.SelectedRows[0].DataBoundItem as Comision;
            var form = new ComisionDesktop(row.Id, ApplicationForm.ModoForm.Baja);
            form.ShowDialog();
            dgvComisiones.DataSource = ComisionLogic.GetAll();
        }

        private void dgvComisiones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var cell = e;
            switch (cell.ColumnIndex)
            {
                case 4:
                    var rowEdit = dgvComisiones.SelectedRows[0].DataBoundItem as Comision;
                    var formEdit = new ComisionDesktop(rowEdit.Id, ApplicationForm.ModoForm.Modificacion);
                    MasterForm.OpenForm(formEdit);
                    break;
                case 5:
                    var rowDelete = dgvComisiones.SelectedRows[0].DataBoundItem as Comision;
                    var formDelete = new ComisionDesktop(rowDelete.Id, ApplicationForm.ModoForm.Baja);
                    MasterForm.OpenForm(formDelete);
                    break;
            }
        }
    }
}
