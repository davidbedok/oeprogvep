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

namespace RotateWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private readonly DispatcherTimer timer;

        private Rectangle shape;
        private int angle;

        public MainWindow()
        {
            InitializeComponent();

            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 0, 0, 10);
            timer.Tick += timer_Tick;
            timer.Stop();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.shape = new Rectangle();
            this.shape.Width = 150;
            this.shape.Height = 70;
            this.shape.StrokeThickness = 3;
            this.shape.Stroke = Brushes.Black;

            this.shape.RenderTransformOrigin = new Point(0.5, 0.5);

            this.canvas.Children.Add(this.shape);

            this.timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.shape.RenderTransform = new RotateTransform(this.angle++);
        }

    }
}
