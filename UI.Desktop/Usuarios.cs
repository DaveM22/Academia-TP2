using Business.Entities;
using Business.Logic;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class Usuarios : ApplicationForm
    {
        private UsuarioLogic UsuarioLogic => new();

        private MasterForm MasterForm => this.MdiParent as MasterForm;
        public Usuarios()
        {
            InitializeComponent();
            dgvUsuarios.AutoGenerateColumns = false;
            dgvUsuarios.DataSource = UsuarioLogic.GetAll();
        }

        private void tsNuevoUsuario_Click(object sender, System.EventArgs e)
        {
            this.MasterForm.OpenForm(new UsuarioDesktop(ModoForm.Alta));
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsuarios.CurrentCell.OwningColumn.Name == "Editar")
            {
                Usuario usuario = dgvUsuarios.SelectedRows[0].DataBoundItem as Usuario;
                var form = new UsuarioDesktop(ModoForm.Modificacion, usuario.Id);
                this.MasterForm.OpenForm(form);
            }
            else if (dgvUsuarios.CurrentCell.OwningColumn.Name == "Modulos")
            {
                Usuario usuario = dgvUsuarios.SelectedRows[0].DataBoundItem as Usuario;
                var form = new Modulos(usuario.Id);
                this.MasterForm.OpenForm(form);
            }
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            this.MasterForm.OpenForm(new Inicio());
        }
    }
}
