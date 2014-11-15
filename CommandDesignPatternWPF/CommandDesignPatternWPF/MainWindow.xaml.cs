using System;
using System.Collections.Generic;
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

namespace CommandDesignPatternWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private const double IMG_WIDTH = 480;
        private const double IMG_HEIGHT = 320;

        private Palette currentTool;
        private List<AppLine> lines;

        private Point currentPoint = new Point();

        private Line tmpLine;

        public MainWindow()
        {
            InitializeComponent();
            this.lines = new List<AppLine>();
            this.tmpLine = new Line();
            this.tmpLine.Stroke = Brushes.Black;
            this.tmpLine.StrokeThickness = 1;
           
            this.canvas.Children.Add(this.tmpLine);
        }

        private void MenuItemExitClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void NewCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void NewCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("New document");
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            this.currentTool = Palette.LINE;
            this.image.Source = this.getImage();
        }

        public DrawingImage getImage()
        {
            return new DrawingImage(this.buildDrawing());
        }

        private Drawing buildDrawing()
        {
            DrawingGroup group = new DrawingGroup();
            group.Children.Add(buildImageFrame2());
            for (int i = 0; i < this.lines.Count; i++)
            {
                group.Children.Add(this.lines[i].buildDrawing());
            }
            return group;
        }

        private GeometryDrawing buildImageFrame2()
        {
            Geometry geometry = new RectangleGeometry(new Rect(new Point(0, 0), new Size(IMG_WIDTH, IMG_HEIGHT)));
            return new GeometryDrawing(Brushes.White, new Pen(Brushes.Black, 1), geometry);
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            Point point = e.GetPosition(this.image);
            this.x.Text = point.X.ToString();
            this.y.Text = point.Y.ToString();

            if (e.LeftButton == MouseButtonState.Pressed)
            {
                Point position = e.GetPosition(this.image);
                this.tmpLine.X2 = position.X;
                this.tmpLine.Y2 = position.Y;

                
            }
        }

        private void ChangeToolClick(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton)
            {
                RadioButton radioButton = (RadioButton)sender;
                if (radioButton.Tag is Palette)
                {
                    Palette drawingTool = (Palette)radioButton.Tag;
                    this.currentTool = drawingTool;
                }
            }
        }

        private void canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ButtonState == MouseButtonState.Pressed)
            {
                Point position = e.GetPosition(this.image);
                currentPoint = position;
                this.tmpLine.X1 = position.X;
                this.tmpLine.Y1 = position.Y;
                this.tmpLine.StrokeThickness = 1;
            }
        }

        private void canvas_MouseUp(object sender, MouseButtonEventArgs e)
        {
            this.tmpLine.StrokeThickness = 0;

            Point position = e.GetPosition(this.image);

            this.lines.Add(new AppLine(this.currentPoint, position));
            this.image.Source = this.getImage();
        }


    }
}
