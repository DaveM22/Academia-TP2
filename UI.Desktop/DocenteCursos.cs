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

        public MasterForm Mast => this.MdiParent as MasterForm;
        public DocenteCursos()
        {
            InitializeComponent();
        }

        private void DocenteCursos_Load(object sender, EventArgs e)
        {
            DocenteCursoLogic = new DocenteCursoLogic();
            dgvDocenteCursos.AutoGenerateColumns = false;
            dgvDocenteCursos.DataSource = DocenteCursoLogic.GetDocenteCursos();
        }

        private void tsNuevo_Click(object sender, EventArgs e)
        {
            var form = new DocenteCursoDesktop(ModoForm.Alta);
            Mast.OpenForm(form);
        }

        private void dgvDocenteCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDocenteCursos.CurrentCell.OwningColumn.Name == "Editar")
            {
                int id = (int)dgvDocenteCursos.CurrentRow.Cells[0].Value;
                var form = new DocenteCursoDesktop(id, ModoForm.Modificacion);
                Mast.OpenForm(form);
            }
        }
    }
}
