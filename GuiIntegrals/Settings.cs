using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuiIntegrals
{
    public partial class Settings : Form
    {
        private Preferences preferences;
        public Settings()
        {
            InitializeComponent();
        }

        public Settings(Preferences preferences)
        {
            this.preferences = preferences;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.preferences.Count = int.Parse(textBox1.Text);
            this.preferences.Name = textBox2.Text;
            DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
