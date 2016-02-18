using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace CommandDesignPatternWPF.shapes
{
    public class EllipseShape : CDPShape
    {

        private double radiusX;
        private double radiusY;
        
        private Rect Rect
        {
            get
            {
                return new Rect(this.ReferencePoint.X - this.radiusX, this.ReferencePoint.Y - this.radiusY, 2 * this.radiusX, 2 * this.radiusY);
            }
        }

        public EllipseShape(Nullable<Color> penColor, Nullable<Color> fillColor, double penWidth, Point origo, double radiusX, double radiusY)
            : base(penColor, fillColor, penWidth, origo)
        {
            this.radiusX = radiusX;
            this.radiusY = radiusY;
        }

        protected override Geometry buildGeometry() 
        {
            return new EllipseGeometry(this.Rect);
        }

        public override string ToString()
        {
            return "Ellipse " + this.radiusX + "x" + this.radiusY + base.ToString();
        }

    }
}
