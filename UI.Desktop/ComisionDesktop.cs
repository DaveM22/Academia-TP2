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
    public partial class ComisionDesktop : ApplicationForm
    {

        private BindingSource dataSource;
        private Plan Plan { get; set; }

        private MasterForm MasterForm => this.MdiParent as MasterForm;

        private PlanLogic PlanLogic => new();

        private ComisionLogic ComisionLogic => new();

        private Comision Comision { get; set; }

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
            txtDescripcion.ReadOnly = true;
            txtDescripcion.Enabled = false;
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
            DialogResult result = MessageBox.Show("¿Desea guardar los cambios de la comisión?", "Confirmar cambios", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                try
                {
                    this.Comision.PlanId = this.Plan.Id;
                    ComisionLogic.Save(Comision);
                    MasterForm.OpenForm(new Comisiones());
                    string accion = Modo == ModoForm.Alta ? $"Se ha creado la comisión: {Comision.Descripcion}" : $"Se ha modificado la comisión: {Comision.Descripcion}";
                    MessageBox.Show(accion, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }
                catch (EntityValidationException ex)
                {
                    MessageBox.Show(ex.Errors.ToString(), ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Delete()
        {
            DialogResult result = MessageBox.Show("¿Desea borrar la comisión?", "Eliminar especialidad", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                ComisionLogic.Delete(Comision.Id);
                this.Close();
            }
        }

        private void ComisionDesktop_Load(object sender, EventArgs e)
        {
            dataSource = new BindingSource { Comision };
            txtDescripcion.DataBindings.Add("Text", dataSource, nameof(Comision.Descripcion));
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

        private void cmbPlanes_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
