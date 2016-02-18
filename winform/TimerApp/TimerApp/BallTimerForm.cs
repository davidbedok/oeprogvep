using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TimerApp
{
    public partial class BallTimerForm : Form
    {
        private const int NUMBER_OF_BALL = 100;

        private readonly Random rand;
        private readonly Frame frame;
        private readonly BallFactory ballFactory;

        private Ball ball;
        private Ball[] balls;

        public BallTimerForm()
        {
            this.rand = new Random();
            this.frame = new Frame(this.rand);
            this.ballFactory = new BallFactory(this.rand, this.frame);
            this.InitializeComponent();
            this.initPicture();
        }

        private void initPicture()
        {
            this.pbCanvas.Image = new Bitmap(this.frame.WidthInt, this.frame.HeightInt);
            this.pbCanvas.SizeMode = PictureBoxSizeMode.StretchImage;

            Graphics graphics = Graphics.FromImage(this.pbCanvas.Image);
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            graphics.Clear(Color.White);
            graphics.DrawRectangle(Pens.Black, this.frame.getRect());

            this.pbCanvas.Invalidate();
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            this.initPicture();
            this.ball = this.ballFactory.createBall(10, 15);
            this.timerBall.Enabled = true;
        }

        private void timerBall_Tick(object sender, EventArgs e)
        {
            this.ball.jump(Graphics.FromImage(this.pbCanvas.Image));
            this.pbCanvas.Invalidate();
        }

        private void bStop_Click(object sender, EventArgs e)
        {
            this.timerBall.Enabled = false;
        }

        private void bMultiStart_Click(object sender, EventArgs e)
        {
            this.initPicture();
            this.balls = new Ball[BallTimerForm.NUMBER_OF_BALL];
            for (int i = 0; i < this.balls.Length; i++)
            {
                this.balls[i] = this.ballFactory.createBall();
            }
            this.timerBalls.Enabled = true;
        }

        private void timerBalls_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < this.balls.Length; i++)
            {
                this.balls[i].jump(Graphics.FromImage(this.pbCanvas.Image));
            }
            this.pbCanvas.Invalidate();
        }

        private void bMultiStop_Click(object sender, EventArgs e)
        {
            this.timerBalls.Enabled = false;
        }

    }
}
