using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop.UserControls
{
    public partial class TextBoxConValidacion : UserControl
    {
        public TextBoxConValidacion()
        {
            InitializeComponent();
        }

        [RefreshProperties(System.ComponentModel.RefreshProperties.All)]
        public TextBox TextBox { get => this.txtData; set { this.txtData = value; } }

        public Label LabelError => this.lblError;


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lblError.Text = string.Empty;
        }
    }
}
