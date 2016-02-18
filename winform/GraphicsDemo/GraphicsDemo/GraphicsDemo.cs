using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Graphics1
{
    public partial class GraphicsDemo : Form
    {

        private bool line1status;
        private bool line2status;

        public GraphicsDemo()
        {
            InitializeComponent();
            this.pbLines.Image = new Bitmap(100, 100);
            this.pbLines.Image = new Bitmap(100, 100);
            this.pbLines.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void bDraw_Click(object sender, EventArgs e)
        {
            // komponensre rajzolas barmikor, elkerve a grafikat a komponenstol
            Graphics iGraphics = bDraw.CreateGraphics();
            Pen iPen = new Pen(Color.Black);
            iGraphics.DrawLine(iPen,0,0,bDraw.Width-1, bDraw.Height-1);
            // hatrany: csak addig lathato a modositas, amig nem frissul a kirajzolas
        }

        private void bPaint_Paint(object sender, PaintEventArgs e)
        {
            // komponensre rajzolas - iratkozzunk fel a Paint esemenyere. A komponens minden frissitesekor meghivja ezt az esemenyt.
            Graphics iGraphics = e.Graphics;
            
            Brush iBrush = new HatchBrush(HatchStyle.DashedHorizontal,Color.Chocolate);
            Pen iPen = new Pen(iBrush);
            iGraphics.DrawRectangle(iPen,10,10,50,50);
            iGraphics.FillRectangle(iBrush, 30, 30, 70, 70);
            iGraphics.DrawLine(iPen, 0, 0, bDraw.Width - 1, bDraw.Height - 1);
        }

        private void bIndependent_Click(object sender, EventArgs e)
        {
            // Komponenstol fuggetlen rajzolas
            Bitmap iBitmap = new Bitmap(100,100);
            Graphics iGraphics = Graphics.FromImage(iBitmap);
            Pen iPen = new Pen(Color.Black);
            iGraphics.DrawLine(iPen, 0, 0, 99, 99);
            
            // ugyanez, csak a Bitmap-et (Image-t) egy komponens tarolja
            this.pictureBox1.Image = new Bitmap(100, 100);
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            Graphics g = Graphics.FromImage(this.pictureBox1.Image);
            g.DrawLine(iPen, 0, 0, 99, 99);
            this.pictureBox1.Refresh();
            // mivel a PictureBox frissiteskor az Image-et rajzolja ki, ezert az Image kozvetlen irasaval elerjuk celunkat
        }

        private void pbLines_Paint(object sender, PaintEventArgs e)
        {
            Graphics iGraphics = e.Graphics;
            Pen iPen = new Pen(Color.Black);
            if (this.line1status)
            {
                iGraphics.DrawLine(iPen, 0, 0, bDraw.Width - 1, bDraw.Height - 1);
            }
            if (this.line2status)
            {
                iGraphics.DrawLine(iPen, 0, bDraw.Height - 1, bDraw.Width - 1, 0);
            }
            pbLines.Invalidate();
        }

        private void bLine1_Click(object sender, EventArgs e)
        {
            this.line1status = !this.line1status;
        }

        private void bLine2_Click(object sender, EventArgs e)
        {
            this.line2status = !this.line2status;
        }

    }
}
