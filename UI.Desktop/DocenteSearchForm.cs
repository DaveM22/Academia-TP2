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
    public partial class DocenteSearchForm : Form
    {
        private PersonaLogic PersonaLogic { get; set; }

        private List<Persona> Docentes { get; set; }

        public Persona DocenteSeleccionado { get; set; }

        public DocenteSearchForm()
        {
            InitializeComponent();
        }

      
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Dispose();
        }

        private void DocenteSearchForm_Load(object sender, EventArgs e)
        {
            PersonaLogic = new PersonaLogic();
            Docentes = PersonaLogic.GetPersonas(Business.Util.TipoPersonaEnum.PROFESOR);
            dgvDocente.AutoGenerateColumns = false; 
            dgvDocente.DataSource = Docentes;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            DocenteSeleccionado = dgvDocente.SelectedRows[0].DataBoundItem as Persona;
            this.DialogResult = DialogResult.OK;
        }
    }
}
