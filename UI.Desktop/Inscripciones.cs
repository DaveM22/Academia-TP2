using Business.Entities;
using Business.Entities.Enums;
using Business.Logic;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    public partial class Inscripciones : ApplicationForm
    {
        private AlumnoInscripcionLogic AlumnoInscripcionLogic { get; set; }

        private MasterForm MasterForm => this.MdiParent as MasterForm;

        private PersonaLogic PersonaLogic => new PersonaLogic();
        public Inscripciones()
        {
            InitializeComponent();
            this.dgvAlumnos.AutoGenerateColumns = false;
        }

        private void AlumnoInscripciones_Load(object sender, EventArgs e)
        {
            this.dgvAlumnos.DataSource = this.PersonaLogic.GetPersonas(TipoPersonaEnum.ALUMNO);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.MasterForm.OpenForm(new Inicio());
        }

        private void dgvAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvAlumnos.CurrentCell.OwningColumn.Name == "Cursos")
            {
                Persona per = dgvAlumnos.SelectedRows[0].DataBoundItem as Persona;
                var form = new AlumnoInscripciones(per.Id);
                this.MasterForm.OpenForm(form);
            }
        }


    }
}
