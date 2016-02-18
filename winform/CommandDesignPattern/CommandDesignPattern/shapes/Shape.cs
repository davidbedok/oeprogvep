using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CommandDesignPattern
{
    public abstract class Shape : IShape
    {

        private Pen drawPen;
        private PointF referencePoint;

        public Color ShapeColor
        {
            get { return this.drawPen.Color; }
            set { this.drawPen.Color = value; }
        }

        public PointF ReferencePoint
        {
            get { return this.referencePoint; }
            set { this.referencePoint = value; }
        }

        protected Pen DrawPen
        {
            get { return this.drawPen; }
        }

        protected Pen ErasePen
        {
            get { return new Pen(Color.White, this.drawPen.Width); }
        }

        public Shape(Pen drawPen, PointF referencePoint)
        {
            this.drawPen = drawPen;
            this.referencePoint = referencePoint;
        }

        public abstract void draw(Graphics imgGra);
        public abstract void erase(Graphics imgGra);

    }
}
