using Business.Logic;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class Usuarios : ApplicationForm
    {
        private UsuarioLogic UsuarioLogic => new();
        public Usuarios()
        {
            InitializeComponent();
            dgvUsuarios.AutoGenerateColumns = false;
            dgvUsuarios.DataSource = UsuarioLogic.GetAll();
        }
    }
}
