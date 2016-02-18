using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows;

namespace TimerApp
{
    public class AppFrame
    {
        private const double MARGIN = Ball.MAX_RADIUS * 2 + 10;

        private readonly double width;
        private readonly double height;
        private readonly Random rand;

        public double Width
        {
            get { return this.width; }
        }

        public double Height
        {
            get { return this.height; }
        }

        public AppFrame(Random rand, double width, double height)
        {
            this.rand = rand;
            this.width = width;
            this.height = height;
        }

        public Rectangle getRect()
        {
            Rectangle rect = new Rectangle();
            rect.Width = this.width;
            rect.Height = this.height;
            rect.Stroke = Brushes.Black;
            return rect;
        }

        public Point getMiddlePoint()
        {
            return new Point(this.width / 2, this.height / 2);
        }

        public Point getRandomPoint()
        {
            return new Point(this.getRandCoord(this.width), this.getRandCoord(this.height));
        }

        private double getRandCoord(double max)
        {
            return BallFactory.getRandDouble(this.rand, AppFrame.MARGIN, max - AppFrame.MARGIN);
        }

    }
}
