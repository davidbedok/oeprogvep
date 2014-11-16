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

        private Brush color;
        private List<Brush> colors;

        public Brush Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public ColorDialog()
        {
            InitializeComponent();
        }

        private void Grid_Loaded_1(object sender, RoutedEventArgs e)
        {
            this.initColors();
            this.Title += " " + this.color;
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
                    Rectangle rectangle = this.buildColorRectangle(this.colors[index++]);

                    Grid.SetColumn(rectangle, k);
                    Grid.SetRow(rectangle, i);
                    this.grid.Children.Add(rectangle);
                }
            }
        }

        private Rectangle buildColorRectangle( Brush currentColor )
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Margin = new Thickness(2);
            rectangle.VerticalAlignment = System.Windows.VerticalAlignment.Stretch;
            rectangle.HorizontalAlignment = System.Windows.HorizontalAlignment.Stretch;
            rectangle.Width = 20;
            rectangle.Height = 20;
            rectangle.Fill = currentColor;
            if (currentColor == this.color)
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

        private void initColors()
        {
            this.colors = new List<Brush>();
            PropertyInfo[] publicStaticMembers = typeof(Brushes).GetProperties(BindingFlags.Public | BindingFlags.Static);
            foreach (PropertyInfo member in publicStaticMembers)
            {
                this.colors.Add((Brush)member.GetValue(null, null));
            }
        }

        private void colorRectMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (sender is Rectangle)
            {
                Rectangle rectangle = (Rectangle)sender;
                this.color = rectangle.Fill;
                this.DialogResult = true;
            }
        }

    }
}
