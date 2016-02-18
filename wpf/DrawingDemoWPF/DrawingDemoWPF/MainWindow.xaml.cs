using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DrawingDemoWPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // this.imgDemo.Source = createImage();
            this.imgDemo.Source = new DrawingImage(createGroupDrawing());
        }

        private ImageSource createImage()
        {
            // DrawingImage image = new DrawingImage();
            // image.Drawing = createDrawing();
            return new DrawingImage(createDrawingWithRectangleGeometry());
        }

        private Drawing createDrawingWithRectangleGeometry()
        {
            // GeometryDrawing drawing = new GeometryDrawing();
            // drawing.Brush = Brushes.Blue;
            // drawing.Geometry = createRectangle();
            return new GeometryDrawing(Brushes.Blue, new Pen(Brushes.Black, 2), buildBigRectangle());
        }

        private Drawing createGroupDrawing()
        {
            DrawingGroup group = new DrawingGroup();
            group.Children.Add(createDrawingWithFrameRectangleGeometry());
            group.Children.Add(createDrawingWithRectangleGeometry());
            group.Children.Add(createDrawingWithSmallRectangleGeometry());
            group.Children.Add(createDrawingWithGroupGemoetry());
            return group;
        }

        private Drawing createDrawingWithFrameRectangleGeometry()
        {
            GeometryDrawing drawing = new GeometryDrawing();
            drawing.Pen = new Pen(Brushes.Black, 1);
            drawing.Geometry = buildFrameRectangle();
            return drawing;
        }
        private Drawing createDrawingWithSmallRectangleGeometry()
        {
            return new GeometryDrawing(Brushes.Yellow, new Pen(Brushes.Black, 1), buildSmallRectangle());
        }

        private Drawing createDrawingWithGroupGemoetry()
        {
            GeometryDrawing drawing = new GeometryDrawing();
            drawing.Pen = new Pen(Brushes.Black, 1);
            drawing.Geometry = buildGeometryGroup();
            return drawing;
        }

        private GeometryGroup buildGeometryGroup()
        {
            GeometryGroup group = new GeometryGroup();
            group.Children.Add(buildEllipse());
            group.Children.Add(buildText());
            return group;
        }

        private Geometry buildText()
        {
            FormattedText text = new FormattedText("Lorem ipsum", CultureInfo.CurrentCulture, FlowDirection.LeftToRight, new Typeface("Tahoma"), 12, Brushes.Black);
            return text.BuildGeometry(new Point(10, 20));
        }

        private Geometry buildFrameRectangle()
        {
            return new RectangleGeometry(new Rect(new Point(0, 0), new Size(this.imgDemo.Width, this.imgDemo.Height)));
        }

        private Geometry buildBigRectangle()
        {
            return new RectangleGeometry(new Rect(new Point(25, 25), new Size(200, 100)));
        }

        private Geometry buildSmallRectangle()
        {
            return new RectangleGeometry(new Rect(new Point(0, 0), new Size(100, 50)));
        }

        private Geometry buildEllipse()
        {
            return new EllipseGeometry(new Rect(new Point(150, 60), new Size(40, 70)));
        }

    }
}
