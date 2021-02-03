using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParallelTask1
{
    public partial class Form1 : Form
    {
        private int[] data = { -1, 4, 2, 8, 11, 6, 12, 3, 7 };

        private string ToString(int[] data)
        {
            return string.Join(",", data);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var worker = new ArraySorter<int>(this.data);
            worker.From = 3;
            worker.To = 7;
            worker.StartAsync();
            Thread.Sleep(3000);
            MessageBox.Show(this.ToString(this.data));
        }
    }
}
