using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuiFunctionCalculator
{
    public partial class fmFuncCalc : Form
    {
        private static readonly string DEFAULT_RESULT = "Неможливо обчислити функцію";
        public fmFuncCalc()
        {
            InitializeComponent();
        }

        private double Function(double x, double y)
        {
            var a = Math.Sin(x);
            var b = x * x * x * x;
            return (a * a * a + y + 45) / (2 * b + 4 * y);
        }

        private void TryToCalc(string xStr, string yStr, out string zStr)
        {
            zStr = DEFAULT_RESULT;
            if (!double.TryParse(xStr, out double x))
            {
                return;
            }

            if (!double.TryParse(yStr, out double y))
            {
                return;
            }

            double z = Function(x, y);

            zStr = string.Format("{0}", z);
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            TryToCalc(txbX.Text, txbY.Text, out string zStr);
            txbZ.Text = zStr;
        }

        private void cbxAutoCalc_CheckedChanged(object sender, EventArgs e)
        {
            btnCalc.Enabled = !(sender as CheckBox).Checked;
        }

        private void txbX_TextChanged(object sender, EventArgs e)
        {
            if (cbxAutoCalc.Checked)
            {
                btnCalc_Click(btnCalc, e);
            }
        }
    }
}
