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
    public partial class NumericUpDownValidation : UserControl
    {
        public NumericUpDownValidation()
        {
            InitializeComponent();
        }

        public NumericUpDown NumericUpDown => this.numericUpDown1;

        public Label LabelError => this.label1;
    }
}
