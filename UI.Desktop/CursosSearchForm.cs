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

        public int IdPlan { get; set; }

        public CursosSearchForm()
        {
            InitializeComponent();
        }

        public CursosSearchForm(int idPlan, bool cargaMultiple = false) : this()
        {
            IdPlan = idPlan;
            this.dgvCursos.MultiSelect = cargaMultiple;
        }

        private void CursosSearchForm_Load(object sender, EventArgs e)
        {
            CursoLogic = new CursoLogic();
            Cursos = CursoLogic.GetAllByPlan(IdPlan);
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
    }
}
