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
    public class GraphPoint
    {

        private const String FILE_EXTENSION = ".points";
        private const char DELIMITER = ';';
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

        public Drawing buildDrawing()
        {
            GeometryDrawing drawing = new GeometryDrawing();
            drawing.Pen = new Pen(Brushes.Black, 1);
            drawing.Brush = new SolidColorBrush(this.color);
            drawing.Geometry = buildGeometry();
            return drawing;
        }

        private GeometryGroup buildGeometry()
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
            FormattedText text = GraphPoint.getText(this.name);
            double x = this.position.X - text.Width / 2;
            double y = this.position.Y + this.radius + 2;
            return text.BuildGeometry(new Point(x, y));
        }

        public override string ToString()
        {
            return this.name + " (" + this.id + ")";
        }

        private static FormattedText getText(String value)
        {
            return new FormattedText(value, CultureInfo.CurrentCulture, FlowDirection.LeftToRight, FONT_FAMILY, FONT_SIZE, FONT_COLOR);
        }

        public static String buildPath(String directory, String baseFileName)
        {
            return directory + Path.DirectorySeparatorChar + baseFileName + GraphPoint.FILE_EXTENSION;
        }

        public static void load(string fileName, Graph graph)
        {
            StreamReader reader = null;
            try
            {
                reader = new StreamReader(File.Open(fileName, FileMode.Open));
                String line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    graph.add(GraphPoint.parse(line));
                }
            }
            catch (System.Exception e)
            {
                throw new BadFileFormatException("Unexpected error while parsing '" + fileName + "'.", e);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
        }

        private static GraphPoint parse(String line)
        {
            try
            {
                string[] lineItem = line.Split(GraphPoint.DELIMITER);
                return new GraphPoint(
                                Convert.ToInt32(lineItem[0]),
                                lineItem[1],
                                Convert.ToDouble(lineItem[2]),
                                Convert.ToDouble(lineItem[3]),
                                Convert.ToDouble(lineItem[4]),
                                Convert.ToByte(lineItem[5]),
                                Convert.ToByte(lineItem[6]),
                                Convert.ToByte(lineItem[7]));
            }
            catch (System.Exception e)
            {
                throw new GraphParseException("GraphPoint parse error.", line, e);
            }
        }

    }
}
