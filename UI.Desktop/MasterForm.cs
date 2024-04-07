using Business.Data;
using Business.Entities;
using Business.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class MasterForm : ApplicationForm
    {

        private ApplicationForm Form { get; set; }

        private List<string> Autorizacion { get; set; }

        public MasterForm()
        {
            InitializeComponent();
            Master = this;
         
        }

        public MasterForm(Usuario usuario) : base()
        {
            InitializeComponent();
            Master = this;
            UsuarioActual = usuario;
            this.Autorizacion = new List<string>();
            Permisos();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new Personas((Business.Entities.Enums.TipoPersonaEnum)TipoPersonaEnum.ALUMNO));
        }

        private void profesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new Personas(TipoPersonaEnum.PROFESOR));
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
            if (Form != null)
            {
                Form.Close();
            }

            Form = form;
            Form.MdiParent = this;
            Form.FormBorderStyle = FormBorderStyle.None;
            Form.Dock = DockStyle.Fill;
            Form.Show();
        }

        private void planesYMateriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new Planes());
        }

        private void especialidadesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var form = new Especialidades();
            form.FormBorderStyle = FormBorderStyle.None;
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void tsmPlanes_Click(object sender, EventArgs e)
        {
            this.OpenForm(new Planes());
        }

        private void tsmProfesores_Click(object sender, EventArgs e)
        {
            this.OpenForm(new Personas(TipoPersonaEnum.PROFESOR));
        }

        private void tsmComisiones_Click(object sender, EventArgs e)
        {
            this.OpenForm(new Comisiones());
        }

        private void tsmCursos_Click(object sender, EventArgs e)
        {
            this.OpenForm(new Cursos());
        }

        private void tsmAlumnos_Click(object sender, EventArgs e)
        {
            this.OpenForm(new Personas(TipoPersonaEnum.ALUMNO));
        }

        private void tsInscripciones_Click(object sender, EventArgs e)
        {
            this.OpenForm(new Inscripciones());
        }

        private void tsProfesoresCursos_Click(object sender, EventArgs e)
        {
            this.OpenForm(new DocenteCursos());
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.OpenForm(new Usuarios());
        }

        private void Permisos()
        {
            foreach (var item in UsuarioActual.Modulos)
            {
                Autorizacion.Add(item.Modulo.Ejecuta);
            }


        }



        private void MasterForm_Load(object sender, EventArgs e)
        {
           
        }
    }
}
