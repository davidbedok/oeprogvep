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
using System.Windows.Threading;

namespace ShapeBindings
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer;
        private Ball labda;

        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 0, 0, 50);
            timer.Tick += timer_Tick;
        }

        void timer_Tick(object sender, EventArgs e)
        {
            if (this.labda != null)
            {
                this.labda.move();
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.labda = new Ball(50, 50);
            this.canvas.Children.Add(this.labda.getEllipse());

            timer.Start();
        }

    }
}
