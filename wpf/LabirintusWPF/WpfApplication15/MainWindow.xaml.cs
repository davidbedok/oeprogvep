using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfApplication15
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

        Labirintus labirintus;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            using (StreamReader reader = new StreamReader("labirintus1.txt"))
            {
                labirintus = new Labirintus(reader.ReadToEnd());
            }
            this.DataContext = labirintus;
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            bool vege = false;
            if (e.Key == Key.Up)
            {
                vege = labirintus.Mozgat(0, -1);
            }
            else if (e.Key == Key.Down)
            {
                vege = labirintus.Mozgat(0, 1);
            }
            else if (e.Key == Key.Left)
            {
                vege = labirintus.Mozgat(-1, 0);
            }
            else if (e.Key == Key.Right)
            {
                vege = labirintus.Mozgat(1, 0);
            }
            if (vege)
            {
                MessageBox.Show("Gratulálok, eljutottál a végéig!");
            }
        }
    }
}
