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
    public partial class formLogin : Form
    {
        private UsuarioLogic UsuarioLogic { get; set; }
        public formLogin()
        {
            InitializeComponent();
            UsuarioLogic = new UsuarioLogic();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            var list = UsuarioLogic.GetOne(txtUsuario.Text);
        }
    }
}
