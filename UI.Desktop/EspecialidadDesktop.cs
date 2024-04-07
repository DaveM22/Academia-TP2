using Business.Entities;
using Business.Logic;
using Business.Util.Exceptions;
using Business.Util.ValidatorsDesktop;
using System;
using System.Windows.Forms;
using UI.Desktop.UserControls;

namespace UI.Desktop
{
    public partial class EspecialidadDesktop : ApplicationForm
    {

        private EspecialidadLogic EspecialidadLogic => new();
        private MasterForm masterForm => this.MdiParent as MasterForm;

        EspecialidadValidator validator => new EspecialidadValidator();

        public Especialidad Especialidad { get; set; }
        public EspecialidadDesktop()
        {
            InitializeComponent();
        }


        public EspecialidadDesktop(ModoForm modo) : this()
        {
            Modo = modo;
            Especialidad = new();
            NewDescription();
        }


        public EspecialidadDesktop(int ID, ModoForm modo) : this()
        {
            Modo = modo;
            Especialidad = EspecialidadLogic.GetOne(ID);
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
            this.txtDescripcion.TextBox.Text = this.Especialidad.Descripcion;
            btnAceptar.Text = "Eliminar";
            txtDescripcion.TextBox.ReadOnly = true;
            Text = "Borrar especialidad";
            txtTitulo.Text = "Borrar especialidad";
            txtDescripcion.TextBox.Enabled = false;
        }

        private void NewDescription()
        {
            Text = "Crear especialidad";
            txtTitulo.Text = "Crear especialidad";
        }

        private void EditDescription()
        {
            Text = "Modificar especialidad";
            txtTitulo.Text = "Modificar especialidad";
            this.txtDescripcion.TextBox.Text = this.Especialidad.Descripcion;
        }

        private void Save()
        {
            string mensajeAlerta;

            this.Especialidad.Descripcion = this.txtDescripcion.TextBox.Text;

            if (Modo == ModoForm.Alta)
            {
                mensajeAlerta = "¿Desea guardar los cambios de la especialidad?";
            }
            else
            {
                mensajeAlerta = "¿Desea guardar los cambios de la especialidad?";
            }

            DialogResult result = MessageBox.Show(mensajeAlerta, "Confirmar cambios", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                var resultValidation = validator.Validate(Especialidad);
                if (resultValidation.IsValid)
                {
                    EspecialidadLogic.Save(Especialidad);
                    if (Modo == ModoForm.Alta)
                    {
                        notifyIcon1.ShowBalloonTip(1000, "Crear especialidad", $"Se ha creado la especialidad correctamente", ToolTipIcon.Info);
                    }
                    else
                    {
                        notifyIcon1.ShowBalloonTip(1000, "Editar especialidad", $"Se han guardado los cambios correctamente", ToolTipIcon.Info);
                    }
                    this.masterForm.OpenForm(new Especialidades());
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
            DialogResult result = MessageBox.Show("¿Desea borrar la especialidad?", "Borrar especialidad", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                try
                {
                    EspecialidadLogic.Delete((int)Especialidad.Id);
                    notifyIcon1.ShowBalloonTip(1000, "Borrar especialidad", "Se ha borrado la especialidad correctamente", ToolTipIcon.Info);
                    masterForm.OpenForm(new Especialidades());
                    this.Close();
                }
                catch (DeleteCFReferenciadaException ex)
                {
                    notifyIcon1.ShowBalloonTip(1000, "Borrar especialidad", ex.Message, ToolTipIcon.Error);
                }
            }
        }

        private void EspecialidadDesktop_Load(object sender, EventArgs e)
        {
            Especialidad ??= new Especialidad();
        
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            masterForm.OpenForm(new Especialidades());
            this.Close();
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

    }
}
