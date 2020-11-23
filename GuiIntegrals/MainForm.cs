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
        private IntegrateOptions options = new IntegrateOptions();
        private Func<double, string> formatter = d => string.Format("{0:###0.#####}", d);
        private int selectedMethod = 0;

        public mainForm()
        {
            InitializeComponent();
        }

        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enableStartItems(false);
            if (tryToCalc(options))
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool tryToCalc(IntegrateOptions options)
        {
            try
            {
                options.StartX = double.Parse(txbLeftX.Text);
                options.EndX = double.Parse(txbRightX.Text);
                options.Steps = int.Parse(txbSteps.Text);
                options.Tolerance = double.Parse(mtxbTolerance.Text);
                options.Function = Functions.ComputedFunction;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            var method = this.GetIntegralMethod(this.selectedMethod);
            var res = method(options,
                (s, p) => {
                backgroundWorker1.ReportProgress(p, formatter(s));
                e.Cancel = backgroundWorker1.CancellationPending;
                return backgroundWorker1.CancellationPending;
            });

            e.Result = res;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.txbValue.InvokeAsyncAction(()=> txbValue.Text = (string)e.UserState);
            this.progressBar1.InvokeAsyncAction(()=> progressBar1.Value = e.ProgressPercentage);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(this, string.Format("{0}", e.Error.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else
            {
                if (e.Cancelled)
                {
                    string message = string.Format("Operation canceled with {0} steps", options.CountedSteps);
                    MessageBox.Show(this, message, "Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    var result = string.Format(formatter((double)e.Result));
                    MessageBox.Show(this, string.Format("Result: {0} with count steps: {1}", result, options.CountedSteps), "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txbValue.Text = result;
                }
            }
            
            this.InvokeAsyncAction(() => enableStartItems(true));
        }

        private void enableStartItems(bool enable)
        {
            this.gbSettings.Enabled = enable;
            this.calculateToolStripMenuItem.Enabled = enable;
            this.exitToolStripMenuItem.Enabled = enable;

            this.gbMethods.Enabled = enable;
            this.cancelToolStripMenuItem.Visible = !enable;
            this.progressBar1.Visible = !enable;
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
        }

        private void rbLeftRecMethod_Click(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                this.selectedMethod = int.Parse((string)(sender as RadioButton).Tag);
            }
        }

        private void rbRightRect_Click(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                this.selectedMethod = int.Parse((string)(sender as RadioButton).Tag);
            }
        }

        private void rbMidleRect_Click(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                this.selectedMethod = int.Parse((string)(sender as RadioButton).Tag);
            }
        }
    }
}
