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
        public TextBox TextBox { get => this.textBox1; set { this.textBox1 = value; } }

        public Label LabelError => this.label1;


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = string.Empty;
        }
    }
}
