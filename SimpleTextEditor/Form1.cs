using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleTextEditor
{
    public partial class fmTextEditor : Form
    {
        public fmTextEditor()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (ofdSelectFile.ShowDialog() != DialogResult.OK) 
            {
                return;
            }

            LoadFile(ofdSelectFile.FileName);
        }

        private void LoadFile(string filePath)
        {
            var content = File.ReadAllText(filePath);
            txbContent.Text = content;
        }
    }
}
