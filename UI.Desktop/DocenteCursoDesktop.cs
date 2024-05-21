using Business.Entities;
using Business.Logic;
using Business.Util;
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
    public partial class DocenteCursoDesktop : ApplicationForm
    {

        private Persona PersonaSeleccionada { get; set; }
        private Curso CursoSeleccionado { get; set; }
        private DocenteCurso DocenteCurso { get; set; }
        private DocenteCursoLogic DocenteCursoLogic { get; set; }
        private MasterForm Mast => this.MdiParent as MasterForm;

        private int IdDocenteCurso { get; set; }
        public DocenteCursoDesktop()
        {
            InitializeComponent();
        }

        public DocenteCursoDesktop(ModoForm modo) : this()
        {
            Modo = modo;
        }

        public DocenteCursoDesktop(int id, ModoForm modo) : this()
        {
            IdDocenteCurso = id;
            Modo = modo;
            if (Modo == ModoForm.Baja)
            {
                btnDocente.Visible = false;
                btnCursos.Visible = false;
                btnGuardar.Text = "Borrar";
                cbCargos.Enabled = false;
                lblTitulo.Text = "Borrar asignación de curso";
            }
        }

        private void btnDocente_Click(object sender, EventArgs e)
        {
            var form = new DocenteSearchForm();
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                PersonaSeleccionada = form.DocenteSeleccionado;
                txtDocente.Text = $"{PersonaSeleccionada.Legajo} - {PersonaSeleccionada.Apellido}, {PersonaSeleccionada.Nombre}";
            }
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            var form = new CursosSearchForm(this.PersonaSeleccionada.Id);
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.CursoSeleccionado = form.Curso;
                this.txtCurso.Text = $"{CursoSeleccionado.Comision.Descripcion} - {CursoSeleccionado.Materia.Descripcion}";
            }
        }

        private void txtDocente_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDocente.Text))
            {
                btnCursos.Enabled = false;
            }
            else
            {
                btnCursos.Enabled = true;
            }
        }

        private void DocenteCursoDesktop_Load(object sender, EventArgs e)
        {
            DocenteCursoLogic = new DocenteCursoLogic();
            cbCargos.DataSource = Enum.GetValues(typeof(DocenteCargoEnum));
            if (ModoForm.Alta == Modo)
            {
                cbCargos.SelectedItem = null;
                cbCargos.SelectedText = "Seleccionar un cargo";
            }
            else
            {
                DocenteCurso = DocenteCursoLogic.GetOne(IdDocenteCurso);
                PersonaSeleccionada = DocenteCurso.Docente;
                CursoSeleccionado = DocenteCurso.Curso;
                cbCargos.SelectedItem = DocenteCurso.DocenteCargo;
                txtDocente.Text = $"{PersonaSeleccionada.Legajo} - {PersonaSeleccionada.Apellido}, {PersonaSeleccionada.Nombre}";
                txtCurso.Text = $"{CursoSeleccionado.Comision.Descripcion} - {CursoSeleccionado.Materia.Descripcion}";
            }


            if (string.IsNullOrEmpty(txtDocente.Text))
            {
                btnCursos.Enabled = false;
            }
            else
            {
                btnCursos.Enabled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Desea realmente salir sin guardar los cambios?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                Mast.OpenForm(new DocenteCursos());
                this.Dispose();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {



            if (DocenteCurso == null)
            {
                DocenteCurso = new DocenteCurso();
                DocenteCurso.DocenteId = PersonaSeleccionada.Id;
                DocenteCurso.CursoId = CursoSeleccionado.Id;
                DocenteCurso.DocenteCargo = (Business.Entities.Enums.DocenteCargoEnum)(DocenteCargoEnum)cbCargos.SelectedValue;
            }
            else
            {

                DocenteCurso.DocenteId = PersonaSeleccionada.Id;
                DocenteCurso.CursoId = CursoSeleccionado.Id;
                DocenteCurso.DocenteCargo = (Business.Entities.Enums.DocenteCargoEnum)(DocenteCargoEnum)cbCargos.SelectedValue;
            }

            if (Modo == ModoForm.Baja)
            {
                DocenteCursoLogic.Delete(DocenteCurso.Id);
            }
            else
            {
                DocenteCursoLogic.Save(DocenteCurso);
            }

            this.Mast.OpenForm(new DocenteCursos());
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
