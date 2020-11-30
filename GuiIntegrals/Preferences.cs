using NumericIntegral;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace GuiIntegrals
{
    public partial class Preferences : Form
    {
        public IntegrateOptions Options { get; set; }

        public Preferences()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (Options == null)
            {
                return;
            }
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void txbExpression_TextChanged(object sender, EventArgs e)
        {
            var expression = txbExpression.Text;
            if (expression == null || expression.Trim().Length == 0)
            {
                Options.Function = null;
            } else
            {
                Options.Function = x => Functions.EvaluteFunction(expression, x);
            }
        }

        private void settingsPropertyChangedEventHandler(object sender, PropertyChangedEventArgs e)
        {
            this.btnOk.Enabled = this.Options.IsValid;
        }

        private void Preferences_Load(object sender, EventArgs e)
        {
            this.Options.PropertyChanged += settingsPropertyChangedEventHandler;
            this.optionsBindingSource.DataSource = this.Options;
        }
    }
}
