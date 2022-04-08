using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpringFrequencyCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double f = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            double k;
            double m;

            double.TryParse(txtSp.Text, out k);
            double.TryParse(txtM.Text, out m);
            if (txtSp.Text == "" || txtM.Text == "")
            {
                MessageBox.Show("Please enter values!", "Warning!");
            }
            else
            {
                hz1.Visible = true;
                f = (1 / (2 * Math.PI)) * Math.Sqrt(k*1000 / m);
                f = Math.Round(f, 2);
                lbHz.Text = Convert.ToString(f);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lbHz.Text = "";
            hz1.Visible = false;
            txtSp.Text = "";
            txtM.Text = "";
        }

        private void txtSp_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 46);
            if (txtSp.Text.Length == 0)
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = true;
                }
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txtSp.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            if (txtSp.Text.StartsWith("0") && !txtSp.Text.StartsWith("0.") && e.KeyChar != '\b' && e.KeyChar != (int)'.')
            {
                e.Handled = true;
            }
        }

        private void txtM_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsNumber(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 46);
            if (txtM.Text.Length == 0)
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = true;
                }
            }
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && txtM.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            if (txtM.Text.StartsWith("0") && !txtM.Text.StartsWith("0.") && e.KeyChar != '\b' && e.KeyChar != (int)'.')
            {
                e.Handled = true;
            }
        }
    }   

}
