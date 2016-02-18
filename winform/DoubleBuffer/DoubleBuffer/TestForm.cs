using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DoubleBuffer
{
    public partial class TestForm: Form
    {
        float angle;
        bool doubleBuffering = false;
        bool smoothing = false;
        private Bitmap backBuffer;

        public TestForm()
        {
            SetStyle(ControlStyles.Opaque, true);
            InitializeComponent();
        }

        private void timer_Tick(object sender, System.EventArgs e)
        {
            angle += 0.25f;
            if (angle > 359.0f)
                angle = 0.0f;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (backBuffer == null)
                backBuffer = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);

            Graphics g = doubleBuffering ? Graphics.FromImage(backBuffer) : e.Graphics;

            g.SmoothingMode = smoothing ? SmoothingMode.AntiAlias : SmoothingMode.Default;

            g.Clear(SystemColors.Control);

            Matrix mx = new Matrix();
            mx.Rotate(angle);
            mx.Translate(this.ClientSize.Width / 2, this.ClientSize.Height / 2, MatrixOrder.Append);
            g.Transform = mx;
            g.FillRectangle(Brushes.Red, -100, -100, 200, 200);

            mx = new Matrix();
            mx.Rotate(-angle);
            mx.Translate(this.ClientSize.Width / 2, this.ClientSize.Height / 2, MatrixOrder.Append);
            g.Transform = mx;
            g.FillRectangle(Brushes.Green, -75, -75, 150, 150);

            mx = new Matrix();
            mx.Rotate(angle * 2);
            mx.Translate(this.ClientSize.Width / 2, this.ClientSize.Height / 2, MatrixOrder.Append);
            g.Transform = mx;
            g.FillRectangle(Brushes.Blue, -50, -50, 100, 100);

            if (doubleBuffering)
            {
                g.Dispose();
                e.Graphics.DrawImageUnscaled(backBuffer, 0, 0);
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            if (backBuffer != null)
            {
                backBuffer.Dispose();
                backBuffer = null;
            }
            base.OnSizeChanged(e);
        }

        private void animationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            timer.Enabled = animationCheckBox.Checked;
        }

        private void doubleBufferingCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            doubleBuffering = doubleBufferingCheckBox.Checked;
        }

        private void smoothingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            smoothing = smoothingCheckBox.Checked;
        }

    }
}