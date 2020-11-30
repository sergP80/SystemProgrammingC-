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
        private IntegrateOptions Options { get; set; } = new IntegrateOptions();
        private Func<double, string> formatter = d => string.Format("{0:###0.#####}", d);
        private int selectedMethod = 0;
        private Preferences preferences;

        private bool allowedSettings = false;
        public bool AllowedSettings 
        {
            get
            {
                return this.allowedSettings;
            }
            internal set
            {
                this.allowedSettings = value;
                this.disableStartItems(!value || this.backgroundWorker1.IsBusy);
            } 
        }

        public mainForm()
        {
            InitializeComponent();
        }

        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enableStartItems(false);
            backgroundWorker1.RunWorkerAsync();
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

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            var method = this.GetIntegralMethod(this.selectedMethod);
            var res = method(Options,
                (s, p) => {
                backgroundWorker1.ReportProgress(p, formatter(s));
                e.Cancel = backgroundWorker1.CancellationPending;
                return backgroundWorker1.CancellationPending;
            });

            e.Result = res;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            tstxValue.Text = (string)e.UserState;
            tsProgressBar1.Value = e.ProgressPercentage;
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
                    string message = string.Format("Operation canceled with {0} steps", Options.CountedSteps);
                    MessageBox.Show(this, message, "Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    var result = string.Format(formatter((double)e.Result));
                    MessageBox.Show(this, string.Format("Result: {0} with count steps: {1}", result, Options.CountedSteps), "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.tstxValue.Text = result;
                }
            }
            
            this.InvokeAsyncAction(() => enableStartItems(true));
        }

        private void enableStartItems(bool enable)
        {
            this.gbSettings.Enabled = enable;
            this.calculateToolStripMenuItem.Enabled = enable;
            this.tsbStart.Enabled = enable;
            this.exitToolStripMenuItem.Enabled = enable;
            this.tsbExit.Enabled = enable;
            this.tsbPreferences.Enabled = enable;

            this.gbMethods.Enabled = enable;
            this.cancelToolStripMenuItem.Visible = !enable;
            this.tsbCancel.Visible = !enable;
            this.toolStripSeparator5.Visible = !enable;
            this.tsProgressBar1.Visible = !enable;
        }

        private void disableStartItems(bool disable)
        {
            this.gbSettings.Enabled = !disable;
            this.calculateToolStripMenuItem.Enabled = !disable;
            this.tsbStart.Enabled = !disable;
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

        private void tsbStart_Click(object sender, EventArgs e)
        {
            this.calculateToolStripMenuItem_Click(sender, e);
        }

        private void tsbExit_Click(object sender, EventArgs e)
        {
            this.exitToolStripMenuItem_Click(sender, e);
        }

        private void tsbCancel_Click(object sender, EventArgs e)
        {
            this.cancelToolStripMenuItem_Click(sender, e);
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.preferences = new Preferences();
            this.preferences.StartPosition = FormStartPosition.CenterParent;
            this.preferences.Options = this.Options;
            var result = this.preferences.ShowDialog();
            this.Options = this.preferences.Options;
            this.AllowedSettings = result == DialogResult.OK && this.Options.IsValid;
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            this.AllowedSettings = false;
            this.mainOptionsBindingSource.DataSource = Options;
        }

        private void tsbPreferences_Click(object sender, EventArgs e)
        {
            this.optionsToolStripMenuItem_Click(sender, e);
        }
    }
}
