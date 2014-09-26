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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            for (int i = 0; i < 3; i++)
            {
                this.mainGrid.ColumnDefinitions.Add(new ColumnDefinition());
                this.mainGrid.RowDefinitions.Add(new RowDefinition());
            }

            int number = 1;
            for (int i = 0; i < 3; i++)
            {
                for (int k = 0; k < 3; k++)
                {
                    Button button = new Button();
                    button.Margin = new Thickness(10, 10, 10, 10);
                    // button.Padding = new Thickness(10, 10, 10, 10);
                    button.VerticalAlignment = System.Windows.VerticalAlignment.Stretch;
                    button.HorizontalAlignment = System.Windows.HorizontalAlignment.Stretch;
                    button.Content = number++;
                    
                    Grid.SetColumn(button, k);
                    Grid.SetRow(button, i);
                    this.mainGrid.Children.Add(button);
                }

            }

        }
    }
}
