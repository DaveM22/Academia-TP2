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
    public partial class CursoDesktop : ApplicationForm
    {
        private BindingSource dataSource;
        private Curso Curso { get; set; }
        private CursoLogic CursoLogic => new();
        private MateriaLogic MateriaLogic => new();

        private ComisionLogic ComisionLogic => new();

        public CursoDesktop()
        {
            InitializeComponent();
        }

        public CursoDesktop(ModoForm modo) : this()
        {
            Modo = modo;
            Curso = new();
            NewDescription();
        }

        public CursoDesktop(int id, ModoForm modo) : this()
        {
            Modo = Modo;
            Curso = CursoLogic.GetOne(id);
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
            Curso = dataSource.Current as Curso;
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
            this.Close();
        }

        private void DeleteDescription()
        {
            btnAceptar.Text = "Eliminar";
            cmbComision.Enabled = false;
            cmbMateria.Enabled = false;
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
            DialogResult result = MessageBox.Show("¿Desea guardar los cambios del cuso?", "Confirmar cambios", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                CursoLogic.Save(Curso);
                this.Close();
            }
        }

        private void Delete()
        {
            DialogResult result = MessageBox.Show("¿Desea borrar el curso?", "Eliminar curso", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                ComisionLogic.Delete(Curso.Id);
                this.Close();
            }
        }

        private void CursoDesktop_Load(object sender, EventArgs e)
        {
            cmbComision.DataSource = ComisionLogic.GetAll();
            dataSource = new BindingSource { Curso };
            cmbMateria.DataBindings.Add("SelectedValue", dataSource, nameof(Curso.MateriaId));
            cmbComision.DataBindings.Add("SelectedValue", dataSource, nameof(Curso.ComisionId));
            nudAnioCalendario.DataBindings.Add("Value", dataSource, nameof(Curso.AnioCalendario));
            nudCupo.DataBindings.Add("Value", dataSource, nameof(Curso.Cupo));
        }

        private void cmbComision_SelectedIndexChanged(object sender, EventArgs e)
        {
            var current = cmbComision.SelectedItem as Comision;
            if(current != null)
                cmbMateria.DataSource = MateriaLogic.GetAllByPlan(current.PlanId);
        }
    }
}
