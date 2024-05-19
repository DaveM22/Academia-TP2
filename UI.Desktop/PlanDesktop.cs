using Business.Entities;
using Business.Logic;
using Business.Util.Exceptions;
using Business.Util.ValidatorsDesktop;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class PlanDesktop : ApplicationForm
    {
        private PlanLogic PlanLogic { get; set; }
        private Especialidad Especialidad { get; set; }
        private Plan Plan { get; set; }
        PlanValidator validator => new PlanValidator();
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



        private void PlanDesktop_Load(object sender, EventArgs e)
        {
            PlanLogic = new PlanLogic();
            txtEspecialidad.TextBox.ReadOnly = true;
            Titulo();
            if (Modo == ModoForm.Modificacion || Modo == ModoForm.Baja)
            {
                CargarDatos(Id, Modo);
            }
            else
            {
                Plan = new Plan();
            }
        }


        public void Titulo()
        {
            if (Modo == ModoForm.Baja)
            {
                lblTitulo.Text = "Borrar plan";
                btnGuardar.Text = "Borrar";
                txtDescripcion.Enabled = false;
                txtEspecialidad.Enabled = false;
                btnSeleccionarEspecialidad.Visible = false;
            }
            if (Modo == ModoForm.Modificacion)
            {
                lblTitulo.Text = "Editar plan";
                btnGuardar.Text = "Guardar";
            }
            if (Modo == ModoForm.Alta)
            {
                lblTitulo.Text = "Crear plan";
                btnGuardar.Text = "Crear";

            }
        }


        public void CargarDatos(int id, ModoForm modo)
        {
            Plan = PlanLogic.GetOne(id);
            txtDescripcion.TextBox.Text = Plan.Descripcion;
            Especialidad = Plan.Especialidad;
            txtEspecialidad.TextBox.Text = Especialidad.Descripcion;
        }



        private void btnSeleccionarEspecialidad_Click(object sender, EventArgs e)
        {
            var form = new EspecialidadSearchForm();
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                Especialidad = form.Especialidad;
                this.Plan.EspecialidadId = Especialidad.Id;
                txtEspecialidad.TextBox.Text = Especialidad.Descripcion;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Modo == ModoForm.Baja)
                {
                    Borrar();
                }
                else
                {


                    Plan.Descripcion = txtDescripcion.TextBox.Text;
                    Guardar();
                }

            }
            catch (EntityValidationException ex)
            {
                MessageBox.Show(ex.Errors.ToString(), ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void Guardar()
        {
            DialogResult result = MessageBox.Show("¿Desea guardar los cambios de la especialidad?", "Confirmar cambios", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                var resultValidation = validator.Validate(Plan);
                if (resultValidation.IsValid)
                {
                    PlanLogic.Save(Plan);
                    if (Modo == ModoForm.Alta)
                    {
                        notifyIcon1.ShowBalloonTip(1000, "Guardar plan", $"El plan {Plan.Descripcion} se ha creado correctamente", ToolTipIcon.Info);
                    }
                    else
                    {
                        notifyIcon1.ShowBalloonTip(1000, "Editar plan", $"Se han guardado los cambios de plan correctamente", ToolTipIcon.Info);
                    }

                    MasterForm.OpenForm(new Planes());
                }
                else
                {
                    foreach (var error in resultValidation.Errors)
                    {
                        if (error.PropertyName == nameof(Plan.Descripcion))
                        {
                            this.txtDescripcion.LabelError.Text = error.ErrorMessage;
                        }
                        if (error.PropertyName == nameof(Plan.EspecialidadId))
                        {
                            this.txtEspecialidad.LabelError.Text = error.ErrorMessage;
                        }
                    }
                }
            }
        }

        private void Borrar()
        {
            DialogResult result = MessageBox.Show("¿Desea borrar la plan?", "Borrar plan", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                try
                {
                    PlanLogic.Delete(Plan.Id);
                    notifyIcon1.ShowBalloonTip(1000, "Borrar plan", "Se ha borrado la plan correctamente", ToolTipIcon.Info);
                    MasterForm.OpenForm(new Planes());
                }
                catch (DeleteCFReferenciadaException ex)
                {
                    notifyIcon1.ShowBalloonTip(1000, "Borrar plan", ex.Message, ToolTipIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MasterForm.OpenForm(new Planes());
            this.Close();
        }

        private void txtEspecialidad_Load(object sender, EventArgs e)
        {

        }

        private void txtDescripcion_Load(object sender, EventArgs e)
        {

        }
    }
}
