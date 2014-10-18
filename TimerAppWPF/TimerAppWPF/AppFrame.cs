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
        private const int MARGIN = 40;

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
            rect.Width = this.width - 1;
            rect.Height = this.height - 1;
            rect.Stretch = Stretch.Fill;
            rect.Stroke = Brushes.Black;
            return rect;
        }

        public Point getMiddlePoint()
        {
            return new Point(this.width / 2, this.height / 2);
        }

        public Point getRandomPoint()
        {
            return new Point(this.getRandWidthCoord(), this.getRandHeightCoord());
        }

        private int getRandWidthCoord()
        {
            return this.getRandCoord(this.width);
        }

        private int getRandHeightCoord()
        {
            return this.getRandCoord(this.height);
        }

        private int getRandCoord(double max)
        {
            return AppFrame.MARGIN + this.rand.Next((int)max - AppFrame.MARGIN * 2);
        }

    }
}
