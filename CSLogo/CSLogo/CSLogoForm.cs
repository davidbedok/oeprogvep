using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSLogoApplication
{
    public partial class CSLogoForm : Form
    {
        private Turtle turtle;
        private Fractal fractal;
        
        private Random rand;

        private const int WIDTH = 800;
        private const int HEIGHT = 600;

        private float stretchX;
        private float stretchY;

        public CSLogoForm()
        {
            InitializeComponent();
            this.rand = new Random();
            this.calcStrech();
            this.init();
            this.initTurtle();
            this.refreshData();
        }

        private void calcStrech()
        {
            this.stretchX = (float)((float)this.pbCanvas.Size.Width / CSLogoForm.WIDTH);
            this.stretchY = (float)((float)this.pbCanvas.Size.Height / CSLogoForm.HEIGHT);
        }

        private void init()
        {
            this.pbCanvas.Image = new Bitmap(CSLogoForm.WIDTH, CSLogoForm.HEIGHT);
            this.pbCanvas.SizeMode = PictureBoxSizeMode.StretchImage;
            this.clearImage();

            this.turtle = new Turtle(50, 200, 0);
            this.fractal = new Fractal(this.turtle, this.pbCanvas.Image);

            this.cbFractalType.Items.Add(Fractal.FRACTAL_KOCH);
            this.cbFractalType.Items.Add(Fractal.FRACTAL_KOCHWAIT);
            this.cbFractalType.Items.Add(Fractal.FRACTAL_KOCHEXTRA);
            this.cbFractalType.SelectedIndex = this.cbFractalType.Items.IndexOf(Fractal.FRACTAL_KOCH);
        }

        private void clearImage()
        {
            Graphics g = Graphics.FromImage(this.pbCanvas.Image);
            g.Clear(Color.White);
            g.DrawRectangle(Pens.Black, 0, 0, CSLogoForm.WIDTH - 1, CSLogoForm.HEIGHT - 1);
            this.pbCanvas.Invalidate();
        }

        private void initTurtle()
        {
            this.turtle.SetPosition(50, 200);
            this.turtle.AngleOfTurtle = 0;
            this.turtle.SetPen(Color.Black);
            this.turtle.Left(90);
        }

        private void bDraw_Click(object sender, EventArgs e)
        {
            float iSize = (float)nSize.Value;
            int iLevel = (int)nLevel.Value;
            if (cbFractalType.SelectedItem.ToString().Equals(Fractal.FRACTAL_KOCH))
            {
                this.fractal.Koch(iSize, iLevel);
            }
            if (cbFractalType.SelectedItem.ToString().Equals(Fractal.FRACTAL_KOCHWAIT))
            {
                this.fractal.KochWithWait(iSize, iLevel, this.pbCanvas.Refresh);
            }
            if (cbFractalType.SelectedItem.ToString().Equals(Fractal.FRACTAL_KOCHEXTRA))
            {
                turtle.SetPosition(400, 300);
                this.fractal.KockExtra(iSize, iLevel);
            }
            this.refreshData();
        }

        private void refreshData()
        {
            this.tbX.Text = turtle.TurtlePosX.ToString();
            this.tbY.Text = turtle.TurtlePosY.ToString();
            this.tbAngle.Text = turtle.AngleOfTurtle.ToString();
            this.pbCanvas.Invalidate();
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            this.clearImage();
        }

        private void bTeleport_Click(object sender, EventArgs e)
        {
            this.turtle.TurtlePosX = Convert.ToSingle(tbX.Text);
            this.turtle.TurtlePosY = Convert.ToSingle(tbY.Text);
            this.turtle.AngleOfTurtle = Convert.ToInt32(tbAngle.Text);
            this.pbCanvas.Invalidate();
        }

        private void bInit_Click(object sender, EventArgs e)
        {
            this.initTurtle();
            this.refreshData();
        }

        private void pbCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            Point realCoord = this.getRealCoords(e);
            this.tbX.Text = realCoord.X.ToString();
            this.tbY.Text = realCoord.Y.ToString();
            this.bTeleport_Click(sender, e);
        }

        private Point getRealCoords(MouseEventArgs e)
        {
            int realCoordX = (int)(e.X / this.stretchX);
            int realCoordY = (int)(e.Y / this.stretchY);
            return new Point(realCoordX, realCoordY);
        }

        private void pbCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            Point realCoord = this.getRealCoords(e);
            this.tsslCoords.Text = "(real coord: " + realCoord.X + ":" + realCoord.Y + ") " + e.X + ":" + e.Y;
        }

        private void bTest_Click(object sender, EventArgs e)
        {
            TestForm testForm = new TestForm();
            testForm.ShowDialog();
        }

        private void pbCanvas_Paint(object sender, PaintEventArgs e)
        {
            this.turtle.DrawTurtle(e.Graphics, this.stretchX, this.stretchY);
        }

        private void bShowHide_Click(object sender, EventArgs e)
        {
            if (this.turtle.VisibleTurtle)
            {
                this.turtle.HideTurtle();
            }
            else
            {
                this.turtle.ShowTurtle();
            }
            this.pbCanvas.Invalidate();
        }

        private void CSLogoForm_Resize(object sender, EventArgs e)
        {
            this.calcStrech();
        }

    }
}
