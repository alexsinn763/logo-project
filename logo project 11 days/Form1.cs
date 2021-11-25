using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logo_project_11_days
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            label1.Text = "oh damn we broke the ikea logo";
            Graphics g = this.CreateGraphics();
            g.Clear(Color.Blue);
            SolidBrush drawBrush = new SolidBrush(Color.Yellow);
            Pen drawPen = new Pen(Color.Yellow, 1);
            g.DrawEllipse(drawPen, 25, 25, 700, 425);
            g.FillEllipse(drawBrush, 25, 25, 700, 425);
            Font drawFont = new Font("Impact", 225, FontStyle.Bold);
            SolidBrush drawBrush2 = new SolidBrush(Color.Blue);
            g.TranslateTransform(0, 0);
            g.RotateTransform(8);
            g.DrawString("IKEA", drawFont, drawBrush2, 75, 15);
            g.ResetTransform();
        }
    }
}

