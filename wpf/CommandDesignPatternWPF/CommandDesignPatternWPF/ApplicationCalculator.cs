using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace CommandDesignPatternWPF
{
    public class ApplicationCalculator
    {

        public Line createSupporterLine()
        {
            Line line = new Line();
            initSupporter(line);
            return line;
        }

        public Rectangle createSupporterRectangle()
        {
            Rectangle rectangle = new Rectangle();
            initSupporter(rectangle);
            rectangle.Width = 100;
            rectangle.Height = 50;
            Canvas.SetTop(rectangle, 20);
            Canvas.SetLeft(rectangle, 20);
            return rectangle;
        }

        private void initSupporter(Shape shape)
        {
            shape.Stroke = Brushes.Black;
            shape.StrokeDashArray = new DoubleCollection(new double[] { 1, 3 });
            shape.StrokeThickness = 0;
        }

        public String getCoordinatesInfo(Point point)
        {
            return Math.Round(point.X, 0).ToString() + " : " + Math.Round(point.Y, 0).ToString();
        }

        public Point calculateTopLeftPoint(Point a, Point b)
        {
            return new Point(Math.Min(a.X, b.X), Math.Min(a.Y, b.Y));
        }

        public Size calculateSize(Point a, Point b)
        {
            return new Size(Math.Abs(a.X - b.X), Math.Abs(a.Y - b.Y));
        }

        public Point calculateMiddlePoint(Point topLeft, Size size)
        {
            return new Point(topLeft.X + size.Width / 2, topLeft.Y + size.Height / 2);
        }

        public Nullable<Color> getColorFromSolidColorBrush(Brush brush)
        {
            Nullable<Color> result = null;
            if (brush is SolidColorBrush)
            {
                SolidColorBrush solidColorBrush = (SolidColorBrush)brush;
                result = solidColorBrush.Color;
            }
            return result;
        }

    }
}
