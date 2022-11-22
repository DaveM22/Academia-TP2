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

        public int IdEspecialidad { get; set; }
        public Especialidades()
        {
            InitializeComponent();
        }

        private void tsNuevo_Click(object sender, EventArgs e)
        {
            var form = new EspecialidadDesktop(ModoForm.Alta);
            Master.OpenForm(form);
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

        private void dgvEspecialidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEspecialidades.CurrentCell.OwningColumn.Name == "Editar")
            {
                Especialidad esp = dgvEspecialidades.SelectedRows[0].DataBoundItem as Especialidad;
                var form = new EspecialidadDesktop(esp.Id, ModoForm.Modificacion);
                Master.OpenForm(form);
            }
            if (dgvEspecialidades.CurrentCell.OwningColumn.Name == "Eliminar")
            {
                Especialidad esp = dgvEspecialidades.SelectedRows[0].DataBoundItem as Especialidad;
                var form = new EspecialidadDesktop(esp.Id, ModoForm.Modificacion);
                Master.OpenForm(form);
            }
        }
    }
}
