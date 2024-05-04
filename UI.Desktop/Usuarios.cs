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
    }
}
