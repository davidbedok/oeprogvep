using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Media;


namespace CommandDesignPatternWPF
{
    public class RectangleShape : CDPShape
    {

        private Size size;

        private Rect Rect
        {
            get
            {
                return new Rect(this.ReferencePoint, this.size);
            }
        }

        public RectangleShape(Color penColor, Color fillColor, double penWidth, Point topLeft, Size size)
            : base(penColor, fillColor, penWidth, topLeft)
        {
            this.size = size;
        }

        protected override Geometry buildGeometry()
        {
            return new RectangleGeometry(this.Rect);
        }

        public override string ToString()
        {
            return "Ellipse " + this.size.Width + "x" + this.size.Height + base.ToString();
        }

    }
}
