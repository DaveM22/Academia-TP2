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

        private List<Curso> Cursos { get; set; }

        public int IdPlan { get; set; }

        public CursosSearchForm()
        {
            InitializeComponent();
        }

        public CursosSearchForm(int idPlan) : this()
        {
            IdPlan = idPlan;
        }

        private void CursosSearchForm_Load(object sender, EventArgs e)
        {
            CursoLogic = new CursoLogic();
            Cursos = CursoLogic.GetAllByPlan(IdPlan);
            dgvCursos.AutoGenerateColumns = false;
            dgvCursos.DataSource = Cursos;
        }
    }
}
