using Accord.Controls;
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
    public partial class CursosSearchForm : ApplicationForm
    {

        private CursoLogic CursoLogic { get; set; }

        public Curso Curso { get; set; }

        private List<Curso> Cursos { get; set; }

        public int IdAlumno { get; set; }

        public int IdProfesor { get; set; }

        public CursosSearchForm()
        {
            InitializeComponent();
            this.dgvCursos.AllowNestedProperties(true);
        }

        public CursosSearchForm(int idProfesor, bool cargaMultiple = false) : this()
        {
            this.IdProfesor = idProfesor;
            this.dgvCursos.MultiSelect = cargaMultiple;
            CursoLogic = new CursoLogic();
            Cursos = CursoLogic.GetAllByPlanYDisponibleDocente(this.IdProfesor);
        }

        public CursosSearchForm(int idPlan, int idAlumno, bool cargaMultiple = false) : this()
        {
            IdAlumno = idAlumno;
            this.dgvCursos.MultiSelect = cargaMultiple;
            CursoLogic = new CursoLogic();
            //Cursos = CursoLogic.GetAllByPlanYDisponible(this.IdPlan, this.IdAlumno);

        }

        private void CursosSearchForm_Load(object sender, EventArgs e)
        {
            dgvCursos.AutoGenerateColumns = false;
            dgvCursos.DataSource = Cursos;


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (!this.dgvCursos.MultiSelect)
            {
                DialogResult = DialogResult.OK;
                Curso = dgvCursos.SelectedRows[0].DataBoundItem as Curso;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Cursos = dgvCursos.SelectedRows.Cast<Curso>().ToList();
            }

            this.Close();
        }

        private void dgvCursos_Paint(object sender, PaintEventArgs e)
        {
            if (dgvCursos.Rows.Count == 0)
                TextRenderer.DrawText(e.Graphics, "No hay cursos disponible para el alumno.",
                    dgvCursos.Font, dgvCursos.ClientRectangle,
                    dgvCursos.ForeColor, dgvCursos.BackgroundColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
    }
}
