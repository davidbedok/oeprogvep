using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Threading;

namespace CSLogoApplication
{
    public class Turtle
    {

        private const float TURTLE_SIZE = 5;
        private const float TURTLE_FOOT_SIZE = 3;

        private static readonly int WAIT = 50;

        private bool visible;
        private double angleOfTurtleRad;
        private int angleOfTurtle;
        private bool penDraw;
        private float posX;
        private float posY;
        private Pen turtlePen;
        private Pen turtleShapePen;

        public Color TurtlePenColor
        {
            get { return turtlePen.Color; }
        }

        public float TurtlePosX
        {
            set { posX = value; }
            get { return posX; }
        }

        public float TurtlePosY
        {
            set { posY = value; }
            get { return posY; }
        }

        public bool PenDraw
        {
            get { return penDraw; }
        }

        public bool VisibleTurtle
        {
            get { return visible; }
        }

        public int AngleOfTurtle
        {
            set
            {
                this.angleOfTurtle = value;
                this.angleOfTurtleRad = (double)(value * Math.PI / 180);
            }
            get { return angleOfTurtle; }
        }

        public double AngleOfTurtleRad
        {
            get { return angleOfTurtleRad; }
        }

        public Turtle(int x, int y, int angle)
        {
            this.posX = x;
            this.posY = y;
            this.AngleOfTurtle = angle;
            this.turtlePen = new Pen(Color.FromArgb(255, 0, 0, 0), 1);
            this.turtleShapePen = new Pen(Color.FromArgb(0, 0, 0));
            this.turtlePen.Alignment = PenAlignment.Center;
            this.penDraw = true;
        }

        public void ShowTurtle()
        {
            visible = true;
        }

        public void HideTurtle()
        {
            visible = false;
        }

        public void DrawTurtle(Graphics g, float stretchX, float stretchY)
        {
            if (this.visible)
            {
                Matrix rotMatrix = new Matrix();
                rotMatrix.RotateAt((float)this.angleOfTurtle, new PointF(posX * stretchX, posY * stretchY), MatrixOrder.Append);
                g.Transform = rotMatrix;
                float footSize = Turtle.TURTLE_SIZE + Turtle.TURTLE_FOOT_SIZE;
                g.DrawLine(turtleShapePen, (posX - footSize) * stretchX, (posY - footSize) * stretchY, (posX + footSize) * stretchX, (posY + footSize) * stretchY);
                g.DrawLine(turtleShapePen, (posX - footSize) * stretchX, (posY + footSize) * stretchY, (posX + footSize) * stretchX, (posY - footSize) * stretchY);
                float bodySize = Turtle.TURTLE_SIZE * 2;
                g.DrawRectangle(turtleShapePen, (posX - Turtle.TURTLE_SIZE) * stretchX, (posY - Turtle.TURTLE_SIZE) * stretchY, bodySize * stretchX, bodySize * stretchY);
                g.DrawEllipse(turtleShapePen, (posX - Turtle.TURTLE_SIZE) * stretchX, (posY + Turtle.TURTLE_SIZE) * stretchY, bodySize * stretchX, bodySize * stretchY);
                rotMatrix.Reset();
                g.Transform = rotMatrix;
            }
        }

        private void move(float distance, Graphics g, bool isForward)
        {
            double b = Math.Cos(angleOfTurtleRad) * distance;
            double a = Math.Sin(angleOfTurtleRad) * distance;
            float ib = 0;
            float ia = 0;
            if (isForward)
            {
                ib = (float)(posY + b);
                ia = (float)(posX - a);
            }
            else
            {
                ib = (float)(posY - b);
                ia = (float)(posX + a);
            }
            if (penDraw)
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.DrawLine(turtlePen, posX, posY, ia, ib);
            }
            this.posX = ia;
            this.posY = ib;
        }

        public void Forward(float distance, Graphics g)
        {
            this.move(distance, g, true);
        }

        public void Back(float distance, Graphics g)
        {
            this.move(distance, g, false);
        }

        public void Right(int angle)
        {
            AngleOfTurtle += angle;
        }

        public void Left(int angle)
        {
            AngleOfTurtle -= angle;
        }

        public void PenDown()
        {
            penDraw = true;
        }

        public void PenUp()
        {
            penDraw = false;
        }

        private void run()
        {
            Thread.Sleep(Turtle.WAIT);
        }

        public void Wait()
        {
            Thread sleepingThread = new Thread(this.run);
            sleepingThread.Start();
            sleepingThread.Join();
        }

        public void SetPen(Color c)
        {
            this.turtlePen.Color = c;
        }

        public void SetPen(float w)
        {
            this.turtlePen.Width = w;
        }

        public void SetPen(Color c, float w)
        {
            turtlePen.Color = c;
            turtlePen.Width = w;
        }

        // tmp method
        public void SetPosition(float x, float y)
        {
            posX = x;
            posY = y;
        }

    }
}
