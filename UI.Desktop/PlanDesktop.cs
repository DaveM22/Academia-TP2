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
    public partial class PlanDesktop : ApplicationForm
    {
        private BindingSource dataSource;
        private Plan Plan { get; set; }
        private PlanLogic PlanLogic => new();

        private EspecialidadLogic EspecialidadLogic => new();

        public PlanDesktop()
        {
            InitializeComponent();
            dgvMaterias.AutoGenerateColumns = false;
        }

        public PlanDesktop(ModoForm modo) : this()
        {
            Modo = modo;
            Plan = new();
            NewDescription();
        }

        public PlanDesktop(int id, ModoForm modo) : this()
        {
            Modo = modo;
            Plan = PlanLogic.GetOne(id);
            dgvMaterias.DataSource = Plan.Materias;
            switch (modo)
            {
                case ModoForm.Modificacion:
                    EditDescription();
                    break;
                case ModoForm.Baja:
                    DeleteDescription();
                    break;
            }
        }

        private void DeleteDescription()
        {
            btnAceptar.Text = "Eliminar";
            txtDescripcion.Enabled = false;
            cmbEspecialidad.Enabled = false;
            Text = "Borrar curso";
        }

        private void NewDescription()
        {
            Text = "Crear plan";
        }

        private void EditDescription()
        {
            Text = "Modificar plan";
        }

        private void Save()
        {
            DialogResult result = MessageBox.Show("¿Desea guardar los cambios del plan?", "Confirmar cambios", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                PlanLogic.Save(Plan);
                this.Close();
            }
        }

        private void Delete()
        {
            DialogResult result = MessageBox.Show("¿Desea borrar el plan?", "Eliminar Plan", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                PlanLogic.Delete(Plan.Id);
                this.Close();
            }
        }

        private void PlanDesktop_Load(object sender, EventArgs e)
        {
            dgvMaterias.AutoGenerateColumns = false;
            cmbEspecialidad.DataSource = EspecialidadLogic.GetAll();
            dataSource = new BindingSource { Plan };
            cmbEspecialidad.DataBindings.Add("SelectedValue", dataSource, nameof(Plan.EspecialidadId));
            txtDescripcion.DataBindings.Add("Text", dataSource, nameof(Plan.Descripcion));
            dgvMaterias.DataBindings.Add("DataSource", dataSource, nameof(Plan.Materias));
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Plan = dataSource.Current as Plan;
            switch (Modo)
            {
                case ModoForm.Modificacion:
                case ModoForm.Alta:
                    Save();
                    break;
                case ModoForm.Baja:
                    Delete();
                    break;
            }
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
