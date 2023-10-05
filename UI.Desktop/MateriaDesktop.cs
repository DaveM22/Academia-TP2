using Business.Entities;
using Business.Util.Exceptions;
using Business.Util.ValidatorsDesktop;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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

        public MateriaValidator Validator => new MateriaValidator();

        private MasterForm MasterForm => this.MdiParent as MasterForm;


        private int PlanId { get; set; }

        public MateriaDesktop()
        {
            InitializeComponent();
        }

        public MateriaDesktop(ModoForm modo, int planId) : this()
        {
            Modo = modo;
            this.PlanId = planId;
        }

        public MateriaDesktop(Materia materia, ModoForm modo) : this()
        {
            Modo = modo;
            Materia = materia;
            if(Modo == ModoForm.Modificacion)
            {
                this.lblTitulo.Text = "Modificar materia";
            }
            else
            {
                this.lblTitulo.Text = "Eliminar materia";
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (Modo == ModoForm.Alta)
            {
                Materia = new Materia();
                Materia.Descripcion = txtMateria.TextBox.Text;
                Materia.HSSemanales = Convert.ToInt32(this.nudHsSemanales.NumericUpDown.Value);
                Materia.HSTotales = Convert.ToInt32(this.nudHsSemanales.NumericUpDown.Value);
            }
            else
            {
                Materia.Descripcion = txtMateria.Text;
                Materia.HSSemanales = Convert.ToInt32(this.nudHsSemanales.NumericUpDown.Value);
                Materia.HSTotales = Convert.ToInt32(this.nudHsTotales.NumericUpDown.Value);

            }

            var resultValidation = Validator.Validate(Materia);
            if (resultValidation.IsValid)
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                this.MapearErrores(resultValidation);
            }



        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.MasterForm.OpenForm(new Materias(PlanId));
            this.Close();
        }

        private void MateriaDesktop_Load(object sender, EventArgs e)
        {
            if(Modo == ModoForm.Alta)
            {
                this.lblTitulo.Text = "Crear materia";
            }
            if (Modo == ModoForm.Modificacion)
            {
                txtMateria.TextBox.Text = Materia.Descripcion;
                nudHsSemanales.NumericUpDown.Value = Materia.HSSemanales;
                nudHsTotales.NumericUpDown.Value = Materia.HSTotales;
            }
        }


        private void MapearErrores(ValidationResult validaciones)
        {
            foreach (var error in validaciones.Errors)
            {
                if (error.PropertyName == nameof(Materia.Descripcion))
                {
                    this.txtMateria.LabelError.Text = error.ErrorMessage;
                }

                if (error.PropertyName == nameof(Materia.HSSemanales))
                {
                    this.nudHsSemanales.LabelError.Text = error.ErrorMessage;
                }

                if (error.PropertyName == nameof(Materia.HSTotales))
                {
                    this.nudHsTotales.LabelError.Text = error.ErrorMessage;
                }
            }
        }
    }
}
