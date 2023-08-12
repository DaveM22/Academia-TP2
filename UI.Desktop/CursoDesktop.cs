using Business.Entities;
using Business.Logic;
using Business.Util.Exceptions;
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
    public partial class CursoDesktop : ApplicationForm
    {
        private Curso Curso { get; set; }
        private Plan Plan { get; set; }
        private Materia Materia { get; set; }
        private Comision Comision { get; set; }
        private CursoLogic CursoLogic => new();



        public CursoDesktop()
        {
            InitializeComponent();
        }

        public CursoDesktop(ModoForm modo) : this()
        {
            Modo = modo;
            Curso = new();
            Comision = new();
            Materia = new();
            NewDescription();
        }

        public CursoDesktop(int id, ModoForm modo) : this()
        {
            Modo = modo;
            Curso = CursoLogic.GetOne(id);
            Materia = Curso.Materia;
            Comision = Curso.Comision;
            Plan = Materia.Plan;
            txtMateria.Text = Materia.Descripcion;
            txtComision.Text = Comision.Descripcion;
            nudAnioCalendario.Value = Curso.AnioCalendario;
            nudCupo.Value = Curso.Cupo;
            txtPlan.Text = Curso.Materia.PlanDescripcion;
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
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
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Master.OpenForm(new Cursos());
            this.Close();
        }

        private void DeleteDescription()
        {
            btnAceptar.Text = "Eliminar";
            nudAnioCalendario.Enabled = false;
            nudCupo.Enabled = false;
            Text = "Borrar curso";
        }

        private void NewDescription()
        {
            Text = "Crear curso";
        }

        private void EditDescription()
        {
            Text = "Modificar curso";
        }

        private void Save()
        {
            Curso.AnioCalendario = Convert.ToInt32(nudAnioCalendario.Value);
            Curso.Cupo = Convert.ToInt32(nudCupo.Value);
            Curso.ComisionId = Comision.Id;
            Curso.MateriaId = Materia.Id;
            Curso.Comision = Comision;
            Curso.Materia = Materia;
            DialogResult result = MessageBox.Show("¿Desea guardar los cambios del cuso?", "Confirmar cambios", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                try
                {
                    CursoLogic.Save(Curso);
                    Master.OpenForm(new Cursos());
                    this.Close();
                }
                catch (EntityValidationException ex)
                {
                    MessageBox.Show(ex.Errors.ToString(), ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Delete()
        {
            DialogResult result = MessageBox.Show("¿Desea borrar el curso?", "Eliminar curso", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                CursoLogic.Delete(Curso.Id);
                Master.OpenForm(new Cursos());
                this.Close();
            }
        }

        private void CursoDesktop_Load(object sender, EventArgs e)
        {


        }

        private void btnPlan_Click(object sender, EventArgs e)
        {
            var form = new PlanSearchForm();
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {

                if (Plan.Id != form.PlanObj.Id)
                {
                    MessageBox.Show("Al cambiar de plan debera a volver seleccionar la comisión y la materia del curso", "Cambio de plan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Plan = form.PlanObj;
                    txtPlan.Text = Plan.Descripcion;
                    txtComision.Text = string.Empty;
                    txtMateria.Text = string.Empty;
                    Comision = null;
                    Materia = null;
                }
                else
                {
                    Plan = form.PlanObj;
                }
            }
        }

        private void btnComision_Click(object sender, EventArgs e)
        {
            if (Plan != null)
            {
                var form = new ComisionSearchForm(Plan);
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Comision = form.ComisionObj;
                    txtComision.Text = Comision.Descripcion;
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un plan", "Error al seleccionar comisión", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnMateria_Click(object sender, EventArgs e)
        {
            if (Plan != null)
            {
                var form = new MateriaSearchForm(Plan);
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Materia = form.MateriaObj;
                    txtMateria.Text = Materia.Descripcion;
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un plan", "Error al seleccionar comisión", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
