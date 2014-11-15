using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CommandDesignPatternWPF
{
    public class EllipseShape : CDPShape
    {

        private RectangleF rect;

        public EllipseShape(Pen drawPen, RectangleF rect)
            : base(drawPen, rect.Location)
        {
            this.rect = rect;
        }

        public override void draw(Graphics imgGra)
        {
            imgGra.DrawEllipse(this.DrawPen, this.getRectangle());
        }

        private RectangleF getRectangle()
        {
            return new RectangleF(this.ReferencePoint.X, this.ReferencePoint.Y, this.rect.Width, this.rect.Height);
        }

        public override void erase(Graphics imgGra)
        {
            imgGra.DrawEllipse(this.ErasePen, this.getRectangle());
        }

        public override string ToString()
        {
            return "ELLIPSE " + this.rect;
        }

    }
}
