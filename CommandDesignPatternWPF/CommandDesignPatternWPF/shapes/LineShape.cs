using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CommandDesignPatternWPF
{
    public class LineShape : CDPShape
    {

        private PointF end;

        public LineShape(Pen drawPen, PointF start, PointF end)
            : base(drawPen, start)
        {
            this.end = end;
        }

        public override void draw(Graphics imgGra)
        {
            imgGra.DrawLine(this.DrawPen, this.ReferencePoint, this.end);
        }

        public override void erase(Graphics imgGra)
        {
            imgGra.DrawLine(this.ErasePen, this.ReferencePoint, this.end);
        }

        public override string ToString()
        {
            return "LINE " + this.ReferencePoint + " - " + this.end;
        }

    }
}
