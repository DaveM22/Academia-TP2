using Business.Entities;
using Business.Logic;
using Business.Util.Exceptions;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class PlanDesktop : ApplicationForm
    {
        private PlanLogic PlanLogic { get; set; }
        private Especialidad Especialidad { get; set; }
        private Plan Plan { get; set; }

        private MasterForm MasterForm => this.MdiParent as MasterForm;

        private int Id { get; set; }

        public PlanDesktop()
        {
            InitializeComponent();
        }

        public PlanDesktop(ModoForm modo) : this()
        {
            Modo = modo;
        }

        public PlanDesktop(int id, ModoForm modo) : this()
        {
            Modo = modo;
            Id = id;
        }

        private void tlpPlanes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregarMateria_Click(object sender, EventArgs e)
        {
            var form = new MateriaDesktop();
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                var lista = (BindingList<Materia>)dgvMaterias.DataSource;
                lista.Add(form.Materia);
                this.dgvMaterias.DataSource = lista;
                this.dgvMaterias.Update();
            }
        }

        private void PlanDesktop_Load(object sender, EventArgs e)
        {
            PlanLogic = new PlanLogic();
            dgvMaterias.AutoGenerateColumns = false;
            if (Modo == ModoForm.Alta)
            {
                this.dgvMaterias.DataSource = new BindingList<Materia>();
            }
            else
            {
                Plan = PlanLogic.GetOne(Id);
                txtDescripcion.Text = Plan.Descripcion;
                Especialidad = Plan.Especialidad;
                txtEspecialidad.Text = Especialidad.Descripcion;
                dgvMaterias.DataSource = new BindingList<Materia>(Plan.Materias);
            }
        }

        private void dgvMaterias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMaterias.CurrentCell.OwningColumn.Name == "Editar")
            {
                Materia materia = dgvMaterias.SelectedRows[0].DataBoundItem as Materia;
                var form = new MateriaDesktop(materia, ModoForm.Modificacion);
                form.ShowDialog();
                dgvMaterias.Refresh();
            }
        }

        private void tlpPlanes_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnSeleccionarEspecialidad_Click(object sender, EventArgs e)
        {
            var form = new EspecialidadSearchForm();
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                Especialidad = form.Especialidad;
                txtEspecialidad.Text = Especialidad.Descripcion;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Modo == ModoForm.Alta)
                {
                    Plan = new Plan();
                }

                Plan.Descripcion = txtDescripcion.Text;
                Plan.Especialidad = Especialidad;
                Plan.Materias = ((BindingList<Materia>)dgvMaterias.DataSource).ToList();
                PlanLogic.Save(Plan);
                MasterForm.OpenForm(new Planes());
            }

            catch (EntityValidationException ex)
            {
                MessageBox.Show(ex.Errors.ToString(), ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MasterForm.OpenForm(new Planes());
            this.Close();
        }
    }
}
