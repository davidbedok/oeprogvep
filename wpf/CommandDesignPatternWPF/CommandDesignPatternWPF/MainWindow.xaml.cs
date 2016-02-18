using CommandDesignPatternWPF.engine;
using CommandDesignPatternWPF.shapes;
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
    public partial class MainWindow : Window
    {

        public const double IMG_WIDTH = 480;
        public const double IMG_HEIGHT = 320;
        private const double MOVE_PARAM = 5;

        private Palette palette;
        private Line supporterLine;
        private Rectangle supporterRectangle;
        private IEditor editor;
        private ApplicationCalculator calculator;

        public MainWindow()
        {
            InitializeComponent();
            this.calculator = new ApplicationCalculator();
        }

        private void exitMenuItemClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void newCommandCanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void newCommandExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Here you can create a new empty drawing.");
        }

        private void openMenuItemClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Here you can open an existing drawing...");
        }

        private void windowLoaded(object sender, RoutedEventArgs e)
        {
            this.editor = new Editor(this.image);
            this.initSupporters();
            this.palette = Palette.LINE;
            this.shapes.Items.Add(new EmptyShape());
            this.historyStatusItem.DataContext = this.editor;
            this.editor.drawImage();
        }

        private void initSupporters()
        {
            this.supporterLine = this.calculator.createSupporterLine();
            this.supporterRectangle = this.calculator.createSupporterRectangle();
            this.canvas.Children.Add(this.supporterLine);
            this.canvas.Children.Add(this.supporterRectangle);
        }

        private void canvasMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ButtonState == MouseButtonState.Pressed)
            {
                Point position = e.GetPosition(this.image);
                this.supporterLine.X1 = position.X;
                this.supporterLine.Y1 = position.Y;

                if (this.palette == Palette.LINE)
                {
                    this.supporterLine.StrokeThickness = 1;
                }
                else
                {
                    this.supporterRectangle.StrokeThickness = 1;
                }
            }
        }

        private void canvasMouseMove(object sender, MouseEventArgs e)
        {
            Point position = e.GetPosition(this.image);
            this.coordiantes.Text = this.calculator.getCoordinatesInfo(position);
            
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.supporterLine.X2 = position.X;
                this.supporterLine.Y2 = position.Y;

                if (this.palette != Palette.LINE)
                {
                    this.drawSupporterRectangle(new Point(this.supporterLine.X1, this.supporterLine.Y1), position);
                }
            }
        }

        private void drawSupporterRectangle(Point a, Point b)
        {
            Point topLeft = this.calculator.calculateTopLeftPoint(a, b);
            Size size = this.calculator.calculateSize(a, b);
            this.supporterRectangle.Width = size.Width;
            this.supporterRectangle.Height = size.Height;
            Canvas.SetLeft(this.supporterRectangle, topLeft.X);
            Canvas.SetTop(this.supporterRectangle, topLeft.Y);
        }

        private void canvasMouseUp(object sender, MouseButtonEventArgs e)
        {
            this.supporterLine.StrokeThickness = 0;
            this.supporterRectangle.StrokeThickness = 0;

            Point endPosition = e.GetPosition(this.image);

            Nullable<Color> penColor = this.calculator.getColorFromSolidColorBrush(this.penColorTool.Fill);
            Nullable<Color> fillColor = this.calculator.getColorFromSolidColorBrush(this.fillColorTool.Fill);
            double penWidth = getPenWidth();

            Point startPosition = new Point(this.supporterLine.X1, this.supporterLine.Y1);
            Point topLeft = this.calculator.calculateTopLeftPoint(startPosition, endPosition);
            Size size = this.calculator.calculateSize(startPosition, endPosition);
            Point middle = this.calculator.calculateMiddlePoint(topLeft, size);

            IShape currentShape = null;
            switch (this.palette)
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
                    this.palette = drawingTool;
                }
            }
        }

        private void colorPickerToolMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (sender is Rectangle)
            {
                Rectangle tool = (Rectangle)sender;

                ColorDialog picker = new ColorDialog();
                picker.Brush = tool.Fill;
                Nullable<Boolean> result = picker.ShowDialog();
                if (result.HasValue && result.Value)
                {
                    Nullable<Color> color = null;
                    if (picker.Brush != null)
                    {
                        tool.StrokeDashArray = new DoubleCollection(new double[] {});
                        tool.Fill = picker.Brush;
                        color = this.calculator.getColorFromSolidColorBrush(picker.Brush);
                    }
                    else
                    {
                        tool.Fill = null;
                        tool.StrokeDashArray = new DoubleCollection(new double[] {1, 2});
                    }
                    IShape currentShape = this.getSelectedShape();
                    if (currentShape != null)
                    {
                        if (tool.Tag is ColorType)
                        {
                            ColorType type = (ColorType)tool.Tag;
                            this.editor.changeColor(currentShape, type, color);
                        }
                    }
                }
            }
        }

        private IShape getSelectedShape()
        {
            IShape shape = null;
            if (this.shapes != null && this.shapes.SelectedItem is IShape)
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

        private void windowKeyDown(object sender, KeyEventArgs e)
        {
            IShape shape = this.getSelectedShape();
            if (shape != null)
            {
                MoveType type = MoveType.UP;
                if (e.Key == Key.Up)
                {
                    type = MoveType.UP;
                }
                else if (e.Key == Key.Left)
                {
                    type = MoveType.LEFT;
                }
                else if (e.Key == Key.Down)
                {
                    type = MoveType.DOWN;
                }
                else if (e.Key == Key.Right)
                {
                    type = MoveType.RIGHT;
                }
                this.editor.move(shape, type, MOVE_PARAM);
            }
        }

        private void penWidthToolSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            IShape shape = this.getSelectedShape();
            if (shape != null)
            {
                this.editor.changePenWidth(shape, this.getPenWidth());
            }
        }

    }
}
