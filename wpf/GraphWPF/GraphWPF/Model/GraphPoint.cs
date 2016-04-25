using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Windows.Media;
using System.Windows;
using System.Globalization;
using GraphWPF.Exception;

namespace GraphWPF.Model
{
    public class GraphPoint : GraphElement
    {

        public const String EXTENSION = ".points";

        private const double FONT_SIZE = 10;
        private static readonly Typeface FONT_FAMILY = new Typeface("Tahoma");
        private static readonly Brush FONT_COLOR = Brushes.Black;

        private readonly int id;
        private readonly string name;
        private readonly Point position;
        private readonly double radius;
        private readonly Color color;

        public int Id
        {
            get { return this.id; }
        }

        public Point Position
        {
            get { return this.position; }
        }

        protected override double PenThickness
        {
            get { return 1; }
        }

        private Rect Rect
        {
            get
            {
                double dimension = this.radius * 2;
                return new Rect(this.position.X - this.radius, this.position.Y - this.radius, dimension, dimension);
            }
        }

        public GraphPoint(int id, string name, double x, double y, double radius, byte red, byte green, byte blue)
        {
            this.id = id;
            this.name = name;
            this.position = new Point(x, y);
            this.radius = radius;
            this.color = Color.FromRgb(red, green, blue);
        }

        protected override Brush getBrush()
        {
            return new SolidColorBrush(this.color);
        }

        protected override Geometry buildGeometry()
        {
            GeometryGroup group = new GeometryGroup();
            group.Children.Add(getGeometryPoint());
            group.Children.Add(getGeometryName());
            return group;
        }

        private Geometry getGeometryPoint()
        {
            return new EllipseGeometry(this.Rect);
        }

        private Geometry getGeometryName()
        {
            FormattedText text = getText(this.name);
            double x = this.position.X - text.Width / 2;
            double y = this.position.Y + this.radius + 2;
            return text.BuildGeometry(new Point(x, y));
        }
        private static FormattedText getText(String value)
        {
            return new FormattedText(value, CultureInfo.CurrentCulture, FlowDirection.LeftToRight, FONT_FAMILY, FONT_SIZE, FONT_COLOR);
        }

        public override string ToString()
        {
            return this.name + " (" + this.id + ")";
        }

        public static GraphPoint parse(Graph graph, String line)
        {
            try
            {
                string[] items = line.Split(DELIMITER);
                return new GraphPoint(
                                Convert.ToInt32(items[0]),
                                items[1],
                                Convert.ToDouble(items[2]),
                                Convert.ToDouble(items[3]),
                                Convert.ToDouble(items[4]),
                                Convert.ToByte(items[5]),
                                Convert.ToByte(items[6]),
                                Convert.ToByte(items[7]));
            }
            catch (System.Exception e)
            {
                throw new GraphParseException("GraphPoint parse error.", line, e);
            }
        }

    }
}
