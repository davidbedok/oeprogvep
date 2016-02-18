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
    public partial class TestForm : Form
    {

        private const int WIDTH = 320;
        private const int HEIGHT = 240;

        private Turtle sampleTurtle;

        private float stretchX;
        private float stretchY;

        public TestForm()
        {
            InitializeComponent();
            this.calcStrech();
            this.initDemo();
        }

        private void calcStrech()
        {
            this.stretchX = (float)((float)this.pbCanvasDemo.Size.Width / TestForm.WIDTH);
            this.stretchY = (float)((float)this.pbCanvasDemo.Size.Height / TestForm.HEIGHT);
        }

        private void initDemo()
        {
            this.pbCanvasDemo.Image = new Bitmap(TestForm.WIDTH, TestForm.HEIGHT);
            this.pbCanvasDemo.SizeMode = PictureBoxSizeMode.StretchImage;

            Graphics g = Graphics.FromImage(this.pbCanvasDemo.Image);
            g.Clear(Color.White);
            g.DrawRectangle(Pens.Black, 0, 0, TestForm.WIDTH - 1, TestForm.HEIGHT - 1);

            this.pbCanvasDemo.Invalidate();

            this.sampleTurtle = new Turtle(TestForm.WIDTH / 2, TestForm.HEIGHT / 2, 0);
            this.sampleTurtle.SetPen(this.pColor.BackColor, (int)this.nudPenWidth.Value);
            this.sampleTurtle.Left(90);
            this.sampleTurtle.ShowTurtle();
        }

        private void bForward_Click(object sender, EventArgs e)
        {
            // float value;
            // float.TryParse(tbForward.Text, out value);
            float value = ConvertHelper.parseFloat(tbForward);
            this.sampleTurtle.Forward(value, Graphics.FromImage(pbCanvasDemo.Image));
            this.refreshDemo();
        }

        private void refreshDemo()
        {
            this.tbDemoX.Text = this.sampleTurtle.TurtlePosX.ToString();
            this.tbDemoY.Text = this.sampleTurtle.TurtlePosY.ToString();
            this.tbDemoAngle.Text = this.sampleTurtle.AngleOfTurtle.ToString();
            this.pbCanvasDemo.Invalidate();
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            this.sampleTurtle.Back(ConvertHelper.parseFloat(tbBack), Graphics.FromImage(pbCanvasDemo.Image));
            this.refreshDemo();
        }

        private void bLeft_Click(object sender, EventArgs e)
        {
            this.sampleTurtle.Left(ConvertHelper.parseInt(tbLeft));
            this.refreshDemo();
        }

        private void bRight_Click(object sender, EventArgs e)
        {
            this.sampleTurtle.Right(ConvertHelper.parseInt(tbRight));
            this.refreshDemo();
        }

        private void bDemoInit_Click(object sender, EventArgs e)
        {
            this.initDemo();
        }

        private void cbDraw_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDraw.Checked)
            {
                this.sampleTurtle.PenDown();
            }
            else
            {
                this.sampleTurtle.PenUp();
            }
        }

        private void pColor_Click(object sender, EventArgs e)
        {
            if (this.colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.pColor.BackColor = this.colorDialog.Color;
                this.sampleTurtle.SetPen(this.colorDialog.Color);
            }
        }

        private void pbCanvasDemo_Paint(object sender, PaintEventArgs e)
        {
            this.sampleTurtle.DrawTurtle(e.Graphics, this.stretchX, this.stretchY);
        }

        private void TestForm_Resize(object sender, EventArgs e)
        {
            this.calcStrech();
        }

        private void cbVisible_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbVisible.Checked)
            {
                this.sampleTurtle.ShowTurtle();
            }
            else
            {
                this.sampleTurtle.HideTurtle();
            }
            this.refreshDemo();
        }

        private void nudPenWidth_ValueChanged(object sender, EventArgs e)
        {
            this.sampleTurtle.SetPen((int)this.nudPenWidth.Value);
        }

    }
}
