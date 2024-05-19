using Accord.Controls;
using Accord.IO;
using Business.Entities;
using Business.Logic;
using FastReport;
using FastReport.Export;

using FastReport.Export.PdfSimple;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FastReport.ReporteCursos;
using static UI.Desktop.ApplicationForm;

namespace UI.Desktop
{
    [Serializable]
    public partial class Cursos : ApplicationForm
    {
        private CursoLogic CursoLogic => new();

        private MasterForm MasterForm => this.MdiParent as MasterForm;
        public Cursos()
        {
            InitializeComponent();
            this.dgvCursos.AllowNestedProperties(true);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dgvCursos.DataSource = CursoLogic.GetAll();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.MasterForm.OpenForm(new Inicio());
        }

        private void Cursos_Load(object sender, EventArgs e)
        {
            dgvCursos.AutoGenerateColumns = false;
            dgvCursos.DataSource = CursoLogic.GetAll();
        }

        private void tsNuevo_Click(object sender, EventArgs e)
        {
            var form = new CursoDesktop(ModoForm.Alta);
            MasterForm.OpenForm(form);
        }

        private void dgvCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCursos.CurrentCell.OwningColumn.Name == "Editar")
            {
                Curso curso = dgvCursos.SelectedRows[0].DataBoundItem as Curso;
                var form = new CursoDesktop(curso.Id, ModoForm.Modificacion);
                this.MasterForm.OpenForm(form);
            }

            else if (dgvCursos.CurrentCell.OwningColumn.Name == "Eliminar")
            {
                Curso curso = dgvCursos.SelectedRows[0].DataBoundItem as Curso;
                var form = new CursoDesktop(curso.Id, ModoForm.Baja);
                this.MasterForm.OpenForm(form);
            }
            else if (dgvCursos.CurrentCell.OwningColumn.Name == "Reporte")
            {

                Curso curso = dgvCursos.SelectedRows[0].DataBoundItem as Curso;
                var cursoReporte = CursoLogic.GetOneReporte(curso.Id);
                var rep = new ReporteCursos();
                rep.Especialidad = cursoReporte.Materia.Plan.Especialidad.Descripcion;
                rep.Plan = cursoReporte.Materia.Plan.Descripcion;
                rep.Materia = cursoReporte.Materia.Descripcion;
                rep.Comision = cursoReporte.Comision.Descripcion;
                rep.AlumnoList = new();
                foreach (var item in cursoReporte.Inscriptos)
                {
                    var alumno = new Alumnos() { Apellido = item.Alumno.Apellido, Nombre = item.Alumno.Nombre, Email = item.Alumno.Email, Legajo = item.Alumno.Legajo };
                    rep.AlumnoList.Add(alumno);
                }
                MemoryStream ms = new();
                var pdfsimple = new PDFSimpleExport();
                rep.Prepare();
                rep.Export(pdfsimple, ms);
                rep.FileName = $"Curso_{curso.Comision.Descripcion}_{curso.Materia.Descripcion}.pdf";
                saveFileDialog1.FileName = $"Curso_{curso.Comision.Descripcion}_{curso.Materia.Descripcion}.pdf";
                var result = saveFileDialog1.ShowDialog();
               
                if (result == DialogResult.OK)
                {
                    File.WriteAllBytes(saveFileDialog1.FileName, ms.ToArray());
                    notifyIcon1.ShowBalloonTip(1000, "Reporte del curso", $"Se creado y guardado el reporte del curso", ToolTipIcon.Info);
                }




            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
