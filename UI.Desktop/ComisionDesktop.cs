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
    public partial class ComisionDesktop : ApplicationForm
    {

        private BindingSource dataSource;
        private Plan Plan { get; set; }

        private MasterForm MasterForm => this.MdiParent as MasterForm;

        private PlanLogic PlanLogic => new();

        private ComisionLogic ComisionLogic => new();

        private MasterForm masterForm => this.MdiParent as MasterForm;

        private Comision Comision { get; set; }

        ComisionValidator validator => new ComisionValidator();

        public ComisionDesktop()
        {
            InitializeComponent();

        }

        public ComisionDesktop(ModoForm modo) : this()
        {
            Modo = modo;
            Comision = new();
            NewDescription();
        }

        public ComisionDesktop(int id, ModoForm modo) : this()
        {
            Comision = ComisionLogic.GetOne(id);
            txtPlan.Text = Comision.Plan.Descripcion;
            Plan = Comision.Plan;
            Modo = modo;
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
            txtDescripcion.TextBox.ReadOnly = true;
            txtDescripcion.TextBox.Enabled = false;
            nudAño.Enabled = false;
            txtPlan.Enabled = false;
            btnSeleccionarPlan.Enabled = false;
            lblComision.Text = "Borrar comisión";
            Text = "Borrar comisión";
        }

        private void NewDescription()
        {
            Text = "Crear comisión";
            lblComision.Text = "Crear comisión";
        }

        private void EditDescription()
        {
            Text = "Modificar comisión";
            lblComision.Text = "Modificar comisión";
        }

        private void Save()
        {


            string mensajeAlerta;

            if (Modo == ModoForm.Alta)
            {
                mensajeAlerta = "¿Desea confirmar la creación comisión?";
            }
            else
            {
                mensajeAlerta = "¿Desea guardar los cambios de la comisión?";
            }

            DialogResult result = MessageBox.Show(mensajeAlerta, "Confirmar cambios", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                Comision.PlanId = Plan.Id;
                var resultValidation = validator.Validate(Comision);
                if (resultValidation.IsValid)
                {
                    ComisionLogic.Save(Comision);
                    if (Modo == ModoForm.Alta)
                    {
                        notifyIcon1.ShowBalloonTip(1000, "Crear especialidad", $"Se ha creado la especialidad correctamente", ToolTipIcon.Info);
                    }
                    else
                    {
                        notifyIcon1.ShowBalloonTip(1000, "Editar especialidad", $"Se han guardado los cambios correctamente", ToolTipIcon.Info);
                    }
                    this.masterForm.OpenForm(new Comisiones());
                    this.Close();
                }
                else
                {
                    foreach (var error in resultValidation.Errors)
                    {
                        if (error.PropertyName == nameof(Especialidad.Descripcion))
                        {
                            this.txtDescripcion.LabelError.Text = error.ErrorMessage;
                        }
                    }
                }
            }

        }

        private void Delete()
        {
            DialogResult result = MessageBox.Show("¿Desea borrar la comisión?", "Eliminar especialidad", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                ComisionLogic.Delete(Comision.Id);
                notifyIcon1.ShowBalloonTip(1000, "Borrar comisión", "Se ha borrado la comisión correctamente", ToolTipIcon.Info);
                masterForm.OpenForm(new Comisiones());
                this.Close();
            }
        }

        private void ComisionDesktop_Load(object sender, EventArgs e)
        {
            dataSource = new BindingSource { Comision };
            txtDescripcion.TextBox.DataBindings.Add("Text", dataSource, nameof(Comision.Descripcion));
            txtPlan.ReadOnly = true;
            nudAño.DataBindings.Add("Value", dataSource, nameof(Comision.AnioEspecialidad));
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Comision = dataSource.Current as Comision;
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
            this.MasterForm.OpenForm(new Comisiones());
            this.Close();
        }



        private void btnSeleccionarPlan_Click(object sender, EventArgs e)
        {
            var form = new PlanSearchForm();
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                Plan = form.PlanObj;
                txtPlan.Text = Plan.Descripcion;
            }
        }


    }
}
