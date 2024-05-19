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
    public partial class Modulos : ApplicationForm
    {

        private ModuloUsuarioLogic ModuloLogic => new ModuloUsuarioLogic();

        private MasterForm MasterForm => this.MdiParent as MasterForm;

        public int UsuarioId { get; }

        public Modulos()
        {
            InitializeComponent();

        }

        public Modulos(int usuarioId) : this()
        {
            this.dgvModulos.AllowNestedProperties(true);
            this.UsuarioId = usuarioId;
        }

        private void Modulos_Load(object sender, EventArgs e)
        {
            this.dgvModulos.AutoGenerateColumns = false;
            this.dgvModulos.DataSource = this.ModuloLogic.GetModuloByUsuario(this.UsuarioId);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.dgvModulos.DataSource = this.ModuloLogic.GetModuloByUsuario(this.UsuarioId);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.MasterForm.OpenForm(new Usuarios());
        }

        private void tsbNuevoRol_Click(object sender, EventArgs e)
        {

        }
    }
}
