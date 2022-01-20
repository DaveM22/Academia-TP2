using System;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class MasterForm : Form
    {
        public MasterForm()
        {
            InitializeComponent();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Personas(Business.Util.TipoPersonaEnum.ALUMNO);
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void profesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Personas(Business.Util.TipoPersonaEnum.PROFESOR);
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Cursos();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
