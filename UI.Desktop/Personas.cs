using Business.Entities;
using Business.Logic;
using Business.Util;
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

        public Personas()
        {
            InitializeComponent();
        }

        public Personas(TipoPersonaEnum tipoPersona) : this()
        {
            TipoPersona = tipoPersona;
            PersonaList = PersonaLogic.GetPersonas(TipoPersona);
            if(TipoPersona == TipoPersonaEnum.PROFESOR)
            {
                this.Text = "Profesores";
            }
            else
            {
                this.Text = "Alumnos";
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dgvPersonas.DataSource = PersonaLogic.GetPersonas(TipoPersona);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Personas_Load(object sender, EventArgs e)
        {
            dgvPersonas.AutoGenerateColumns = false;
            dgvPersonas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPersonas.DataSource = PersonaList;
        }

        private void dgvPersonas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var cell = (DataGridViewCell)sender;
           
        }
    }
}
