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

        private BindingSource dataSourceMateria;
        private Plan Plan { get; set; }
        private PlanLogic PlanLogic => new();

        private Materia MateriaActual { get; set; }

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
            MateriaActual = new();
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
            dgvMaterias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cmbEspecialidad.DataSource = EspecialidadLogic.GetAll();
            dataSource = new BindingSource { Plan };
            dataSourceMateria = new BindingSource { MateriaActual };
            cmbEspecialidad.DataBindings.Add("SelectedValue", dataSource, nameof(Plan.EspecialidadId));
            txtDescripcion.DataBindings.Add("Text", dataSource, nameof(Plan.Descripcion));
            dgvMaterias.DataBindings.Add("DataSource", dataSource, nameof(Plan.Materias));
            txtMateriaDescripcion.DataBindings.Add("Text", dataSourceMateria, nameof(MateriaActual.Descripcion));
            nudHsSemanales.DataBindings.Add("Value", dataSourceMateria, nameof(MateriaActual.HSSemanales));
            nudHsTotales.DataBindings.Add("Value", dataSourceMateria, nameof(MateriaActual.HSTotales));
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

        private void dgvMaterias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MateriaActual = dgvMaterias.Rows[e.RowIndex].DataBoundItem as Materia;
            ClearBindingMateria();
            SetBindingMateria();
            tcPlan.SelectTab("Formulario");
        }

        private void btnAgregarMateria_Click(object sender, EventArgs e)
        {
            MateriaActual = new();
            ClearBindingMateria();
            SetBindingMateria();
        }

        private void ClearBindingMateria()
        {
            txtMateriaDescripcion.DataBindings.Clear();
            nudHsSemanales.DataBindings.Clear();
            nudHsTotales.DataBindings.Clear();
        }

        private void SetBindingMateria()
        {
            tcPlan.SelectTab("Formulario");
            dataSourceMateria = new BindingSource { MateriaActual };
            txtMateriaDescripcion.DataBindings.Add("Text", dataSourceMateria, nameof(MateriaActual.Descripcion));
            nudHsSemanales.DataBindings.Add("Value", dataSourceMateria, nameof(MateriaActual.HSSemanales));
            nudHsTotales.DataBindings.Add("Value", dataSourceMateria, nameof(MateriaActual.HSTotales));
        }

        private void btnGuardarMateria_Click(object sender, EventArgs e)
        {
            var materia = dataSourceMateria.Current as Materia;
            var datasource = (dataSource.Current as Plan)?.Materias;
            datasource.Add(materia);
            dgvMaterias.DataSource = datasource;
            dgvMaterias.Refresh();
            tcPlan.SelectTab("Materias");
        }
    }
}
