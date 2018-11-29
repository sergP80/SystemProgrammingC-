using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleGUICalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                Environment.Exit(0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0, b = 0;
            try
            {
                a = int.Parse(textBox1.Text);
            }
            catch(Exception ex)
            {
                string err = string.Format("Error first number {0}", ex.Message);
                MessageBox.Show(err, "Converison error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                b = int.Parse(textBox2.Text);
            }
            catch (Exception ex)
            {
                string err = string.Format("Error first number {0}", ex.Message);
                MessageBox.Show(err, "Converison error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            int r = a + b;
            textBox3.Text = string.Format("{0}", r);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SplashForm splash = new SplashForm();
            splash.Show(this);
        }
    }
}
