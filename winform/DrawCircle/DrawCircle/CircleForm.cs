using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DrawCircle
{
    public partial class CircleForm : Form
    {
        private Pen pen;

        public CircleForm()
        {
            InitializeComponent();
            this.canvas.Image = new Bitmap(300, 100);
            this.canvas.SizeMode = PictureBoxSizeMode.StretchImage;
            Graphics g = Graphics.FromImage(this.canvas.Image);
            g.Clear(Color.White);
            this.pen = new Pen(Color.Black);
        }

        private void bSimple_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(this.canvas.Image);
            g.DrawEllipse(this.pen, 10, 10, 80, 80);
            this.canvas.Refresh();
        }

        private void bMath_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(this.canvas.Image);
            float oX = 150;
            float oY = 50;
            for (int i = 0; i < 360; i++)
            {
                g.DrawEllipse(this.pen, (float)(oX + 40 * Math.Cos(i * Math.PI / 180)), (float)(oY - 40 * Math.Sin(i * Math.PI / 180)), 1,1);
            }
            this.canvas.Refresh();
        }

        private void bExpert_Click(object sender, EventArgs e)
        {
            // x^2 + y^2 = 40  kor egyenlete
            Graphics g = Graphics.FromImage(this.canvas.Image);
            float oX = 250;
            float oY = 50;
            for (int i = 0; i < 1601; i++)
            {
                double f1 = i;
                double f2 = Math.Sqrt(1600 - f1);
                f1 = Math.Sqrt(f1);
                g.DrawEllipse(this.pen, (float)(oX + f1), (float)(oY - f2), 1, 1);
                g.DrawEllipse(this.pen, (float)(oX - f1), (float)(oY - f2), 1, 1);
                g.DrawEllipse(this.pen, (float)(oX - f1), (float)(oY + f2), 1, 1);
                g.DrawEllipse(this.pen, (float)(oX + f1), (float)(oY + f2), 1, 1);
            }
            this.canvas.Refresh();
        }
    }
}
