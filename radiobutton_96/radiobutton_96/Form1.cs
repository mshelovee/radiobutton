using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace radiobutton_96
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRenk_Click(object sender, EventArgs e)
        {
            if (rbMavi.Checked)
            {
                this.BackColor = Color.Blue;
            }
            else if (rbSari.Checked)
            {
                this.BackColor = Color.Yellow;

            }
            else if (rbKirmizi.Checked)
            {
                this.BackColor = Color.Red;

            }
            else if (rbYesil.Checked)
            {
                this.BackColor = Color.Green;

            }
        }   }   
}

