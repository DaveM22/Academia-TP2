using Accord.Controls;
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
    public partial class Personas : ApplicationForm
    {
        private List<Persona> PersonaList { get; set; }

        private PersonaLogic PersonaLogic => new();

        private TipoPersonaEnum TipoPersona { get; set; }

        private MasterForm MasterForm => this.MdiParent as MasterForm;

        public Personas()
        {
            InitializeComponent();

            this.dgvPersonas.AllowNestedProperties(true);
        }

        public Personas(TipoPersonaEnum tipoPersona) : this()
        {
            TipoPersona = tipoPersona;
            PersonaList = PersonaLogic.GetPersonas(TipoPersona);
            if (TipoPersona == TipoPersonaEnum.PROFESOR)
            {
                this.lblTitulo.Text = "Profesores";
                this.Text = "Profesores";
            }
            else
            {
                this.Text = "Alumnos";
                this.lblTitulo.Text = "Alumnos";
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dgvPersonas.DataSource = PersonaLogic.GetPersonas(TipoPersona);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.MasterForm.OpenForm(new Inicio());
        }

        private void Personas_Load(object sender, EventArgs e)
        {
            if (this.TipoPersona == TipoPersonaEnum.ALUMNO)
            {
                this.tsNuevo.Text = "Nuevo alumno";
            }
            else
            {
                this.tsNuevo.Text = "Nuevo profesor";
            }
            dgvPersonas.AutoGenerateColumns = false;
            dgvPersonas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPersonas.DataSource = PersonaList;
        }

        private void dgvPersonas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPersonas.CurrentCell.OwningColumn.Name == "Editar")
            {
                Persona persona = dgvPersonas.SelectedRows[0].DataBoundItem as Persona;
                var form = new PersonaDesktop(persona.Id, ModoForm.Modificacion, TipoPersona);
                this.MasterForm.OpenForm(form);
            }
            else if (dgvPersonas.CurrentCell.OwningColumn.Name == "Eliminar")
            {
                Persona persona = dgvPersonas.SelectedRows[0].DataBoundItem as Persona;
                var form = new PersonaDesktop(persona.Id, ModoForm.Baja, TipoPersona);
                MasterForm.OpenForm(form);
            }
        }

        private void tsNuevo_Click(object sender, EventArgs e)
        {
            PersonaDesktop form = new(ModoForm.Alta, TipoPersonaEnum.ALUMNO);
            this.MasterForm.OpenForm(form);
        }

        private void dgvPersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
