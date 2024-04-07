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
    public partial class AlumnoInscripcion : ApplicationForm
    {
        private MasterForm MasterForm => this.MdiParent as MasterForm;
        public List<Cursos> Cursos = new List<Cursos>();
        public int PersonaId { get; }
        public int PlanId { get; }

        public AlumnoInscripcion()
        {
            InitializeComponent();
        }

        public AlumnoInscripcion(int personaId, int planId) : this()
        {
            this.PersonaId = personaId;
            this.PlanId = planId;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
