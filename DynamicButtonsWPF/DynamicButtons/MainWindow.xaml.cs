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

namespace DynamicButtons
{
    public partial class MainWindow : Window
    {
        private const int NUMBER_OF_COLUMNS = 3;
        private const int NUMBER_OF_ROWS = 4;
        public MainWindow()
        {
            InitializeComponent();

            for (int i = 0; i < NUMBER_OF_COLUMNS; i++)
            {
                this.mainGrid.ColumnDefinitions.Add(new ColumnDefinition());
            }
            for (int i = 0; i < NUMBER_OF_ROWS; i++)
            {
                this.mainGrid.RowDefinitions.Add(new RowDefinition());
            }

            int number = 1;
            for (int i = 0; i < NUMBER_OF_ROWS; i++)
            {
                for (int k = 0; k < NUMBER_OF_COLUMNS; k++)
                {
                    Button button = new Button();
                    button.Margin = new Thickness(10, 10, 10, 10);
                    // button.Padding = new Thickness(10, 10, 10, 10);
                    button.VerticalAlignment = System.Windows.VerticalAlignment.Stretch;
                    button.HorizontalAlignment = System.Windows.HorizontalAlignment.Stretch;
                    button.Content = number++;
                    button.Click += button_Click;

                    Grid.SetColumn(button, k);
                    Grid.SetRow(button, i);
                    this.mainGrid.Children.Add(button);
                }
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button)
            {
                Button button = (Button)sender;
                MessageBox.Show(button.Content.ToString());
            }
        }
    }
}
