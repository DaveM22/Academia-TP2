using Business.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class MateriaDesktop : ApplicationForm
    {
        public Materia Materia { get; set; }

        public MateriaDesktop()
        {
            InitializeComponent();
        }

        public MateriaDesktop(ModoForm modo)
        {
            Modo = modo;
        }

        public MateriaDesktop(Materia materia, ModoForm modo) : this()
        {
            Modo = modo;
            Materia = materia;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(Modo == ModoForm.Alta)
            {
                var materia = new Materia();
                materia.Descripcion = txtMateria.Text;
                materia.HSSemanales = Convert.ToInt32(this.nudHsSemanales.Value);
                materia.HSTotales = Convert.ToInt32(this.nudHsSemanales.Value);
                DialogResult = DialogResult.OK;
                Materia = materia;
            }
            else
            {
                Materia.Descripcion = txtMateria.Text;
                Materia.HSSemanales = Convert.ToInt32(this.nudHsSemanales.Value);
                Materia.HSTotales = Convert.ToInt32(this.nudHsTotales.Value);
                DialogResult = DialogResult.OK;
            }

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void MateriaDesktop_Load(object sender, EventArgs e)
        {
            if(Modo == ModoForm.Modificacion)
            {
                txtMateria.Text = Materia.Descripcion;
                nudHsSemanales.Value = Materia.HSSemanales;
                nudHsTotales.Value = Materia.HSTotales;
            }
        }
    }
}
