using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCirlce
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern System.IntPtr CreateRoundRectRgn(
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateEllipticRgn")]
        private static extern System.IntPtr CreateEllipticRgn(
            int x1,
            int y1,
            int x2,
            int y2
        );

        [System.Runtime.InteropServices.DllImport("gdi32.dll", EntryPoint = "DeleteObject")]
        private static extern bool DeleteObject(System.IntPtr hObject);

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //System.IntPtr ptr = CreateRoundRectRgn(0, 0, this.Width, this.Height, 50, 50); // _BoarderRaduis can be adjusted to your needs, try 15 to start.
            System.IntPtr ptr = CreateEllipticRgn(0, 0, this.Width, this.Height); // _BoarderRaduis can be adjusted to your needs, try 15 to start.
            this.Region = System.Drawing.Region.FromHrgn(ptr);
            DeleteObject(ptr);
        }
    }
}
