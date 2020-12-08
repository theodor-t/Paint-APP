using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace apppaint
{

    public partial class Form1 : Form
    {
        Bitmap pic;
        private SolidBrush myBrush;
        private Graphics myGraphics;
        private bool IsPainting = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                myBrush.Color = colorDialog1.Color;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myBrush = new SolidBrush(panel2.BackColor);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            IsPainting = true;

    }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            IsPainting = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsPainting == true)
            {
                myGraphics = panel1.CreateGraphics();
                myGraphics.FillEllipse(myBrush, e.X, e.Y, trackBar1.Value, trackBar1.Value);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }
        
    }
}
