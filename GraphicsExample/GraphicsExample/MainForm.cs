using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GraphicsExample
{
    public partial class MainForm: Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            // Init
            Graphics g = e.Graphics;
            int padding = 100;
            Rectangle renderRect = new Rectangle(padding, padding, ClientRectangle.Width - 2 * padding, ClientRectangle.Height - 2 * padding);
            g.SmoothingMode = SmoothingMode.HighQuality;

            // Head
            float headThickness = 5.0f;
            Color headColor = Color.Black;
            Pen p = new Pen(headColor, headThickness);
            try
            {
                g.DrawEllipse(p, renderRect);
            }
            finally
            {
                p.Dispose();
            }

            // Eyes
            int eyeHorizontalOffset = renderRect.Width / 6;
            int eyeVerticalOffset = renderRect.Height / 4;
            int eyeWidth = 25;
            int eyeHeight = 25;
            float eyeThickness = 5.0f;
            Color eyeColor = Color.Blue;
            Rectangle eyeRectLeft = new Rectangle(renderRect.Location.X + renderRect.Width / 2 - eyeHorizontalOffset - eyeWidth / 2, renderRect.Location.Y + eyeVerticalOffset, eyeWidth, eyeHeight);
            Rectangle eyeRectRight = new Rectangle(renderRect.Location.X + renderRect.Width / 2 + eyeHorizontalOffset - eyeWidth / 2, renderRect.Location.Y + eyeVerticalOffset, eyeWidth, eyeHeight);
            p = new Pen(eyeColor, eyeThickness);
            try
            {
                g.DrawEllipse(p, eyeRectLeft);
                g.DrawEllipse(p, eyeRectRight);
            }
            finally
            {
                p.Dispose();
            }

            // Mouth
            float mouthThickness = 5.0f;
            Color mouthColor = Color.Red;
            int mouthVerticalOffset = renderRect.Height * 2 / 3;
            int mouthWidth = renderRect.Width * 5 / 8;
            float mouthStartAngle = 0;
            float mouthSweepAngle = 180;
            int gestureStrengthFactor = renderRect.Height * 1 / 20;
            int gestureSize = (int) gestureControl.Value * gestureStrengthFactor;
            Rectangle mouthRectangle = new Rectangle(renderRect.Location.X + renderRect.Width / 2 - mouthWidth / 2, renderRect.Location.Y + mouthVerticalOffset - gestureSize / 2, mouthWidth, gestureSize + 1);
            p = new Pen(mouthColor, mouthThickness);
            try
            {
                g.DrawArc(p, mouthRectangle, mouthStartAngle, mouthSweepAngle);
            }
            finally
            {
                p.Dispose();
            }

            // Hair
            float hairThickness = 5.0f;
            Color hairColor = Color.Maroon;
            int hairCount = 16;
            int hairOffset = -hairCount;
            int hairsMissingFromSides = 7;
            int hairLength = 50;
            Point wheelCenter = new Point(renderRect.Location.X + renderRect.Width / 2, renderRect.Location.Y);
            using (p = new Pen(hairColor, hairThickness))
                for (int i = hairOffset + hairsMissingFromSides; i <= hairOffset + hairCount - hairsMissingFromSides; i++)
                    g.DrawLine(p, wheelCenter, new Point(wheelCenter.X + (int) (hairLength * Math.Cos(i * Math.PI / hairCount)), wheelCenter.Y + (int) (hairLength * Math.Sin(i * Math.PI / hairCount))));
        }

        private void gestureControl_ValueChanged(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}