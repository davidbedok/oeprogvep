using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CommandDesignPatternWPF
{
    public class RectangleShape : CDPShape
    {

        private RectangleF rect;

        public RectangleShape(Pen drawPen, RectangleF rect)
            : base(drawPen, rect.Location)
        {
            this.rect = rect;
        }

        public override void draw(Graphics imgGra)
        {
            imgGra.DrawRectangle(this.DrawPen, this.ReferencePoint.X, this.ReferencePoint.Y, this.rect.Width, this.rect.Height);
        }

        public override void erase(Graphics imgGra)
        {
            imgGra.DrawRectangle(this.ErasePen, this.ReferencePoint.X, this.ReferencePoint.Y, this.rect.Width, this.rect.Height);
        }

        public override string ToString()
        {
            return "RECTANGLE " + this.rect;
        }

    }
}
