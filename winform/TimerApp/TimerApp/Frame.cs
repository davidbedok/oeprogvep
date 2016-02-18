using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace TimerApp
{
    public class Frame
    {
        private const int MARGIN = 40;

        private const int DEF_WIDTH = 400;
        private const int DEF_HEIGHT = 400;
        private static readonly Color DEF_BACKGROUND_COLOR = Color.FromArgb(255, 255, 255);

        private readonly float width;
        private readonly float height;
        private readonly Pen erasePen;
        private readonly Random rand;

        public float Width
        {
            get { return this.width; }
        }

        public float Height
        {
            get { return this.height; }
        }

        public int WidthInt
        {
            get { return (int)this.width; }
        }

        public int HeightInt
        {
            get { return (int)this.height; }
        }

        public Pen ErasePen
        {
            get { return this.erasePen; }
        }

        public Frame(Random rand)
            : this(rand, Frame.DEF_WIDTH, Frame.DEF_HEIGHT, Frame.DEF_BACKGROUND_COLOR)
        {
        }

        public Frame(Random rand, float width, float height, Color backgroundColor)
        {
            this.rand = rand;
            this.width = width;
            this.height = height;
            this.erasePen = new Pen(backgroundColor);
        }

        public RectangleF getRect()
        {
            return new RectangleF(0, 0, this.width - 1, this.height - 1);
        }

        public PointF getMiddlePoint()
        {
            return new PointF(this.width / 2, this.height / 2);
        }

        public PointF getRandomPoint()
        {
            return new PointF(this.getRandWidthCoord(), this.getRandHeightCoord());
        }

        private int getRandWidthCoord()
        {
            return this.getRandCoord(this.width);
        }

        private int getRandHeightCoord()
        {
            return this.getRandCoord(this.height);
        }

        private int getRandCoord(float max)
        {
            return Frame.MARGIN + this.rand.Next((int)max - Frame.MARGIN * 2);
        }

    }
}
