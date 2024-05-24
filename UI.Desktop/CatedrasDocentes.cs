using Accord.Controls;
using Business.Entities;
using Business.Logic;
using DocumentFormat.OpenXml.Bibliography;
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
    public partial class CatedrasDocentes : ApplicationForm
    {
        public EspecialidadLogic EspecialidadLogic => new EspecialidadLogic();
        public PlanLogic PlanLogic => new PlanLogic();
        public ComisionLogic ComisionLogic => new ComisionLogic();

        public CursoLogic CursoLogic => new CursoLogic();

        private MasterForm MasterForm => this.MdiParent as MasterForm;
        public CatedrasDocentes()
        {
            InitializeComponent();
            this.dgvCursosDocentes.AllowNestedProperties(true);
            this.dgvCursosDocentes.AutoGenerateColumns = false;
            this.cbEspecialidades.ValueMember = "Id";
            this.cbEspecialidades.DisplayMember = "Descripcion";
            this.cbPlanes.ValueMember = "Id";
            this.cbPlanes.DisplayMember = "Descripcion";
            this.cbEspecialidades.ValueMember = "Id";
            this.cbEspecialidades.DisplayMember = "Descripcion";
            this.cbComisiones.ValueMember = "Id";
            this.cbComisiones.DisplayMember = "Descripcion";
            this.cbEspecialidades.DataSource = this.EspecialidadLogic.GetAll();
            this.cbEspecialidades.SelectedIndex = -1;

        }





        private void cbEspecialidades_SelectedValueChanged(object sender, EventArgs e)
        {
            this.cbEspecialidades.Text = "Seleccionar especialidad";
        }


        private void cbEspecialidades_SelectionChangeCommitted(object sender, EventArgs e)
        {

            this.cbPlanes.DataSource = this.PlanLogic.PlanesByEspecialidad((int)this.cbEspecialidades.SelectedValue);
            this.cbPlanes.SelectedIndex = -1;
        }

        private void cbPlanes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.cbComisiones.DataSource = this.ComisionLogic.GetAllByPlan((int)this.cbPlanes.SelectedValue);
            this.cbComisiones.SelectedIndex = -1;
        }

        private void cbComisiones_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.dgvCursosDocentes.DataSource = this.CursoLogic.GetAllByComision((int)this.cbComisiones.SelectedValue);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.MasterForm.OpenForm(new Inicio());
        }

        private void dgvCursosDocentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCursosDocentes.CurrentCell.OwningColumn.Name == "Profesores")
            {
                Curso curso = dgvCursosDocentes.SelectedRows[0].DataBoundItem as Curso;
                var form = new DocenteCursos(curso.Id);
                MasterForm.OpenForm(form);
            }
        }

        private void dgvCursosDocentes_Paint(object sender, PaintEventArgs e)
        {
            if (dgvCursosDocentes.Rows.Count == 0)
                TextRenderer.DrawText(e.Graphics, "No se encontraron catedras con los filtros ingresados",
                    dgvCursosDocentes.Font, dgvCursosDocentes.ClientRectangle,
                    dgvCursosDocentes.ForeColor, dgvCursosDocentes.BackgroundColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
    }
}
