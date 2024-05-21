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
    public partial class DocenteCatedras : ApplicationForm
    {

        private DocenteCursoLogic PersonaLogic => new DocenteCursoLogic();

        private MasterForm MasterForm => this.MdiParent as MasterForm;

        private int PersonaId { get; set; }
        public DocenteCatedras()
        {
            InitializeComponent();
        }

        public DocenteCatedras(int personaId) : this()
        {
            this.PersonaId = personaId;
        }

        private void DocenteCatedras_Load(object sender, EventArgs e)
        {
            this.dgvCatedras.AutoGenerateColumns = false;
            this.dgvCatedras.AllowNestedProperties(true);
            this.dgvCatedras.DataSource = this.PersonaLogic.GetDocenteCursos(this.PersonaId);
        }

        private void dgvCatedras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCatedras.CurrentCell.OwningColumn.Name == "Actualizar")
            {
                DocenteCurso docenteCurso = dgvCatedras.SelectedRows[0].DataBoundItem as DocenteCurso;
                var form = new CursoAlumnos(docenteCurso.CursoId);
                MasterForm.OpenForm(form);
            }
            else if (dgvCatedras.CurrentCell.OwningColumn.Name == "Estado")
            {
                DocenteCurso docenteCurso = dgvCatedras.SelectedRows[0].DataBoundItem as DocenteCurso;
                var form = new CursoAlumnos(docenteCurso.CursoId);
                MasterForm.OpenForm(form);
            }
        }
    }
}
