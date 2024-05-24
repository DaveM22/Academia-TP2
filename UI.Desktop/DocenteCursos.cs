using Accord.Collections;
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
    public partial class DocenteCursos : ApplicationForm
    {
        private DocenteCursoLogic DocenteCursoLogic { get; set; }

        private CursoLogic CursoLogic => new CursoLogic();
        private int CursoId { get; set; }

        public MasterForm Mast => this.MdiParent as MasterForm;
        public DocenteCursos()
        {
            InitializeComponent();
        }

        public DocenteCursos(int cursoId) : this()
        {
            this.CursoId = cursoId;
        }
            

        private void DocenteCursos_Load(object sender, EventArgs e)
        {
            DocenteCursoLogic = new DocenteCursoLogic();
            dgvDocenteCursos.AutoGenerateColumns = false;
            var curso = this.CursoLogic.GetOne(CursoId);
            dgvDocenteCursos.DataSource = curso.DocenteCursos;
        }

        private void tsNuevo_Click(object sender, EventArgs e)
        {
            var form = new DocenteCursoDesktop(ModoForm.Alta);
            Mast.OpenForm(form);
        }

        private void dgvDocenteCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDocenteCursos.CurrentCell.OwningColumn.Name == "Borrar")
            {
                int id = (int)dgvDocenteCursos.CurrentRow.Cells[0].Value;
                var form = new DocenteCursoDesktop(id, ModoForm.Baja);
                Mast.OpenForm(form);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Mast.OpenForm(new CatedrasDocentes());
        }
    }
}
