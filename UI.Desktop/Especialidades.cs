using Business.Entities;
using Business.Logic;
using Business.Util.ValidatorsDesktop;
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

        public MasterForm Mast => this.MdiParent as MasterForm;


        public int IdEspecialidad { get; set; }
        public Especialidades()
        {
            InitializeComponent();

        }

        private void tsNuevo_Click(object sender, EventArgs e)
        {
            var form = new EspecialidadDesktop(ModoForm.Alta);
            Mast.OpenForm(form);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dgvEspecialidades.DataSource = EspecialidadLogic.GetAll();
        }

        private void Especialidades_Load(object sender, EventArgs e)
        {
            dgvEspecialidades.DataSource = EspecialidadLogic.GetAll();
        }


        private void btnSalir_Click_1(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            try
            {
                dgvEspecialidades.DataSource = EspecialidadLogic.GetAll();
                notifyIcon1.ShowBalloonTip(1000, "Actualizar especialidades", "Se han actualizado las especialidades", ToolTipIcon.Info);
            }
            catch (Exception)
            {
                notifyIcon1.ShowBalloonTip(1000, "Actualizar especialidades", "No se puedo realizar la consulta de especialidades. Contacte con un administrador", ToolTipIcon.Error);
            }

        }

        private void dgvEspecialidades_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var cell = dgvEspecialidades.CurrentCell.OwningColumn.Name;


            if (dgvEspecialidades.CurrentCell.OwningColumn.Name == "Editar")
            {
                Especialidad esp = dgvEspecialidades.SelectedRows[0].DataBoundItem as Especialidad;
                var form = new EspecialidadDesktop(esp.Id, ModoForm.Modificacion);
                Mast.OpenForm(form);
                this.Close();
            }
            else if (dgvEspecialidades.CurrentCell.OwningColumn.Name == "Eliminar")
            {
                Especialidad esp = dgvEspecialidades.SelectedRows[0].DataBoundItem as Especialidad;
                var form = new EspecialidadDesktop(esp.Id, ModoForm.Baja);
                Mast.OpenForm(form);
                this.Close();
            }
        }
    }
}
