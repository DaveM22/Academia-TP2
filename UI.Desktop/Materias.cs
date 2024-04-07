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
    public partial class Materias : ApplicationForm
    {
        private MateriaLogic MateriaLogic { get; set; }
        private List<Materia> ListaMaterias { get; set; }
        private PlanLogic PlanLogic { get; set; }
        private Plan Plan { get; set; }
        private MasterForm MasterForm => this.MdiParent as MasterForm;

        public Materias()
        {
            InitializeComponent();
        }

        public Materias(int planId) : this()
        {
            MateriaLogic = new MateriaLogic();
            PlanLogic = new PlanLogic();
            ListaMaterias = MateriaLogic.GetAllByPlan(planId);
            Plan = PlanLogic.GetOne(planId);
        }

        private void Materias_Load(object sender, EventArgs e)
        {
            dgvMaterias.AutoGenerateColumns = false;
            dgvMaterias.DataSource = ListaMaterias;
            this.lblTituloMaterias.Text = "Materias del plan: " + Plan.Descripcion;
        }

        private void dgvMaterias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMaterias.CurrentCell.OwningColumn.Name == "Editar")
            {
                Materia materia = dgvMaterias.SelectedRows[0].DataBoundItem as Materia;
                var form = new MateriaDesktop(materia, ModoForm.Modificacion);
                MasterForm.OpenForm(form);
            }
            else if (dgvMaterias.CurrentCell.OwningColumn.Name == "Eliminar")
            {
                Materia materia = dgvMaterias.SelectedRows[0].DataBoundItem as Materia;
                var form = new MateriaDesktop(materia, ModoForm.Baja);
                MasterForm.OpenForm(form);
            }
        }

        private void tslCrearMateria_Click(object sender, EventArgs e)
        {
            var form = new MateriaDesktop(ModoForm.Alta, Plan.Id);
            MasterForm.OpenForm(form);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            var form = new Planes();
            MasterForm.OpenForm(form);
        }
    }
}
