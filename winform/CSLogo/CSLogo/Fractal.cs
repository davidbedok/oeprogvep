using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CSLogoApplication
{
    public delegate void RefreshMethod();

    public class Fractal
    {
        // 
        public static string FRACTAL_KOCH = "Koch";
        public static string FRACTAL_KOCHWAIT = "Koch (wait)";
        public static string FRACTAL_KOCHEXTRA = "Koch extra";

        private Turtle turtle;
        private Image canvas;

        public Fractal(Turtle turtle, Image canvas)
        {
            this.turtle = turtle;
            this.canvas = canvas;
        }

        public void Koch(float x, int level)
        {
            if (level < 1)
            {
                turtle.Forward(x, Graphics.FromImage(canvas));
            }
            else
            {
                Koch((x / 3), (level - 1));
                turtle.Left(60);
                Koch((x / 3), (level - 1));
                turtle.Right(120);
                Koch((x / 3), (level - 1));
                turtle.Left(60);
                Koch((x / 3), (level - 1));
            }
        }

        public void KochWithWait(float x, int level, RefreshMethod refresh)
        {
            if (level < 1)
            {
                turtle.Forward(x, Graphics.FromImage(canvas));
                refresh.Invoke();
                turtle.Wait();
            }
            else
            {
                KochWithWait((x / 3), (level - 1), refresh);
                turtle.Left(60);
                KochWithWait((x / 3), (level - 1), refresh);
                turtle.Right(120);
                KochWithWait((x / 3), (level - 1), refresh);
                turtle.Left(60);
                KochWithWait((x / 3), (level - 1), refresh);
            }
        }

        public void KockExtra(float x, int level)
        {
            turtle.SetPen(Color.Blue);
            this.Koch(x, level);
            turtle.Left(180);
            this.Koch(x, level);

            turtle.Left(90);

            turtle.SetPen(Color.Green);
            this.Koch(x, level);
            turtle.Left(180);
            this.Koch(x, level);

            turtle.Left(90);

            turtle.SetPen(Color.Red);
            this.Koch(x, level);
            turtle.Left(180);
            this.Koch(x, level);

            turtle.Left(90);

            turtle.SetPen(Color.Yellow);
            this.Koch(x, level);
            turtle.Left(180);
            this.Koch(x, level);
        }

    }
}
