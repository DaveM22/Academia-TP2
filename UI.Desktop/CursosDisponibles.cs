using Accord.Controls;
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
    public partial class CursosDisponibles : ApplicationForm
    {
        private MasterForm MasterForm => this.MdiParent as MasterForm;
        private CursoLogic CursoLogic => new CursoLogic();

        private int MateriaId { get; set; }

        private int PlanId { get; set; }

        private int AlumnoId { get; set; }

        public CursosDisponibles()
        {
            InitializeComponent();
        }


        public CursosDisponibles(int materiaId, int planId, int idAlumno) : this()
        {
            this.dgvCursosDisponibles.AutoGenerateColumns = false;
            this.dgvCursosDisponibles.AllowNestedProperties(true);
            this.MateriaId = materiaId;
            this.PlanId = planId;
            this.AlumnoId = idAlumno;
        }

        private void dgvCursosDisponibles_Paint(object sender, PaintEventArgs e)
        {
            if (dgvCursosDisponibles.Rows.Count == 0)
                TextRenderer.DrawText(e.Graphics, "No hay cursos disponibles para esta materia.",
                    dgvCursosDisponibles.Font, dgvCursosDisponibles.ClientRectangle,
                    dgvCursosDisponibles.ForeColor, dgvCursosDisponibles.BackgroundColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        private void CursosDisponibles_Load(object sender, EventArgs e)
        {
            this.dgvCursosDisponibles.DataSource = this.CursoLogic.GetAllByPlandAndMateria(PlanId, MateriaId);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.MasterForm.OpenForm(new MateriasAlumno(AlumnoId, PlanId));
        }
    }
}
