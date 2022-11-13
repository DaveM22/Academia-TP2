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
    public partial class ComisionDesktop : ApplicationForm
    {

        private BindingSource dataSource;



        private PlanLogic PlanLogic => new();

        private ComisionLogic ComisionLogic => new();

        private Comision  Comision { get; set; }

        public ComisionDesktop()
        {
            InitializeComponent();
            cmbPlanes.DataSource = PlanLogic.GetAll();
            Comision = new();
        }

        public ComisionDesktop(ModoForm modo) : this()
        {
            Modo = modo;
            NewDescription();
        }

        public ComisionDesktop(int id, ModoForm modo) : this()
        {
            Comision = ComisionLogic.GetOne(id);
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
            cmbPlanes.Enabled = false;
            nudAño.Enabled = false;
            Text = "Borrar comisión";
        }

        private void NewDescription()
        {
            Text = "Crear comisión";
        }

        private void EditDescription()
        {
            Text = "Modificar comisión";
        }

        private void Save()
        {
            DialogResult result = MessageBox.Show("¿Desea guardar los cambios de la comisión?", "Confirmar cambios", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                ComisionLogic.Save(Comision);
                Master.OpenForm(new Comisiones());
                string accion = Modo == ModoForm.Alta ? $"Se ha creado la comisión: {Comision.Descripcion}" : $"Se ha modificado la comisión: {Comision.Descripcion}";
                MessageBox.Show(accion, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
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
            cmbPlanes.DataBindings.Add("SelectedValue", dataSource, nameof(Comision.PlanId));
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
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Master.OpenForm(new Comisiones());
            this.Close();
        }

        private void cmbPlanes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
