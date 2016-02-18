using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace CommandDesignPatternWPF
{

    public partial class ColorDialog : Window
    {

        private const int COLUMNS = 12;
        private const int ROWS = 11;

        private Brush brush;
        private List<Brush> brushes;

        public Brush Brush
        {
            get { return this.brush; }
            set { this.brush = value; }
        }

        public ColorDialog()
        {
            InitializeComponent();
        }

        private void gridLoaded(object sender, RoutedEventArgs e)
        {
            this.initBrushes();
            this.Title += " " + this.brush;
            this.buildColorGrid();
        }

        private void buildColorGrid()
        {
            for (int i = 0; i < COLUMNS; i++)
            {
                this.grid.ColumnDefinitions.Add(new ColumnDefinition());
            }
            for (int i = 0; i < ROWS; i++)
            {
                this.grid.RowDefinitions.Add(new RowDefinition());
            }

            int index = 0;
            for (int i = 0; i < ROWS; i++)
            {
                for (int k = 0; k < COLUMNS; k++)
                {
                    Rectangle rectangle = this.buildColorRectangle(this.brushes[index++]);

                    Grid.SetColumn(rectangle, k);
                    Grid.SetRow(rectangle, i);
                    this.grid.Children.Add(rectangle);
                }
            }
        }

        private Rectangle buildColorRectangle( Brush currentBrush )
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Margin = new Thickness(2);
            rectangle.VerticalAlignment = System.Windows.VerticalAlignment.Stretch;
            rectangle.HorizontalAlignment = System.Windows.HorizontalAlignment.Stretch;
            rectangle.Width = 20;
            rectangle.Height = 20;
            rectangle.Fill = currentBrush;
            if (this.brush != null && currentBrush == this.brush)
            {
                rectangle.StrokeThickness = 3;
                rectangle.Stroke = Brushes.Black;
            }
            else
            {
                rectangle.StrokeThickness = 1;
                rectangle.Stroke = Brushes.Gray;
            }
            rectangle.MouseLeftButtonUp += colorRectMouseLeftButtonUp;
            return rectangle;
        }

        private void initBrushes()
        {
            this.brushes = new List<Brush>();
            PropertyInfo[] publicStaticMembers = typeof(Brushes).GetProperties(BindingFlags.Public | BindingFlags.Static);
            foreach (PropertyInfo member in publicStaticMembers)
            {
                this.brushes.Add((Brush)member.GetValue(null, null));
            }
        }

        private void colorRectMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (sender is Rectangle)
            {
                Rectangle rectangle = (Rectangle)sender;
                this.brush = rectangle.Fill;
                this.DialogResult = true;
            }
        }

        private void transparentMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            this.brush = null;
            this.DialogResult = true;
        }

    }
}
