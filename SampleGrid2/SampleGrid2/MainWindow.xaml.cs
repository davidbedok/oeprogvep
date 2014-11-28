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

namespace SampleGrid2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const int N = 10;
        private const int M = 7;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < N; i++)
            {
                this.grid.RowDefinitions.Add(new RowDefinition());
            }
            for (int i = 0; i < M; i++)
            {
                this.grid.ColumnDefinitions.Add(new ColumnDefinition());
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Ellipse ellipse = new Ellipse();
                    ellipse.Fill = Brushes.AliceBlue;
                    ellipse.Stroke = Brushes.Black;
                    ellipse.Margin = new Thickness(5);
                    ellipse.MouseDown += ellipse_MouseDown;

                    Grid.SetRow(ellipse, i);
                    Grid.SetColumn(ellipse, j);
                    this.grid.Children.Add(ellipse);
                }
            }
        }

        private void ellipse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (sender is Ellipse)
            {
                Ellipse ellipse = (Ellipse)sender;
                MessageBox.Show(Grid.GetRow(ellipse) + ": " + Grid.GetColumn(ellipse));
            }
        }
    }
}
