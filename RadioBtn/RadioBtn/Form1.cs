using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioBtn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRezerviraj_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox1.Text = "Odabrao si avion";
            }

            if (rbtnAutobus.Checked) {
                textBox1.Text = "Odabrao si autobus";
            }
            if (radioVlastiti.Checked)
            {
                textBox1.Text = "Odabrao si vlastiti prijevoz";
            }

            }
        }
    }
}
