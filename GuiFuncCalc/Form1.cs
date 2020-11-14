using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuiFuncCalc
{
    public partial class fmMain : Form
    {
        public fmMain()
        {
            InitializeComponent();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
            
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            TryCalc(txbX1.Text, txbX2.Text, out string strY);
            txbY.Text = strY;
        }

        private bool TryCalc(string strX1, string strX2, out string strY)
        {
            var r1 = double.TryParse(strX1, out double x1);
            var r2 = double.TryParse(strX2, out double x2);
            if (!r1 || !r2)
            {
                strY = "Can't calculate";
                return false;
            }

            var y = Func(x1, x2);

            strY = string.Format("{0:###.#####E+000}", y);
            return true;
        }


        private double Func (double x1, double x2)
        {
            return Math.Sin(x1 + x2) * x1 / (x2 - x1);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txbX1.Text = "";
            txbX2.Text = "";
            txbY.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Closing...", MessageBoxButtons.YesNo);
            e.Cancel = dialogResult == DialogResult.No;
        }
    }
}
