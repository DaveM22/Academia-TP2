using Accord.Controls;
using Business.Entities;
using Business.Logic;
using FastReport;
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
using static FastReport.ReportePlan;

namespace UI.Desktop
{
    public partial class Planes : ApplicationForm
    {
        private PlanLogic PlanLogic => new PlanLogic();
        private MasterForm MasterForm => this.MdiParent as MasterForm;
        private List<Especialidad> EspecialidadLista = new List<Especialidad>();
        private List<Plan> PlanesLista = new List<Plan>();
        private EspecialidadLogic EspecialidadLogic => new EspecialidadLogic();

        public Planes()
        {
            InitializeComponent();
            this.dgvPlanes.AutoGenerateColumns = false;
            this.dgvPlanes.AllowNestedProperties(true);

        }

        private void tsNuevo_Click(object sender, EventArgs e)
        {
            var form = new PlanDesktop(ApplicationForm.ModoForm.Alta);
            MasterForm.OpenForm(form);
        }

        private void dgvPlanes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPlanes.CurrentCell.OwningColumn.Name == "Editar")
            {
                Plan plan = dgvPlanes.SelectedRows[0].DataBoundItem as Plan;
                var form = new PlanDesktop(plan.Id, ModoForm.Modificacion);
                MasterForm.OpenForm(form);
            }
            else if (dgvPlanes.CurrentCell.OwningColumn.Name == "Eliminar")
            {
                Plan plan = dgvPlanes.SelectedRows[0].DataBoundItem as Plan;
                var form = new PlanDesktop(plan.Id, ModoForm.Baja);
                MasterForm.OpenForm(form);
            }
            else if (dgvPlanes.CurrentCell.OwningColumn.Name == "Materias")
            {
                Plan plan = dgvPlanes.SelectedRows[0].DataBoundItem as Plan;
                var form = new Materias(plan.Id);
                MasterForm.OpenForm(form);
            }
            else if(dgvPlanes.CurrentCell.OwningColumn.Name == "Reporte")
            {
                Plan plan = dgvPlanes.SelectedRows[0].DataBoundItem as Plan;
                var planReporte = PlanLogic.GetOne(plan.Id);
                var rep = new ReportePlan();
                rep.Especialidad = planReporte.Especialidad.Descripcion;
                rep.Plan = planReporte.Descripcion;
                foreach (var item in planReporte.Materias)
                {
                    var materia = new ReportePlan.Materia() { Descripcion = item.Descripcion, HorasSemanales = item.HSSemanales, HorasTotales = item.HSTotales };
                    rep.Materias.Add(materia);
                }
                MemoryStream ms = new();
                var pdfsimple = new PDFSimpleExport();
                rep.Prepare();
                rep.Export(pdfsimple, ms);
                rep.FileName = $"{plan.Descripcion}.pdf";
                saveFileDialog1.FileName = $"{plan.Descripcion}.pdf";
                var result = saveFileDialog1.ShowDialog();

                if (result == DialogResult.OK)
                {
                    File.WriteAllBytes(saveFileDialog1.FileName, ms.ToArray());
                    niPlanes.ShowBalloonTip(1000, "Reporte del curso", $"Se creado y guardado el reporte del curso", ToolTipIcon.Info);
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvPlanes.DataSource = new BindingSource() { DataSource = this.PlanLogic.GetAll() };
                niPlanes.ShowBalloonTip(1000, "Actualizar lista de planes", "Se ha actualizado la lista de planes", ToolTipIcon.Info);
            }
            catch (Exception)
            {
                niPlanes.ShowBalloonTip(1000, "Actualizar lista de planes", "No se puedo realizar la consulta de planes. Contacte con un administrador", ToolTipIcon.Error);
            }
        }

        private void Planes_Load(object sender, EventArgs e)
        {
            PlanesLista = PlanLogic.GetAll();
            EspecialidadLista = EspecialidadLogic.GetAll();
            cbEspecialidades.DataSource = EspecialidadLista;
            cbEspecialidades.DisplayMember = "Descripcion";
            cbEspecialidades.ValueMember = "Id";
            cbEspecialidades.SelectedIndex = -1;
            dgvPlanes.DataSource = new BindingSource() { DataSource = this.PlanLogic.GetAll() };
        }

        private void cbEspecialidades_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void cbEspecialidades_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dgvPlanes.DataSource = PlanesLista.Where(x => x.EspecialidadId == (int)cbEspecialidades.SelectedValue).ToList();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.MasterForm.OpenForm(new Inicio());
        }

        private void dgvPlanes_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
