using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Button_Click
{
    public partial class txtDisplay : Form
    {
        public txtDisplay()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            textDisplay.Text = "Hello, World!";
        }
    }
}
