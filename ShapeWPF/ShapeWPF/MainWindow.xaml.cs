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

namespace ShapeWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Ellipse_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            if (sender is Ellipse)
            {
                Ellipse ellipse = (Ellipse)sender;
                double uniformLength = ellipse.Margin.Left;
                ellipse.Margin = new Thickness(uniformLength + e.Delta / 100);
            }
        }
    }
}
