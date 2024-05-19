using Accord.IO;
using Business.Entities;
using Business.Logic;
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

        public MateriaLogic MateriaLogic => new MateriaLogic();

        private MasterForm MasterForm => this.MdiParent as MasterForm;


        private string MENSAJE_EXITO_CREAR(string materia) => $"Se ha creado la materia: {materia}";

        private string MENSAJE_EXITO_EDITAR(string materia) => $"Se han guardado los cambios de la materia: {materia}";

        private string MENSAJE_EXITO_BORRAR(string materia) => $"Se ha eliminado la materia: {materia}"; 

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
            this.PlanId = this.Materia.PlanId;
            
            if (Modo == ModoForm.Modificacion)
            {
                this.lblTitulo.Text = "Modificar materia";
            }
            else
            {
                this.lblTitulo.Text = "Eliminar materia";
                this.btnGuardar.Text = "Eliminar";
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
                Materia.PlanId = this.PlanId;
            }
            else if (Modo == ModoForm.Modificacion)
            {
                Materia.Descripcion = txtMateria.TextBox.Text;
                Materia.HSSemanales = Convert.ToInt32(this.nudHsSemanales.NumericUpDown.Value);
                Materia.HSTotales = Convert.ToInt32(this.nudHsTotales.NumericUpDown.Value);

            }

            if (Modo == ModoForm.Alta || Modo == ModoForm.Modificacion)
            {
                var resultValidation = Validator.Validate(Materia);
                if (resultValidation.IsValid)
                {

                    this.MateriaLogic.Guardar(Materia);
                    if(Modo == ModoForm.Alta)
                    {
                        niAlerta.ShowBalloonTip(1000, lblTitulo.Text, MENSAJE_EXITO_CREAR(Materia.Descripcion), ToolTipIcon.Info);
                    }
                    else
                    {
                        niAlerta.ShowBalloonTip(1000, lblTitulo.Text, MENSAJE_EXITO_EDITAR(Materia.Descripcion), ToolTipIcon.Info);
                    }

                    this.MasterForm.OpenForm(new Materias(PlanId));
                    this.Close();
                }
                else
                {
                    this.MapearErrores(resultValidation);
                }
            }
            else
            {
                Borrar();
            }
        }


        private void Borrar()
        {
            DialogResult result = MessageBox.Show("¿Desea borrar la materia?", "Eliminar materia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                try
                {
                    this.MateriaLogic.Borrar(Materia.Id);
                    niAlerta.ShowBalloonTip(1000, lblTitulo.Text, MENSAJE_EXITO_BORRAR(Materia.Descripcion), ToolTipIcon.Info);
                    this.MasterForm.OpenForm(new Materias(PlanId));
                }
                catch (Exception ex)
                {
                    notifyIcon1.ShowBalloonTip(1000, "Borrar materia", ex.Message, ToolTipIcon.Error);
                }
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.MasterForm.OpenForm(new Materias(PlanId));
            this.Close();
        }

        private void MateriaDesktop_Load(object sender, EventArgs e)
        {
            if (Modo == ModoForm.Alta)
            {
                this.lblTitulo.Text = "Crear materia";
            }
            if (Modo == ModoForm.Modificacion)
            {
                txtMateria.TextBox.Text = Materia.Descripcion;
                nudHsSemanales.NumericUpDown.Value = Materia.HSSemanales;
                nudHsTotales.NumericUpDown.Value = Materia.HSTotales;
            }
            if (Modo == ModoForm.Baja)
            {
                txtMateria.TextBox.Text = Materia.Descripcion;
                nudHsSemanales.NumericUpDown.Value = Materia.HSSemanales;
                nudHsTotales.NumericUpDown.Value = Materia.HSTotales;
                txtMateria.TextBox.Enabled = false;
                nudHsSemanales.NumericUpDown.Enabled = false;
                nudHsTotales.NumericUpDown.Enabled = false;
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

        private void tlpMateria_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
