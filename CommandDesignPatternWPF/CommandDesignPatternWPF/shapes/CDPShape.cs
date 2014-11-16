using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace CommandDesignPatternWPF.shapes
{
    public abstract class CDPShape : IShape
    {

        private Nullable<Color> penColor;
        private Nullable<Color> fillColor;
        private double penWidth;
        private Point referencePoint;

        public double PenWidth
        {
            get { return this.penWidth; }
            set { this.penWidth = value; }
        }

        public Nullable<Color> PenColor
        {
            get { return this.penColor; }
            set { this.penColor = value; }
        }

        public Nullable<Color> FillColor
        {
            get { return this.fillColor; }
            set { this.fillColor = value; }
        }

        public Point ReferencePoint
        {
            get { return this.referencePoint; }
            set { this.referencePoint = value; }
        }

        public CDPShape(Nullable<Color> penColor, Nullable<Color> fillColor, double penWidth, Point referencePoint)
        {
            this.penColor = penColor;
            this.fillColor = fillColor;
            this.penWidth = penWidth;
            this.referencePoint = referencePoint;
        }

        public Drawing buildDrawing()
        {
            GeometryDrawing drawing = new GeometryDrawing();
            if (this.penColor.HasValue)
            {
                drawing.Pen = new Pen(new SolidColorBrush(this.penColor.Value), this.penWidth);
            }
            if (this.fillColor.HasValue)
            {
                drawing.Brush = new SolidColorBrush(this.fillColor.Value);
            }
            drawing.Geometry = buildGeometry();
            return drawing;
        }

        protected abstract Geometry buildGeometry();

        public override string ToString()
        {
            return " [" + this.penColor + ", " + this.fillColor + "]";
        }

    }
}
