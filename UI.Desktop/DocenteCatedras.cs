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
    public partial class DocenteCatedras : Form
    {

        private DocenteCursoLogic PersonaLogic => new DocenteCursoLogic();

        private int PersonaId { get; set; }
        public DocenteCatedras()
        {
            InitializeComponent();
        }

        public DocenteCatedras(int personaId) : this()
        {
            this.PersonaId = personaId;
        }

        private void DocenteCatedras_Load(object sender, EventArgs e)
        {
            this.dgvCatedras.AutoGenerateColumns = false;
            this.dgvCatedras.AllowNestedProperties(true);
            this.dgvCatedras.DataSource = this.PersonaLogic.GetDocenteCursos(this.PersonaId);
        }
    }
}
