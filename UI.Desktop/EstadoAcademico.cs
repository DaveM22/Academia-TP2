using Accord.Collections;
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
    public partial class EstadoAcademico : ApplicationForm
    {
        private PersonaLogic PersonaLogic => new PersonaLogic();
        private AlumnoInscripcionLogic AlumnoInscripcionLogic => new AlumnoInscripcionLogic();

        private int AlumnoId { get; set; }

        private MasterForm MasterForm => this.MdiParent as MasterForm;

        public EstadoAcademico()
        {
            InitializeComponent();
            this.dgvEstadoAcademico.AutoGenerateColumns = false;
            this.dgvEstadoAcademico.AllowNestedProperties(true);
        }

        public EstadoAcademico(int personaId) : this()
        {
            this.AlumnoId = personaId;
            var alumno = this.PersonaLogic.GetOne(personaId);
            this.lblTitulo.Text = $"Estado académico de {alumno.Apellido}, {alumno.Nombre} al {DateTime.Now}";
        }

        private void EstadoAcademico_Load(object sender, EventArgs e)
        {
            this.dgvEstadoAcademico.DataSource = this.AlumnoInscripcionLogic.GetAllByAlumno(this.AlumnoId);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.MasterForm.OpenForm(new Inicio());
        }
    }
}
