using System;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class MasterForm : ApplicationForm
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
            OpenForm(new Cursos());
        }

        private void especialidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new Especialidades());
        }

        private void comisionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new Comisiones());
        }

        private void inscripcionDeDocenteACursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new DocenteCursos());
        }


        public void OpenForm(ApplicationForm form)
        {
            form.TopLevel = false;
            form.TopMost = true;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            pnlMenu.Controls.Clear();
            pnlMenu.Controls.Add(form);
            form.Show();
        }

        private void planesYMateriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new Planes());
        }
    }
}
