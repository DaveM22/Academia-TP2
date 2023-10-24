using Business.Entities;
using Business.Entities.Enums;
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
    public partial class AlumnoSearchForm : ApplicationForm
    {
        private PersonaLogic PersonaLogic { get; set; }
        private List<Persona> AlumnosList { get; set; }
        public AlumnoSearchForm()
        {
            InitializeComponent();
        }

        private void AlumnoSearchForm_Load(object sender, EventArgs e)
        {
            this.PersonaLogic = new PersonaLogic();
            this.AlumnosList = this.PersonaLogic.GetPersonas(TipoPersonaEnum.ALUMNO).OrderBy(x => x.Legajo).ToList();
            this.dgvAlumnos.DataSource = this.AlumnosList;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.dgvAlumnos.DataSource = this.AlumnosList.Where(x => x.Legajo == (int)this.numericUpDown1.Value).ToList();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
