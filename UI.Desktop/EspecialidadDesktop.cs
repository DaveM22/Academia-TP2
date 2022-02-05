using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class EspecialidadDesktop : ApplicationForm
    {
        private BindingSource dataSource;
        private EspecialidadLogic EspecialidadLogic => new();
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
            btnAceptar.Text = "Eliminar";
            txtDescripcion.ReadOnly = true;
            Text = "Borrar especialidad";
        }

        private void NewDescription()
        {
            Text = "Crear especialidad";
        }

        private void EditDescription()
        {
            lblTitulo.Text = "Modificar especialidad";
            Text = "Modificar especialidad";
        }

        private void Save()
        {
            DialogResult result = MessageBox.Show("¿Desea guardar los cambios de la especialidad?", "Confirmar cambios", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                EspecialidadLogic.Save(Especialidad);
                MessageBox.Show($"Se ha creado la especialidad: {Especialidad.Descripcion}","Crear especialidad",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void Delete()
        {
            DialogResult result = MessageBox.Show("¿Desea borrar la especialidad?", "Eliminar especialidad", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                EspecialidadLogic.Delete(Especialidad.Id);
                this.Close();
            }
        }

        private List<string> Validate()
        {
            List<string> errors = new();
            if(txtDescripcion.Text?.Length == 0)
            {
                errors.Add("Descripción");
            }
            return errors;
        }



        private void EspecialidadDesktop_Load(object sender, EventArgs e)
        {
            dataSource = new BindingSource { Especialidad };
            txtDescripcion.DataBindings.Add("Text", dataSource, nameof(Especialidad.Descripcion));
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var errors = Validate();
            if(errors.Count == 0)
            {
                Especialidad = (Especialidad)dataSource.Current;
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
            else
            {
                string error = "Los siguientes campos son requeridos:";
                errors.ForEach(x => error += "\n" + x);
                MessageBox.Show(error, "Error al guardar especialidad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
