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

        public const double IMG_WIDTH = 480;
        public const double IMG_HEIGHT = 320;

        private Palette currentTool;
        private Line supporterLine;
        private Rectangle supporterRectangle;

        private IEditor editor;

        public MainWindow()
        {
            InitializeComponent();
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

        private void WindowLoaded(object sender, RoutedEventArgs e)
        {
            this.editor = new Editor(this.image);
            this.initSupporters();
            this.currentTool = Palette.LINE;
            this.shapes.Items.Add(new EmptyShape());
            this.editor.drawImage();
        }

        private void initSupporters()
        {
            this.supporterLine = this.createSupporterLine();
            this.supporterRectangle = this.createSupporterRectangle();
            this.canvas.Children.Add(this.supporterLine);
            this.canvas.Children.Add(this.supporterRectangle);   
        }

        private Line createSupporterLine()
        {
            Line line = new Line();
            initSupporter(line);
            return line;
        }

        private Rectangle createSupporterRectangle()
        {
            Rectangle rectangle = new Rectangle();
            initSupporter(rectangle);
            rectangle.Width = 100;
            rectangle.Height = 50;
            Canvas.SetTop(rectangle, 20);
            Canvas.SetLeft(rectangle, 20);
            return rectangle;
        }

        private void initSupporter( Shape shape )
        {
            shape.Stroke = Brushes.Black;
            shape.StrokeDashArray = new DoubleCollection(new double[] { 1, 3 });
            shape.StrokeThickness = 0;
        }

        private void canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ButtonState == MouseButtonState.Pressed)
            {
                Point position = e.GetPosition(this.image);
                this.supporterLine.X1 = position.X;
                this.supporterLine.Y1 = position.Y;

                if (this.currentTool == Palette.LINE)
                {
                    this.supporterLine.StrokeThickness = 1;
                }
                else
                {
                    this.supporterRectangle.StrokeThickness = 1;
                }
            }
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            Point position = e.GetPosition(this.image);
            this.refreshCoordinates(position);
           
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.supporterLine.X2 = position.X;
                this.supporterLine.Y2 = position.Y;

                if (this.currentTool != Palette.LINE)
                {
                    this.drawSupporterRectangle(new Point(this.supporterLine.X1, this.supporterLine.Y1), position);
                }
            }
        }

        private void refreshCoordinates( Point point )
        {
            this.coordiantes.Text = Math.Round(point.X, 0).ToString() + " : " + Math.Round(point.Y, 0).ToString();  
        }

        private void drawSupporterRectangle( Point a, Point b )
        {
            Point topLeft = this.calculateTopLeftPoint(a, b);
            Size size = this.calculateSize(a, b);
            this.supporterRectangle.Width = size.Width;
            this.supporterRectangle.Height = size.Height;
            Canvas.SetLeft(this.supporterRectangle, topLeft.X);
            Canvas.SetTop(this.supporterRectangle, topLeft.Y);
        }

        private Point calculateTopLeftPoint(Point a, Point b)
        {
            return new Point(Math.Min(a.X, b.X), Math.Min(a.Y, b.Y));
        }

        private Size calculateSize(Point a, Point b)
        {
            return new Size(Math.Abs(a.X - b.X), Math.Abs(a.Y - b.Y));
        }

        private void canvas_MouseUp(object sender, MouseButtonEventArgs e)
        {
            this.supporterLine.StrokeThickness = 0;
            this.supporterRectangle.StrokeThickness = 0;

            Point endPosition = e.GetPosition(this.image);

            Color penColor = this.getColorFromSolidColorBrush(this.penColorTool.Fill);
            Color fillColor = this.getColorFromSolidColorBrush(this.fillColorTool.Fill);
            double penWidth = getPenWidth();

            Point startPosition = new Point(this.supporterLine.X1, this.supporterLine.Y1);
            Point topLeft = this.calculateTopLeftPoint(startPosition, endPosition);
            Size size = this.calculateSize(startPosition, endPosition);
            Point middle = this.calculateMiddlePoint(topLeft, size);

            IShape currentShape = null;
            switch (this.currentTool)
            {
                case Palette.LINE:
                    currentShape = new LineShape(penColor, fillColor, penWidth, startPosition, endPosition);
                    break;
                case Palette.RECTANGLE:
                    currentShape = new RectangleShape(penColor, fillColor, penWidth, topLeft, size);
                    break;
                case Palette.ELLIPSE:
                    currentShape = new EllipseShape(penColor, fillColor, penWidth, middle, size.Width / 2, size.Height / 2);
                    break;
            }
            if (currentShape != null)
            {
                this.editor.draw(currentShape);
                this.shapes.Items.Add(currentShape);
            }
        }

        private Point calculateMiddlePoint(Point topLeft, Size size)
        {
            return new Point(topLeft.X + size.Width / 2, topLeft.Y + size.Height / 2);
        }

        private Color getColorFromSolidColorBrush(Brush brush)
        {
            Color result = Colors.Black;
            if (brush is SolidColorBrush)
            {
                SolidColorBrush solidColorBrush = (SolidColorBrush)brush;
                result = solidColorBrush.Color;
            }
            return result;
        }

        private double getPenWidth()
        {
            double result = 1;
            if (this.penWidthTool.SelectedItem is ComboBoxItem)
            {
                ComboBoxItem item = (ComboBoxItem)this.penWidthTool.SelectedItem;
                result = Double.Parse(item.Content.ToString());
            }
            return result;
        }

        private void changeToolClick(object sender, RoutedEventArgs e)
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

        private void colorPickerToolMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (sender is Rectangle)
            {
                Rectangle tool = (Rectangle)sender;

                ColorDialog picker = new ColorDialog();
                picker.Color = tool.Fill;
                Nullable<Boolean> result = picker.ShowDialog();
                if (result.HasValue && result.Value)
                {
                    tool.Fill = picker.Color;
                    IShape currentShape = this.getSelectedShape();
                    if (currentShape != null)
                    {
                        Color color = this.getColorFromSolidColorBrush(picker.Color);
                        this.editor.changeColor(currentShape, color);
                    }
                }
            }
        }

        private IShape getSelectedShape()
        {
            IShape shape = null;
            if (this.shapes.SelectedItem is IShape )
            {
                shape = (IShape)this.shapes.SelectedItem;
            }
            return shape;
        }

        private void undoClick(object sender, RoutedEventArgs e)
        {
            this.editor.undo();
        }

        private void redoClick(object sender, RoutedEventArgs e)
        {
            this.editor.redo();
        }

    }
}
