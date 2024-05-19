using Business.Entities;
using Business.Logic;
using Business.Util.Exceptions;
using Business.Util.ValidatorsDesktop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
        private MasterForm MasterForm => this.MdiParent as MasterForm;
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
            txtMateria.TextBox.Text = Materia.Descripcion;
            txtComision.TextBox.Text = Comision.Descripcion;
            txtPlan.TextBox.Text = Plan.Descripcion;
            nudAnioCalendario.NumericUpDown.Value = Curso.AnioCalendario;
            nudCupo.NumericUpDown.Value = Curso.Cupo;
            txtPlan.Text = Curso.Materia.Plan.Descripcion;
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
            MasterForm.OpenForm(new Cursos());
            this.Close();
        }

        private void DeleteDescription()
        {
            btnAceptar.Text = "Eliminar";
            txtMateria.TextBox.ReadOnly = true;
            txtComision.TextBox.ReadOnly = true;
            txtPlan.TextBox.ReadOnly = true;
            nudAnioCalendario.Enabled = false;
            nudCupo.Enabled = false;
            lblCurso.Text = "Borrar curso";
        }

        private void NewDescription()
        {
            lblCurso.Text = "Crear curso";
        }

        private void EditDescription()
        {
            lblCurso.Text = "Modificar curso";
        }

        private void Save()
        {
            var validator = new CursoValidator();
            Curso.AnioCalendario = Convert.ToInt32(nudAnioCalendario.NumericUpDown.Value);
            Curso.Cupo = Convert.ToInt32(nudCupo.NumericUpDown.Value);
            Curso.ComisionId = Comision.Id;
            Curso.MateriaId = Materia.Id;
            string mensajeAlerta;

            if (Modo == ModoForm.Alta)
            {
                mensajeAlerta = "¿Desea confirmar la creación del curso?";
            }
            else
            {
                mensajeAlerta = "¿Desea guardar los cambios del curso?";
            }

            DialogResult result = MessageBox.Show(mensajeAlerta, "Confirmar cambios", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {

                var resultValidation = validator.Validate(Curso);
                if (resultValidation.IsValid)
                {
                    CursoLogic.Save(Curso);
                    if (Modo == ModoForm.Alta)
                    {
                        niCurso.ShowBalloonTip(1000, "Crear curso", $"Se ha creado el curso de manera existosa", ToolTipIcon.Info);
                    }
                    else
                    {
                        niCurso.ShowBalloonTip(1000, "Editar curso", $"Se han guardado los cambios de manera exitosa", ToolTipIcon.Info);
                    }
                    this.MasterForm.OpenForm(new Cursos());
                    this.Close();
                }
                else
                {
                    foreach (var error in resultValidation.Errors)
                    {
                        if (error.PropertyName == nameof(Curso.MateriaId))
                        {
                            this.txtMateria.LabelError.Text = error.ErrorMessage;
                        }
                        if (error.PropertyName == nameof(Curso.ComisionId))
                        {
                            this.txtComision.LabelError.Text = error.ErrorMessage;
                        }

                    }
                }
            }
        }

        private void Delete()
        {
            DialogResult result = MessageBox.Show("¿Desea borrar el curso?", "Eliminar curso", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                try
                {
                    CursoLogic.Delete(Curso.Id);
                    niCurso.ShowBalloonTip(1000, "Borrar curso", "Se ha borrado el curso correctamente", ToolTipIcon.Info);
                    MasterForm.OpenForm(new Cursos());
                }
                catch(Exception ex) 
                {
                    niCurso.ShowBalloonTip(1000, "Borrar curso", ex.Message, ToolTipIcon.Error);
                }
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
                Plan ??= new();
                if (Plan.Id != form.PlanObj.Id)
                {
                    MessageBox.Show("Al cambiar de plan debera a volver seleccionar la comisión y la materia del curso", "Cambio de plan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Plan = form.PlanObj;
                    txtPlan.TextBox.Text = Plan.Descripcion;
                    txtComision.TextBox.Text = string.Empty;
                    txtMateria.TextBox.Text = string.Empty;
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
                    txtComision.TextBox.Text = Comision.Descripcion;
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
                    txtMateria.TextBox.Text = Materia.Descripcion;
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un plan", "Error al seleccionar comisión", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tlCursos_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
