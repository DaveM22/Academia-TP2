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
    public partial class MateriasAlumno : ApplicationForm
    {

        private MateriaLogic MateriaLogic => new MateriaLogic();

        private MasterForm MasterForm => this.MdiParent as MasterForm;

        private int IdAlumno { get; set; }

        private int IdPlan { get; set; }

        public MateriasAlumno()
        {
            InitializeComponent();
        }


        public MateriasAlumno(int idAlumno, int idPlan) : this()
        {
            this.IdAlumno = idAlumno;
            this.IdPlan = idPlan;
            this.dgvMaterias.AutoGenerateColumns = false;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.MasterForm.OpenForm(new Inicio());
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.dgvMaterias.DataSource = this.MateriaLogic.MateriaAlumno(IdAlumno, IdPlan);
        }

        private void MateriasAlumno_Load(object sender, EventArgs e)
        {
            this.dgvMaterias.DataSource = this.MateriaLogic.MateriaAlumno(IdAlumno, IdPlan);
        }

        private void dgvMaterias_CellClick(object sender, DataGridViewCellEventArgs e)
        {



            if (dgvMaterias.CurrentCell.OwningColumn.Name == "Cursos")
            {
                Materia mat = dgvMaterias.SelectedRows[0].DataBoundItem as Materia;
                var form = new CursosDisponibles(mat.Id, mat.PlanId, IdAlumno);
                MasterForm.OpenForm(form);
                this.Close();
            }

        }
    }
}
