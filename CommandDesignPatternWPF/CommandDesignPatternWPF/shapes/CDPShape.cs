using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace CommandDesignPatternWPF
{
    public abstract class CDPShape : IShape
    {

        private Color penColor;
        private Color fillColor;
        private double penWidth;
        private Point referencePoint;

        public Color PenColor
        {
            get { return this.penColor; }
            set { this.penColor = value; }
        }

        public Color FillColor
        {
            get { return this.fillColor; }
            set { this.fillColor = value; }
        }

        public Point ReferencePoint
        {
            get { return this.referencePoint; }
            set { this.referencePoint = value; }
        }

        public CDPShape(Color penColor, Color fillColor, double penWidth, Point referencePoint)
        {
            this.penColor = penColor;
            this.fillColor = fillColor;
            this.penWidth = penWidth;
            this.referencePoint = referencePoint;
        }

        public Drawing buildDrawing()
        {
            GeometryDrawing drawing = new GeometryDrawing();
            drawing.Pen = new Pen(new SolidColorBrush(this.penColor), this.penWidth);
            drawing.Brush = new SolidColorBrush(this.fillColor);
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
