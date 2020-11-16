using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NumericIntegral;

namespace GuiIntegrals
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enableStartItems(false);
            backgroundWorker1.RunWorkerAsync();
        }  

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool calculateIntegral(string txtLeftX, string txtRightX, string txtSteps, Func<double, double> func, out string result)
        {
            result = "";
            try
            {
                double a = double.Parse(txtLeftX);
                double b = double.Parse(txtRightX);
                int steps = int.Parse(txtSteps);
                var res = Integrals.LeftRect(a, b, steps, func);

                result = string.Format("{0:###.#####E+000}", res);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private double Func(double x)
        {
            return Math.PI * Math.Pow(x, 1.5) / (x * x + 1);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            this.InvokeAsync(() => { 
                if (calculateIntegral(txbLeftX.Text, txbRightX.Text, txbSteps.Text, Func, out string resut))
                {
                    txbValue.Text = resut;
                }
            });
            
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Complete", "Success", MessageBoxButtons.OK);
            this.InvokeAsync(() => enableStartItems(true));

        }

        private void enableStartItems(bool enable)
        {
            this.gbSettings.Enabled = enable;
            this.calculateToolStripMenuItem.Enabled = enable;
            this.exitToolStripMenuItem.Enabled = enable;
            
            this.cancelToolStripMenuItem.Visible = !enable;
            this.progressBar1.Visible = !enable;
        }

        
    }
}
