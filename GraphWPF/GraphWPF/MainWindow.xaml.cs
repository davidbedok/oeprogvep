using GraphWPF.Exception;
using GraphWPF.Model;
using Microsoft.Win32;
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

namespace GraphWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public const double IMG_X = 400;
        public const double IMG_Y = 300;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenGraph_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Graph files (*.graph)|*.graph";
            Nullable<Boolean> result = dialog.ShowDialog();
            if (result.HasValue && result.Value)
            {
                try
                {
                    this.imgGraph.Source = Graph.load(dialog.FileName).getImage();
                }
                catch (BadFileFormatException exc)
                {
                    MessageBox.Show(exc.ToString(), "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

    }
}
